using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem.models;
using OrderSystem.utils;

namespace OrderServiceWinForms
{
    public partial class OrderForm : Form
    {
        public Order Order { get; set; }
        private List<Product> products;

        public OrderForm(List<Customer> customers, List<Product> products, Order order, int mode)
        {
            InitializeComponent();
            bindingSourceCustomer.DataSource = customers;
            this.products = products;
            Order = order;
            bindingSourceOrder.DataSource = Order;
            if (mode == 1)  // update
            {
                textBoxOrderID.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            if (bindingSourceOrder.DataSource == null)
            {
                bindingSourceOrder.DataSource = new Order();
            }
            textBoxOrderID.DataBindings.Add("Text", Order, "Id");
            comboBoxOrderCustomer.DataBindings.Add("SelectedItem", Order, "Customer");
            if (Order.Customer == null)
            {
                comboBoxOrderCustomer.SelectedIndex = -1;
            }
            refresh();
        }

        private object GetObject(object pObj, string nameAndProp)
        {
            if (pObj == null)
            {
                return null;
            }
            PropertyInfo objProp = pObj.GetType().GetProperty(nameAndProp);
            return objProp.GetValue(pObj, null);
        }

        private void dataGridViewOrderDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewOrderDetail.Rows[e.RowIndex].DataBoundItem != null) && (dataGridViewOrderDetail.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    string[] nameAndProp = dataGridViewOrderDetail.Columns[e.ColumnIndex].DataPropertyName.Split(new char[] { '.' });
                    object pObj = dataGridViewOrderDetail.Rows[e.RowIndex].DataBoundItem;
                    for (int i = 0; i < nameAndProp.Length - 1; i++)
                    {
                        pObj = GetObject(pObj, nameAndProp[i]);
                        if (pObj == null)
                        {
                            e.Value = string.Empty;
                            break;
                        }
                        if (i == nameAndProp.Length - 2)
                        {
                            PropertyInfo objectProperty = pObj.GetType().GetProperty(nameAndProp[i + 1]);
                            e.Value = objectProperty.GetValue(pObj, null).ToString();
                        }
                    }
                }
            }
            catch { }
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            var item = detailsBindingSource.Current as OrderDetail ?? throw new Exception("Unkown OrderDetail");
            Order.Details.Remove(item);
            refresh();
        }

        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            var item = detailsBindingSource.Current as OrderDetail ?? throw new Exception("Unkown OrderDetail");
            AddUpdateProduct(item);
        }

        private void refresh()
        {
            labelResultCount.Text = $"共 {detailsBindingSource.Count} 项";
            buttonProductDelete.Enabled = detailsBindingSource.Count > 0;
            buttonProductUpdate.Enabled = detailsBindingSource.Count > 0;
        }

        private void AddUpdateProduct(OrderDetail? item = null)
        {
            try
            {
                OrderDetail item_copy;
                if (item == null)
                {
                    item_copy = new OrderDetail();
                }
                else
                {
                    item_copy = Util.DeepCopy(item);
                }

                var form = new ProductForm(products, item_copy);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (item_copy.Product == null || item_copy.Number == 0 || item_copy.Discount > 1 || item_copy.Discount < 0)
                        throw new Exception("非法输入");
                    if ((item == null || item != null && !item.Product.Equals(item_copy.Product)) && Order.Details.Where(x => x.Product.Equals(item_copy.Product)).Count() != 0)
                        throw new Exception("商品重复");

                    if (item == null)  // add
                    {
                        Order.Details.Add(item_copy);
                    }
                    else  // update
                    {
                        Order.Details[Order.Details.IndexOf(item)] = item_copy;
                    }
                }
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "订单详情");
            }
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            AddUpdateProduct();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
