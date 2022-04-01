using System.Data;

namespace CayleyTree
{
    public partial class FormCayleyTree : Form
    {
        private Graphics graphics;
        private double leftAngle = 3 * 15 * Math.PI / 180;
        private double rightAngle = 4 * 15 * Math.PI / 180;
        private double leftLength = 8 * 0.05;
        private double rightLength = 5 * 0.05;
        private int depth = 5;
        private int length = 10 * 10;
        private Pen color = Pens.Red;

        public FormCayleyTree()
        {
            InitializeComponent();
            dt.Columns.Add("key", typeof(Pen));
            dt.Columns.Add("value", typeof(string));
            var dict = new Dictionary<string, Pen>() { 
                { "红色", Pens.Red },
                { "绿色", Pens.Green },
                { "蓝色", Pens.Blue },
                { "黄色", Pens.Yellow },
                { "粉色", Pens.Pink },
                { "紫色", Pens.Purple },
                { "灰色", Pens.Gray },
                { "黑色", Pens.Black },
            };

            foreach (var (key, value) in dict)
            {
                DataRow dr = dt.NewRow();
                dr[1] = key;
                dr[0] = value;
                dt.Rows.Add(dr);
            }
        }

        void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, leftLength * leng, th + leftAngle);
            drawCayleyTree(n - 1, x1, y1, rightLength * leng, th - rightAngle);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                color,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        void draw()
        {
            graphics = panelGraph.CreateGraphics();
            graphics.Clear(Color.White);

            drawCayleyTree(depth, panelGraph.Right / 2, panelGraph.Bottom - 100, length, -Math.PI / 2);
        }

        private void trackBarLeftLength_ValueChanged(object sender, EventArgs e)
        {
            double value = trackBarLeftLength.Value * 0.05;
            labelLeftLengthResult.Text = value.ToString("0.00");
            leftLength = value;
        }

        private void trackBarRightLength_ValueChanged(object sender, EventArgs e)
        {
            double value = trackBarRightLength.Value * 0.05;
            labelRightLengthResult.Text = value.ToString("0.00");
            rightLength = value;
        }

        private void trackBarDepth_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBarDepth.Value;
            labelDepthResult.Text = value.ToString();
            depth = value;
        }

        private void trackBarLength_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBarLength.Value * 10;
            labelLengthResult.Text = value.ToString();
            length = value;
        }

        private void trackBarLeftAngle_ValueChanged(object sender, EventArgs e)
        {
            double value = trackBarLeftAngle.Value * 15;
            labelLeftAngleResult.Text = value.ToString();
            leftAngle = value * Math.PI / 180;
        }

        private void trackBarRightAngle_ValueChanged(object sender, EventArgs e)
        {
            double value = trackBarRightAngle.Value * 15;
            labelRightAngleResult.Text = value.ToString();
            rightAngle = value * Math.PI / 180;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void comboBoxColor_SelectedValueChanged(object sender, EventArgs e)
        {
            color = (Pen)comboBoxColor.SelectedValue;
        }
    }
}