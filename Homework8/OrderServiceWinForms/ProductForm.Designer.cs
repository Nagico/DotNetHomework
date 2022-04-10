namespace OrderServiceWinForms
{
    partial class ProductForm
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
            this.tableLayoutPanelProductMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelProductDetail = new System.Windows.Forms.TableLayoutPanel();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.bindingSourceProduct = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProductCancel = new System.Windows.Forms.Button();
            this.buttonProductConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanelProductMain.SuspendLayout();
            this.tableLayoutPanelProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelProductMain
            // 
            this.tableLayoutPanelProductMain.ColumnCount = 1;
            this.tableLayoutPanelProductMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProductMain.Controls.Add(this.tableLayoutPanelProductDetail, 0, 0);
            this.tableLayoutPanelProductMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelProductMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProductMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProductMain.Name = "tableLayoutPanelProductMain";
            this.tableLayoutPanelProductMain.RowCount = 2;
            this.tableLayoutPanelProductMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProductMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelProductMain.Size = new System.Drawing.Size(247, 163);
            this.tableLayoutPanelProductMain.TabIndex = 0;
            // 
            // tableLayoutPanelProductDetail
            // 
            this.tableLayoutPanelProductDetail.ColumnCount = 2;
            this.tableLayoutPanelProductDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelProductDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProductDetail.Controls.Add(this.labelDiscount, 0, 2);
            this.tableLayoutPanelProductDetail.Controls.Add(this.labelNumber, 0, 1);
            this.tableLayoutPanelProductDetail.Controls.Add(this.labelProduct, 0, 0);
            this.tableLayoutPanelProductDetail.Controls.Add(this.comboBoxProduct, 1, 0);
            this.tableLayoutPanelProductDetail.Controls.Add(this.textBoxNumber, 1, 1);
            this.tableLayoutPanelProductDetail.Controls.Add(this.textBoxDiscount, 1, 2);
            this.tableLayoutPanelProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProductDetail.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelProductDetail.Name = "tableLayoutPanelProductDetail";
            this.tableLayoutPanelProductDetail.RowCount = 3;
            this.tableLayoutPanelProductDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProductDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProductDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProductDetail.Size = new System.Drawing.Size(241, 117);
            this.tableLayoutPanelProductDetail.TabIndex = 0;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscount.Location = new System.Drawing.Point(3, 78);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(39, 39);
            this.labelDiscount.TabIndex = 3;
            this.labelDiscount.Text = "折扣";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumber.Location = new System.Drawing.Point(3, 39);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(39, 39);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "数量";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProduct.Location = new System.Drawing.Point(3, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(39, 39);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "商品";
            this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DataSource = this.bindingSourceProduct;
            this.comboBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(48, 3);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(190, 28);
            this.comboBoxProduct.TabIndex = 5;
            // 
            // bindingSourceProduct
            // 
            this.bindingSourceProduct.DataSource = typeof(OrderSystem.models.Product);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumber.Location = new System.Drawing.Point(48, 42);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(190, 27);
            this.textBoxNumber.TabIndex = 7;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscount.Location = new System.Drawing.Point(48, 81);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(190, 27);
            this.textBoxDiscount.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonProductCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonProductConfirm, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 126);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonProductCancel
            // 
            this.buttonProductCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonProductCancel.Location = new System.Drawing.Point(13, 3);
            this.buttonProductCancel.Name = "buttonProductCancel";
            this.buttonProductCancel.Size = new System.Drawing.Size(94, 28);
            this.buttonProductCancel.TabIndex = 1;
            this.buttonProductCancel.Text = "取消";
            this.buttonProductCancel.UseVisualStyleBackColor = true;
            this.buttonProductCancel.Click += new System.EventHandler(this.buttonProductCancel_Click);
            // 
            // buttonProductConfirm
            // 
            this.buttonProductConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonProductConfirm.Location = new System.Drawing.Point(133, 3);
            this.buttonProductConfirm.Name = "buttonProductConfirm";
            this.buttonProductConfirm.Size = new System.Drawing.Size(94, 28);
            this.buttonProductConfirm.TabIndex = 0;
            this.buttonProductConfirm.Text = "确认";
            this.buttonProductConfirm.UseVisualStyleBackColor = true;
            this.buttonProductConfirm.Click += new System.EventHandler(this.buttonProductConfirm_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 163);
            this.Controls.Add(this.tableLayoutPanelProductMain);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.tableLayoutPanelProductMain.ResumeLayout(false);
            this.tableLayoutPanelProductDetail.ResumeLayout(false);
            this.tableLayoutPanelProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelProductMain;
        private TableLayoutPanel tableLayoutPanelProductDetail;
        private Label labelDiscount;
        private Label labelNumber;
        private Label labelProduct;
        private ComboBox comboBoxProduct;
        private TextBox textBoxNumber;
        private TextBox textBoxDiscount;
        private BindingSource bindingSourceProduct;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonProductCancel;
        private Button buttonProductConfirm;
    }
}