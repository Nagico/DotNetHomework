namespace WinFormsCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void groupBoxOps_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private (decimal, decimal, string) Parse()
        {
            try
            {
                var number1 = decimal.Parse(textBox1.Text);
                var number2 = decimal.Parse(textBox2.Text);
                var operation = "";
                foreach (Control ctr in groupBoxOps.Controls)
                {
                    if(ctr is RadioButton && (ctr as RadioButton).Checked)
                    {
                        operation = ctr.Text;
                        
                        if (operation == "×")
                            operation = "*";
                        else if (operation == "÷")
                            operation = "/";
                        
                        break;
                    }
                }

                return (number1, number2, operation);
            }
            catch (FormatException)
            {
                throw new Exception("Invalid input");
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var (number1, number2, op) = Parse();
                var result = ConsoleCalculator.Util.Calculate(number1, number2, op);
                var resultForm = new ResultForm(result.ToString());
                resultForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            foreach (Control ctr in groupBoxOps.Controls)
            {
                if (ctr is RadioButton)
                {
                    (ctr as RadioButton).Checked = (ctr as RadioButton).Text == "+";
                }
            }
            textBox1.Focus();
        }
    }
}