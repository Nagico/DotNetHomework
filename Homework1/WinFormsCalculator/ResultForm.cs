using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class ResultForm : Form
    {
        private string text = "";
        public ResultForm(string text)
        {
            this.text = text;
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            richTextBoxResult.Text= text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
