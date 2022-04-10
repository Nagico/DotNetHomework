namespace OrderServiceWinForms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelOrderMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelItem = new System.Windows.Forms.TableLayoutPanel();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.labelOrderCustomer = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.comboBoxOrderCustomer = new System.Windows.Forms.ComboBox();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.buttonProductUpdate = new System.Windows.Forms.Button();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.dataGridViewOrderDetail = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelTool = new System.Windows.Forms.TableLayoutPanel();
            this.labelResultCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelOrderMain.SuspendLayout();
            this.tableLayoutPanelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.flowLayoutPanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.tableLayoutPanelTool.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOrderMain
            // 
            this.tableLayoutPanelOrderMain.ColumnCount = 1;
            this.tableLayoutPanelOrderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOrderMain.Controls.Add(this.tableLayoutPanelItem, 0, 0);
            this.tableLayoutPanelOrderMain.Controls.Add(this.dataGridViewOrderDetail, 0, 1);
            this.tableLayoutPanelOrderMain.Controls.Add(this.tableLayoutPanelTool, 0, 2);
            this.tableLayoutPanelOrderMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrderMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOrderMain.Name = "tableLayoutPanelOrderMain";
            this.tableLayoutPanelOrderMain.RowCount = 3;
            this.tableLayoutPanelOrderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanelOrderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOrderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelOrderMain.Size = new System.Drawing.Size(966, 510);
            this.tableLayoutPanelOrderMain.TabIndex = 0;
            // 
            // tableLayoutPanelItem
            // 
            this.tableLayoutPanelItem.ColumnCount = 3;
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 583F));
            this.tableLayoutPanelItem.Controls.Add(this.labelOrderID, 0, 0);
            this.tableLayoutPanelItem.Controls.Add(this.labelOrderCustomer, 0, 1);
            this.tableLayoutPanelItem.Controls.Add(this.textBoxOrderID, 1, 0);
            this.tableLayoutPanelItem.Controls.Add(this.comboBoxOrderCustomer, 1, 1);
            this.tableLayoutPanelItem.Controls.Add(this.flowLayoutPanelProduct, 2, 1);
            this.tableLayoutPanelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelItem.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelItem.Name = "tableLayoutPanelItem";
            this.tableLayoutPanelItem.RowCount = 2;
            this.tableLayoutPanelItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelItem.Size = new System.Drawing.Size(960, 66);
            this.tableLayoutPanelItem.TabIndex = 0;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelOrderID.Location = new System.Drawing.Point(53, 0);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(24, 33);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "ID";
            this.labelOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrderCustomer
            // 
            this.labelOrderCustomer.AutoSize = true;
            this.labelOrderCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelOrderCustomer.Location = new System.Drawing.Point(38, 33);
            this.labelOrderCustomer.Name = "labelOrderCustomer";
            this.labelOrderCustomer.Size = new System.Drawing.Size(39, 33);
            this.labelOrderCustomer.TabIndex = 1;
            this.labelOrderCustomer.Text = "客户";
            this.labelOrderCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(83, 3);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(249, 27);
            this.textBoxOrderID.TabIndex = 2;
            // 
            // comboBoxOrderCustomer
            // 
            this.comboBoxOrderCustomer.DataSource = this.bindingSourceCustomer;
            this.comboBoxOrderCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderCustomer.FormattingEnabled = true;
            this.comboBoxOrderCustomer.Location = new System.Drawing.Point(83, 36);
            this.comboBoxOrderCustomer.Name = "comboBoxOrderCustomer";
            this.comboBoxOrderCustomer.Size = new System.Drawing.Size(249, 28);
            this.comboBoxOrderCustomer.TabIndex = 3;
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(OrderSystem.models.Customer);
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.Controls.Add(this.buttonProductDelete);
            this.flowLayoutPanelProduct.Controls.Add(this.buttonProductUpdate);
            this.flowLayoutPanelProduct.Controls.Add(this.buttonProductAdd);
            this.flowLayoutPanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProduct.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(380, 33);
            this.flowLayoutPanelProduct.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(583, 33);
            this.flowLayoutPanelProduct.TabIndex = 4;
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.Location = new System.Drawing.Point(479, 3);
            this.buttonProductDelete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonProductDelete.TabIndex = 1;
            this.buttonProductDelete.Text = "删除商品";
            this.buttonProductDelete.UseVisualStyleBackColor = true;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // buttonProductUpdate
            // 
            this.buttonProductUpdate.Location = new System.Drawing.Point(365, 3);
            this.buttonProductUpdate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonProductUpdate.Name = "buttonProductUpdate";
            this.buttonProductUpdate.Size = new System.Drawing.Size(94, 29);
            this.buttonProductUpdate.TabIndex = 2;
            this.buttonProductUpdate.Text = "编辑商品";
            this.buttonProductUpdate.UseVisualStyleBackColor = true;
            this.buttonProductUpdate.Click += new System.EventHandler(this.buttonProductUpdate_Click);
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.Location = new System.Drawing.Point(251, 3);
            this.buttonProductAdd.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonProductAdd.TabIndex = 0;
            this.buttonProductAdd.Text = "添加商品";
            this.buttonProductAdd.UseVisualStyleBackColor = true;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
            // 
            // dataGridViewOrderDetail
            // 
            this.dataGridViewOrderDetail.AllowUserToAddRows = false;
            this.dataGridViewOrderDetail.AllowUserToDeleteRows = false;
            this.dataGridViewOrderDetail.AllowUserToOrderColumns = true;
            this.dataGridViewOrderDetail.AutoGenerateColumns = false;
            this.dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridViewOrderDetail.DataSource = this.detailsBindingSource;
            this.dataGridViewOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderDetail.Location = new System.Drawing.Point(3, 75);
            this.dataGridViewOrderDetail.MultiSelect = false;
            this.dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            this.dataGridViewOrderDetail.ReadOnly = true;
            this.dataGridViewOrderDetail.RowHeadersVisible = false;
            this.dataGridViewOrderDetail.RowHeadersWidth = 51;
            this.dataGridViewOrderDetail.RowTemplate.Height = 29;
            this.dataGridViewOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetail.Size = new System.Drawing.Size(960, 397);
            this.dataGridViewOrderDetail.TabIndex = 2;
            this.dataGridViewOrderDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrderDetail_CellFormatting);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product.Id";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product.Price";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "商品单价";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "折扣";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.bindingSourceOrder;
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(OrderSystem.models.Order);
            // 
            // tableLayoutPanelTool
            // 
            this.tableLayoutPanelTool.ColumnCount = 2;
            this.tableLayoutPanelTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTool.Controls.Add(this.labelResultCount, 0, 0);
            this.tableLayoutPanelTool.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTool.Location = new System.Drawing.Point(0, 475);
            this.tableLayoutPanelTool.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTool.Name = "tableLayoutPanelTool";
            this.tableLayoutPanelTool.RowCount = 1;
            this.tableLayoutPanelTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTool.Size = new System.Drawing.Size(966, 35);
            this.tableLayoutPanelTool.TabIndex = 3;
            // 
            // labelResultCount
            // 
            this.labelResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultCount.AutoSize = true;
            this.labelResultCount.Location = new System.Drawing.Point(3, 0);
            this.labelResultCount.Name = "labelResultCount";
            this.labelResultCount.Size = new System.Drawing.Size(53, 35);
            this.labelResultCount.TabIndex = 2;
            this.labelResultCount.Text = "label1";
            this.labelResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(866, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(762, 3);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(648, 3);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 510);
            this.Controls.Add(this.tableLayoutPanelOrderMain);
            this.Name = "OrderForm";
            this.Text = "AddUpdateOrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tableLayoutPanelOrderMain.ResumeLayout(false);
            this.tableLayoutPanelItem.ResumeLayout(false);
            this.tableLayoutPanelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.flowLayoutPanelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.tableLayoutPanelTool.ResumeLayout(false);
            this.tableLayoutPanelTool.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelOrderMain;
        private TableLayoutPanel tableLayoutPanelItem;
        private Label labelOrderID;
        private Label labelOrderCustomer;
        private TextBox textBoxOrderID;
        private ComboBox comboBoxOrderCustomer;
        private BindingSource bindingSourceOrder;
        private DataGridView dataGridViewOrderDetail;
        private DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tabIndexDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn tabStopDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private BindingSource detailsBindingSource;
        private BindingSource bindingSourceCustomer;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private FlowLayoutPanel flowLayoutPanelProduct;
        private Button buttonProductDelete;
        private Button buttonProductAdd;
        private Button buttonProductUpdate;
        private TableLayoutPanel tableLayoutPanelTool;
        private Label labelResultCount;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCancel;
        private Button buttonSave;
    }
}