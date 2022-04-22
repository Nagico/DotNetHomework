var spider = new WebSpider.Spider("https://www.cnblogs.com/dstang2000/", 5, 100);

int cnt = 0;

spider.PageComplete += (WebSpider.Spider spider, WebSpider.WebPage webPage) =>
{
    cnt++;
    Console.WriteLine($"{cnt}: {webPage.Msg}");
};
spider.CrawlComplete += (WebSpider.Spider spider) => Console.WriteLine("Finish");

spider.Crawl();

Console.WriteLine();