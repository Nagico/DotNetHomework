using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace WebSpider
{
    public class Spider
    {
        private Uri startUrl;
        private int maxDepth;
        private int totalCount;
        private int count;

        private BlockingCollection<Task> tasks = new();
        private HttpClient client = new HttpClient();
        private BlockingCollection<WebPage> webPages = new();

        public event Action<Spider> CrawlComplete = delegate { };
        public event Action<Spider, WebPage> PageComplete = delegate { };

        public Spider(string startUrl, int depth = 3, int totalCount = 50)
        {
            this.startUrl = new Uri(startUrl);
            maxDepth = depth;
            this.totalCount = totalCount;
            count = 0;
        }

        public void Crawl()
        {
            var startPage = new WebPage(startUrl, 0);
            tasks.Add(Task.Run(async () => await FetchPage(startPage)));
            while (count < totalCount)
            {
                Thread.Sleep(500);
            }
            Task.WaitAll(tasks.ToArray());
            CrawlComplete(this);
        }

        //public async Task CrawlAsync()
        //{
        //    while (true)
        //    {
        //        WebPage? current = null;
        //        int curDepth = 0;
        //        foreach (var page in pages)
        //        {
        //            curDepth = Math.Max(curDepth, page.Depth);
        //            if (!page.IsFinish)
        //            {
        //                current = page;
        //                break;
        //            }
        //        }

        //        if (current == null)
        //        {
        //            if (curDepth == maxDepth) // finish
        //                break;
        //            await Task.Delay(500); // wait for new page
        //            continue;
        //        }

        //        if (count == totalCount)
        //            break;

        //        Console.WriteLine(current);
        //        string html = await DownLoad(current);
        //        current.IsFinish = true;
        //        count++;
        //        if (current.Depth < maxDepth)
        //        {
        //            Parse(html, current);
        //        }
        //    }

        //    while(pages.Count != totalCount)
        //    {
        //        pages.RemoveAt(pages.Count - 1);
        //    }

        //}

        private async Task FetchPage(WebPage webPage)
        {
            int currentIndex;
            lock (this)
            {
                count++;
                currentIndex = count;
            }
            if (currentIndex > totalCount)
                return;

            webPage.Index = currentIndex;
            string html = await DownLoad(webPage);
            webPage.IsFinish = true;
            PageComplete(this, webPage);
            if (webPage.Depth < maxDepth)
            {
                Parse(html, webPage);
            }
        }

        private async Task<string> DownLoad(WebPage webPage)
        {
            try
            {
                webPage.Msg = "Fetching...";
                HttpResponseMessage response = await client.GetAsync(webPage.Uri);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                string fileName = webPage.Index.ToString();
                await File.WriteAllTextAsync(fileName, responseBody, Encoding.UTF8);
                webPage.Msg = "Success";
                webPage.IsSuccess = true;
                return responseBody;
            }
            catch (Exception ex)
            {
                webPage.Msg = "Fail: " + ex.Message;
                webPage.IsSuccess = false;
                return "";
            }
        }

        private void Parse(string html, WebPage webPage)
        {
            string pattern = @"(href|HREF)[]*=[]*[""'][^""'#>]+(/|.html|.htm|.aspx|.php|.jsp)[""']";

            MatchCollection matches = new Regex(pattern).Matches(html);
            foreach (Match match in matches)
            {
                string strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0)
                    continue;
                var page = new WebPage(new Uri(webPage.Uri, strRef), webPage.Depth + 1);

                if (page.Uri.Host == webPage.Uri.Host && !webPages.Contains(page))
                {
                    webPages.Add(page);
                    tasks.Add(Task.Run(() => FetchPage(page)));
                }
            }
        }
    }
}
