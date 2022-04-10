using OrderSystem.models;
using OrderSystem.services;
using OrderSystem.utils;
using System.Reflection;

namespace OrderServiceWinForms
{
    public partial class MainForm : Form
    {
        OrderService orderService = new OrderService();
        public int QueryKey { get; set; }
        public string QueryValue { get; set; }
        public bool QueryTextEnable {
            get
            {
                return QueryKey == 0;
            } 
        }

        public List<Customer> customers = new List<Customer>();
        public List<Product> products = new List<Product>();

        void InitOrderService()
        {
            // 用户
            var alice = new Customer(1, "Alice", "1234");
            var bob = new Customer(2, "Bob", "12345");
            customers.Add(alice);
            customers.Add(bob);

            // 商品
            var apple = new Product(1, "Apple", 2.0);
            var banana = new Product(2, "Banana", 3.5);
            var cheery = new Product(3, "Cherry", 4.25);
            products.Add(apple);
            products.Add(banana);
            products.Add(cheery);

            // 添加订单
            var order_alice = orderService.Create(new Order(1, alice));
            order_alice.AddOrderDetail(new OrderDetail(apple, 2, 1));
            order_alice.AddOrderDetail(new OrderDetail(banana, 7, 0.65));
            order_alice.AddOrderDetail(new OrderDetail(cheery, 3, 0.75));

            var order_bob = orderService.Create(new Order(2, bob));
            order_bob.AddOrderDetail(new OrderDetail(banana, 20, 0.8));
            order_bob.AddOrderDetail(new OrderDetail(cheery, 12, 0.9));

            var order_carol = orderService.Create(new Order(3, alice));
            order_carol.AddOrderDetail(new OrderDetail(cheery, 20, 0.6));
            order_carol.AddOrderDetail(new OrderDetail(apple, 25, 0.85));
        }
        public MainForm()
        {
            InitializeComponent();
            InitOrderService();
            QueryKey = 0;
            QueryValue = "";
            refreshQuery();
        }

        private void refreshQuery()
        {
            try
            {
                switch (QueryKey)
                {
                    case 0:  // 全部订单
                        bindingSourceOrder.DataSource = orderService.QueryAll().ToList();
                        break;
                    case 1:  // ID
                        var queryId = Convert.ToInt32(QueryValue);
                        bindingSourceOrder.DataSource = orderService.QueryAll(x => x.Id == queryId).ToList();
                        break;
                    case 2:  // 客户
                        bindingSourceOrder.DataSource = orderService.QueryAll(x => x.Customer.Name == QueryValue).ToList();
                        break;
                    case 3:  // 总价
                        var queryTotalPrice = Convert.ToDouble(QueryValue);
                        bindingSourceOrder.DataSource = orderService.QueryAll(x => x.TotalPrice == queryTotalPrice).ToList();
                        break;
                    case 4:  // 创建日期
                        var queryDate = Convert.ToDateTime(QueryValue);
                        bindingSourceOrder.DataSource = orderService.QueryAll(
                                x => x.CreateTime.Year == queryDate.Year && x.CreateTime.Month == queryDate.Month && x.CreateTime.Day == queryDate.Day
                            ).ToList();
                        break;
                    default:
                        bindingSourceOrder.DataSource = orderService.QueryAll().ToList();
                        break;
                }
                labelResultCount.Text = $"共 {bindingSourceOrder.Count} 项";
                buttonDelete.Enabled = bindingSourceOrder.Count > 0;
                buttonUpdate.Enabled = bindingSourceOrder.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            refreshQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxQueryKey.DataBindings.Add("SelectedIndex", this, "QueryKey");
            textBoxQueryValue.DataBindings.Add("Text", this, "QueryValue");
            //textBoxQueryValue.DataBindings.Add("Enabled", this, "QueryTextEnable");
        }

        private void comboBoxQueryKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryKey.SelectedIndex == 0) // 全部订单
            {
                textBoxQueryValue.Enabled = false;
            }
            else
            {
                textBoxQueryValue.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUpdateOrder();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var item = bindingSourceOrder.Current as Order ?? throw new Exception("Unkown Order");
            orderService.Delete(item);
            refreshQuery();
            MessageBox.Show("删除成功", "订单");
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridView1.Rows[e.RowIndex].DataBoundItem != null) && (dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    string[] nameAndProp = dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Split(new char[] { '.' });
                    object pObj = dataGridView1.Rows[e.RowIndex].DataBoundItem;
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

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridView2.Rows[e.RowIndex].DataBoundItem != null) && (dataGridView2.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    string[] nameAndProp = dataGridView2.Columns[e.ColumnIndex].DataPropertyName.Split(new char[] { '.' });
                    object pObj = dataGridView2.Rows[e.RowIndex].DataBoundItem;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var item = bindingSourceOrder.Current as Order ?? throw new Exception("Unkown Order");
            AddUpdateOrder(item);

        }

        private void AddUpdateOrder(Order? item = null)
        {
            Order item_copy;
            if (item == null)
            {
                item_copy = new Order();
            }
            else
            {
                item_copy = Util.DeepCopy(item);
            }
            try
            {
                var orderForm = new OrderForm(customers, products, item_copy, item == null ? 0 : 1);
                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    if (item_copy.Customer == null)
                        throw new Exception("未选择用户");
                    if ((item == null || item != null && item.Id != item_copy.Id) && orderService.QueryAll(x => x.Equals(item_copy)).Count() != 0)
                        throw new Exception("ID重复");

                    orderService.CreateOrUpdate(item_copy);
                    refreshQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "订单");
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML|*.xml;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                if (file == null)
                    throw new Exception("未知文件");

                (var cnt, var suc) = orderService.Import(file);
                refreshQuery();
                MessageBox.Show($"文件共{cnt}项\n成功导入{suc}项", "导入");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML|*.xml";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "order";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                orderService.Export(saveFileDialog.FileName);
                MessageBox.Show($"成功导出{orderService.QueryAll().Count()}项", "导出");
            }
        }
    }
}