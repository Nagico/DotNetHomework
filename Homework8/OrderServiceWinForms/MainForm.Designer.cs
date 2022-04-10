namespace OrderServiceWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelQuery = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxQueryKey = new System.Windows.Forms.ComboBox();
            this.textBoxQueryValue = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.flowLayoutPanelTool = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.tableLayoutPanelQueryResult = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelResultCount = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelQuery.SuspendLayout();
            this.flowLayoutPanelTool.SuspendLayout();
            this.tableLayoutPanelQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelQuery, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelTool, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelQueryResult, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelResultCount, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1180, 559);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // flowLayoutPanelQuery
            // 
            this.flowLayoutPanelQuery.Controls.Add(this.comboBoxQueryKey);
            this.flowLayoutPanelQuery.Controls.Add(this.textBoxQueryValue);
            this.flowLayoutPanelQuery.Controls.Add(this.buttonQuery);
            this.flowLayoutPanelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelQuery.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanelQuery.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelQuery.Name = "flowLayoutPanelQuery";
            this.flowLayoutPanelQuery.Size = new System.Drawing.Size(1180, 40);
            this.flowLayoutPanelQuery.TabIndex = 0;
            // 
            // comboBoxQueryKey
            // 
            this.comboBoxQueryKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxQueryKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueryKey.FormattingEnabled = true;
            this.comboBoxQueryKey.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户",
            "总价",
            "创建日期"});
            this.comboBoxQueryKey.Location = new System.Drawing.Point(5, 5);
            this.comboBoxQueryKey.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxQueryKey.Name = "comboBoxQueryKey";
            this.comboBoxQueryKey.Size = new System.Drawing.Size(151, 28);
            this.comboBoxQueryKey.TabIndex = 0;
            this.comboBoxQueryKey.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueryKey_SelectedIndexChanged);
            // 
            // textBoxQueryValue
            // 
            this.textBoxQueryValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxQueryValue.Location = new System.Drawing.Point(166, 6);
            this.textBoxQueryValue.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxQueryValue.Name = "textBoxQueryValue";
            this.textBoxQueryValue.Size = new System.Drawing.Size(231, 27);
            this.textBoxQueryValue.TabIndex = 1;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonQuery.Location = new System.Drawing.Point(407, 5);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(94, 29);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // flowLayoutPanelTool
            // 
            this.flowLayoutPanelTool.Controls.Add(this.buttonAdd);
            this.flowLayoutPanelTool.Controls.Add(this.buttonUpdate);
            this.flowLayoutPanelTool.Controls.Add(this.buttonDelete);
            this.flowLayoutPanelTool.Controls.Add(this.buttonImport);
            this.flowLayoutPanelTool.Controls.Add(this.buttonExport);
            this.flowLayoutPanelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTool.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTool.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTool.Name = "flowLayoutPanelTool";
            this.flowLayoutPanelTool.Size = new System.Drawing.Size(1180, 40);
            this.flowLayoutPanelTool.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "添加订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(103, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 29);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "编辑订单";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(203, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "删除订单";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(303, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(94, 29);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "导入订单";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(403, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(94, 29);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "导出订单";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // tableLayoutPanelQueryResult
            // 
            this.tableLayoutPanelQueryResult.ColumnCount = 2;
            this.tableLayoutPanelQueryResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.71672F));
            this.tableLayoutPanelQueryResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.28328F));
            this.tableLayoutPanelQueryResult.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanelQueryResult.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanelQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQueryResult.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanelQueryResult.Name = "tableLayoutPanelQueryResult";
            this.tableLayoutPanelQueryResult.RowCount = 1;
            this.tableLayoutPanelQueryResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQueryResult.Size = new System.Drawing.Size(1174, 448);
            this.tableLayoutPanelQueryResult.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Customer,
            this.dataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceOrder;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer.Id";
            this.Customer.HeaderText = "客户ID";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer.Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "客户姓名";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时间";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 140;
            // 
            // updateTimeDataGridViewTextBoxColumn
            // 
            this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.HeaderText = "修改时间";
            this.updateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
            this.updateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateTimeDataGridViewTextBoxColumn.Width = 140;
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(OrderSystem.models.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.numberDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.detailsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(657, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(514, 442);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Product.Id";
            this.Column3.HeaderText = "商品ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product.Name";
            this.Column1.HeaderText = "商品名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Product.Price";
            this.Column2.HeaderText = "单价";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 70;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "折扣";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 70;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "价格";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 70;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.bindingSourceOrder;
            // 
            // labelResultCount
            // 
            this.labelResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultCount.AutoSize = true;
            this.labelResultCount.Location = new System.Drawing.Point(3, 534);
            this.labelResultCount.Name = "labelResultCount";
            this.labelResultCount.Size = new System.Drawing.Size(53, 25);
            this.labelResultCount.TabIndex = 3;
            this.labelResultCount.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 559);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.flowLayoutPanelQuery.ResumeLayout(false);
            this.flowLayoutPanelQuery.PerformLayout();
            this.flowLayoutPanelTool.ResumeLayout(false);
            this.tableLayoutPanelQueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private FlowLayoutPanel flowLayoutPanelQuery;
        private ComboBox comboBoxQueryKey;
        private TextBox textBoxQueryValue;
        private Button buttonQuery;
        private FlowLayoutPanel flowLayoutPanelTool;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonImport;
        private Button buttonExport;
        private BindingSource bindingSourceOrder;
        private TableLayoutPanel tableLayoutPanelQueryResult;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource detailsBindingSource;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private Label labelResultCount;
    }
}