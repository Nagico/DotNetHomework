namespace SpiderWinForms
{
    partial class fmSpider
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
            this.tbMain = new System.Windows.Forms.TableLayoutPanel();
            this.gpResult = new System.Windows.Forms.GroupBox();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.uriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPages = new System.Windows.Forms.BindingSource(this.components);
            this.tbUrl = new System.Windows.Forms.TableLayoutPanel();
            this.lUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tbConfig = new System.Windows.Forms.TableLayoutPanel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lCount = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.lDepth = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.tbMain.SuspendLayout();
            this.gpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPages)).BeginInit();
            this.tbUrl.SuspendLayout();
            this.tbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.ColumnCount = 1;
            this.tbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbMain.Controls.Add(this.gpResult, 0, 2);
            this.tbMain.Controls.Add(this.tbUrl, 0, 0);
            this.tbMain.Controls.Add(this.tbConfig, 0, 1);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.RowCount = 3;
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbMain.Size = new System.Drawing.Size(627, 450);
            this.tbMain.TabIndex = 0;
            // 
            // gpResult
            // 
            this.gpResult.Controls.Add(this.dgResult);
            this.gpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpResult.Location = new System.Drawing.Point(3, 83);
            this.gpResult.Name = "gpResult";
            this.gpResult.Size = new System.Drawing.Size(621, 364);
            this.gpResult.TabIndex = 0;
            this.gpResult.TabStop = false;
            this.gpResult.Text = "Result";
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AutoGenerateColumns = false;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uriDataGridViewTextBoxColumn,
            this.msgDataGridViewTextBoxColumn});
            this.dgResult.DataSource = this.bsPages;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(3, 23);
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            this.dgResult.RowHeadersWidth = 51;
            this.dgResult.RowTemplate.Height = 29;
            this.dgResult.Size = new System.Drawing.Size(615, 338);
            this.dgResult.TabIndex = 0;
            // 
            // uriDataGridViewTextBoxColumn
            // 
            this.uriDataGridViewTextBoxColumn.DataPropertyName = "Uri";
            this.uriDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uriDataGridViewTextBoxColumn.Name = "uriDataGridViewTextBoxColumn";
            this.uriDataGridViewTextBoxColumn.ReadOnly = true;
            this.uriDataGridViewTextBoxColumn.Width = 360;
            // 
            // msgDataGridViewTextBoxColumn
            // 
            this.msgDataGridViewTextBoxColumn.DataPropertyName = "Msg";
            this.msgDataGridViewTextBoxColumn.HeaderText = "备注";
            this.msgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.msgDataGridViewTextBoxColumn.Name = "msgDataGridViewTextBoxColumn";
            this.msgDataGridViewTextBoxColumn.ReadOnly = true;
            this.msgDataGridViewTextBoxColumn.Width = 180;
            // 
            // bsPages
            // 
            this.bsPages.DataSource = typeof(WebSpider.WebPage);
            // 
            // tbUrl
            // 
            this.tbUrl.ColumnCount = 2;
            this.tbUrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tbUrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbUrl.Controls.Add(this.lUrl, 0, 0);
            this.tbUrl.Controls.Add(this.txtUrl, 1, 0);
            this.tbUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUrl.Location = new System.Drawing.Point(0, 0);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(0);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.RowCount = 1;
            this.tbUrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbUrl.Size = new System.Drawing.Size(627, 40);
            this.tbUrl.TabIndex = 1;
            // 
            // lUrl
            // 
            this.lUrl.AutoSize = true;
            this.lUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUrl.Location = new System.Drawing.Point(3, 0);
            this.lUrl.Name = "lUrl";
            this.lUrl.Size = new System.Drawing.Size(74, 40);
            this.lUrl.TabIndex = 0;
            this.lUrl.Text = "URL";
            this.lUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(86, 6);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(535, 27);
            this.txtUrl.TabIndex = 1;
            // 
            // tbConfig
            // 
            this.tbConfig.ColumnCount = 5;
            this.tbConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tbConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tbConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbConfig.Controls.Add(this.txtCount, 3, 0);
            this.tbConfig.Controls.Add(this.lCount, 2, 0);
            this.tbConfig.Controls.Add(this.txtDepth, 1, 0);
            this.tbConfig.Controls.Add(this.lDepth, 0, 0);
            this.tbConfig.Controls.Add(this.btStart, 4, 0);
            this.tbConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConfig.Location = new System.Drawing.Point(0, 40);
            this.tbConfig.Margin = new System.Windows.Forms.Padding(0);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.RowCount = 1;
            this.tbConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbConfig.Size = new System.Drawing.Size(627, 40);
            this.tbConfig.TabIndex = 2;
            // 
            // txtCount
            // 
            this.txtCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCount.Location = new System.Drawing.Point(349, 6);
            this.txtCount.Margin = new System.Windows.Forms.Padding(6);
            this.txtCount.MaximumSize = new System.Drawing.Size(80, 0);
            this.txtCount.MinimumSize = new System.Drawing.Size(40, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(80, 27);
            this.txtCount.TabIndex = 4;
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCount.Location = new System.Drawing.Point(266, 0);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(74, 40);
            this.lCount.TabIndex = 3;
            this.lCount.Text = "Count";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDepth
            // 
            this.txtDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDepth.Location = new System.Drawing.Point(86, 6);
            this.txtDepth.Margin = new System.Windows.Forms.Padding(6);
            this.txtDepth.MaximumSize = new System.Drawing.Size(80, 0);
            this.txtDepth.MinimumSize = new System.Drawing.Size(40, 0);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(80, 27);
            this.txtDepth.TabIndex = 2;
            // 
            // lDepth
            // 
            this.lDepth.AutoSize = true;
            this.lDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDepth.Location = new System.Drawing.Point(3, 0);
            this.lDepth.Name = "lDepth";
            this.lDepth.Size = new System.Drawing.Size(74, 40);
            this.lDepth.TabIndex = 0;
            this.lDepth.Text = "Depth";
            this.lDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(532, 6);
            this.btStart.Margin = new System.Windows.Forms.Padding(6);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(89, 28);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // fmSpider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.tbMain);
            this.Name = "fmSpider";
            this.Text = "WebSpider";
            this.Load += new System.EventHandler(this.fmSpider_Load);
            this.tbMain.ResumeLayout(false);
            this.gpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPages)).EndInit();
            this.tbUrl.ResumeLayout(false);
            this.tbUrl.PerformLayout();
            this.tbConfig.ResumeLayout(false);
            this.tbConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tbMain;
        private GroupBox gpResult;
        private TableLayoutPanel tbUrl;
        private Label lUrl;
        private TextBox txtUrl;
        private TableLayoutPanel tbConfig;
        private TextBox txtCount;
        private Label lCount;
        private TextBox txtDepth;
        private Label lDepth;
        private Button btStart;
        private BindingSource bsPages;
        private DataGridView dgResult;
        private DataGridViewTextBoxColumn uriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn msgDataGridViewTextBoxColumn;
    }
}