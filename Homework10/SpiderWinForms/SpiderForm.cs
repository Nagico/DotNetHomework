using System.ComponentModel;

namespace SpiderWinForms
{
    public partial class fmSpider : Form
    {
        public string Url { get; set; }
        public int Depth { get; set; }
        public int Count { get; set; }
        private BindingList<WebSpider.WebPage> pages = new();

        public fmSpider()
        {
            InitializeComponent();
        }

        private void fmSpider_Load(object sender, EventArgs e)
        {
            Url = "https://www.cnblogs.com/dstang2000/";
            Count = 50;
            Depth = 3;
            txtUrl.DataBindings.Add("Text", this, "Url");
            txtCount.DataBindings.Add("Text", this, "Count");
            txtDepth.DataBindings.Add("Text", this, "Depth");
            bsPages.DataSource = pages;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                pages.Clear();
                new Thread(() => 
                {
                    WebSpider.Spider spider = new WebSpider.Spider(Url, Depth, Count);

                    spider.PageComplete += (s, webPage) => Invoke(() => pages.Add(webPage));
                    spider.CrawlComplete += (s) => Invoke(() => MessageBox.Show("Finish"));

                    spider.Crawl();
                }).Start();
                // bsPages.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}