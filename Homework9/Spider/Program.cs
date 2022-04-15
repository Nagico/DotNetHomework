//var spider = new Spider.Spider("https://docs.microsoft.com/en-us/dotnet/api/system.uri?view=net-6.0", 5);
var spider = new WebSpider.Spider("https://www.cnblogs.com/dstang2000/", 3, 100);

// new Thread(spider.Crawl).Start();

await spider.Crawl();

Console.WriteLine();