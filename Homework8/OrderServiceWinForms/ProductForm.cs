using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem.models;

namespace OrderServiceWinForms
{
    public partial class ProductForm : Form
    {
        public OrderDetail OrderDetail { get; set; }

        public ProductForm(List<Product> products, OrderDetail orderDetail)
        {
            InitializeComponent();
            bindingSourceProduct.DataSource = products;
            if (orderDetail == null)
            {
                orderDetail = new OrderDetail();
            }
            OrderDetail = orderDetail;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            comboBoxProduct.DataBindings.Add("SelectedItem", OrderDetail, "Product");
            textBoxNumber.DataBindings.Add("Text", OrderDetail, "Number");
            textBoxDiscount.DataBindings.Add("Text", OrderDetail, "Discount");
        }

        private void buttonProductConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonProductCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
