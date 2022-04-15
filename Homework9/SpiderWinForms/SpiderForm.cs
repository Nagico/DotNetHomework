namespace SpiderWinForms
{
    public partial class fmSpider : Form
    {
        public string Url { get; set; }
        public int Depth { get; set; }
        public int Count { get; set; }
        private WebSpider.Spider spider;

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
        }

        private async void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                spider = new WebSpider.Spider(Url, Depth, Count);
                bsPages.DataSource = spider.pages;
                await spider.Crawl();
                bsPages.ResetBindings(false);
                MessageBox.Show("Finish");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}