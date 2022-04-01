using System.Data;

namespace CayleyTree
{
    partial class FormCayleyTree
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
            this.tableLayoutForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutParams = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutLength = new System.Windows.Forms.TableLayoutPanel();
            this.labelLength = new System.Windows.Forms.Label();
            this.trackBarLength = new System.Windows.Forms.TrackBar();
            this.labelLengthResult = new System.Windows.Forms.Label();
            this.tableLayoutColor = new System.Windows.Forms.TableLayoutPanel();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.dt = new System.Data.DataTable();
            this.tableLayoutDepth = new System.Windows.Forms.TableLayoutPanel();
            this.labelDepth = new System.Windows.Forms.Label();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.labelDepthResult = new System.Windows.Forms.Label();
            this.tableLayoutRightAngle = new System.Windows.Forms.TableLayoutPanel();
            this.labelRightAngle = new System.Windows.Forms.Label();
            this.trackBarRightAngle = new System.Windows.Forms.TrackBar();
            this.labelRightAngleResult = new System.Windows.Forms.Label();
            this.tableLayoutRightLength = new System.Windows.Forms.TableLayoutPanel();
            this.labelRightLenght = new System.Windows.Forms.Label();
            this.trackBarRightLength = new System.Windows.Forms.TrackBar();
            this.labelRightLengthResult = new System.Windows.Forms.Label();
            this.tableLayoutLeftAngle = new System.Windows.Forms.TableLayoutPanel();
            this.labelLeftAngle = new System.Windows.Forms.Label();
            this.trackBarLeftAngle = new System.Windows.Forms.TrackBar();
            this.labelLeftAngleResult = new System.Windows.Forms.Label();
            this.tableLayoutLeftLength = new System.Windows.Forms.TableLayoutPanel();
            this.labelLeftLength = new System.Windows.Forms.Label();
            this.trackBarLeftLength = new System.Windows.Forms.TrackBar();
            this.labelLeftLengthResult = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.tableLayoutForm.SuspendLayout();
            this.tableLayoutParams.SuspendLayout();
            this.tableLayoutLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).BeginInit();
            this.tableLayoutColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.tableLayoutDepth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            this.tableLayoutRightAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightAngle)).BeginInit();
            this.tableLayoutRightLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightLength)).BeginInit();
            this.tableLayoutLeftAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftAngle)).BeginInit();
            this.tableLayoutLeftLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutForm
            // 
            this.tableLayoutForm.ColumnCount = 1;
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutForm.Controls.Add(this.tableLayoutParams, 0, 1);
            this.tableLayoutForm.Controls.Add(this.panelGraph, 0, 0);
            this.tableLayoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutForm.Name = "tableLayoutForm";
            this.tableLayoutForm.RowCount = 2;
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutForm.Size = new System.Drawing.Size(982, 753);
            this.tableLayoutForm.TabIndex = 0;
            // 
            // tableLayoutParams
            // 
            this.tableLayoutParams.ColumnCount = 2;
            this.tableLayoutParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutParams.Controls.Add(this.tableLayoutLength, 0, 3);
            this.tableLayoutParams.Controls.Add(this.tableLayoutColor, 1, 2);
            this.tableLayoutParams.Controls.Add(this.tableLayoutDepth, 0, 2);
            this.tableLayoutParams.Controls.Add(this.tableLayoutRightAngle, 1, 1);
            this.tableLayoutParams.Controls.Add(this.tableLayoutRightLength, 0, 1);
            this.tableLayoutParams.Controls.Add(this.tableLayoutLeftAngle, 1, 0);
            this.tableLayoutParams.Controls.Add(this.tableLayoutLeftLength, 0, 0);
            this.tableLayoutParams.Controls.Add(this.buttonDraw, 1, 3);
            this.tableLayoutParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutParams.Location = new System.Drawing.Point(3, 556);
            this.tableLayoutParams.Name = "tableLayoutParams";
            this.tableLayoutParams.RowCount = 4;
            this.tableLayoutParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutParams.Size = new System.Drawing.Size(976, 194);
            this.tableLayoutParams.TabIndex = 0;
            // 
            // tableLayoutLength
            // 
            this.tableLayoutLength.ColumnCount = 3;
            this.tableLayoutLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutLength.Controls.Add(this.labelLength, 0, 0);
            this.tableLayoutLength.Controls.Add(this.trackBarLength, 1, 0);
            this.tableLayoutLength.Controls.Add(this.labelLengthResult, 2, 0);
            this.tableLayoutLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLength.Location = new System.Drawing.Point(3, 147);
            this.tableLayoutLength.Name = "tableLayoutLength";
            this.tableLayoutLength.RowCount = 1;
            this.tableLayoutLength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLength.Size = new System.Drawing.Size(482, 44);
            this.tableLayoutLength.TabIndex = 6;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLength.Location = new System.Drawing.Point(3, 0);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(114, 44);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "主干长度";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarLength
            // 
            this.trackBarLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarLength.LargeChange = 2;
            this.trackBarLength.Location = new System.Drawing.Point(123, 3);
            this.trackBarLength.Maximum = 40;
            this.trackBarLength.Minimum = 10;
            this.trackBarLength.Name = "trackBarLength";
            this.trackBarLength.Size = new System.Drawing.Size(306, 38);
            this.trackBarLength.TabIndex = 1;
            this.trackBarLength.Value = 10;
            this.trackBarLength.ValueChanged += new System.EventHandler(this.trackBarLength_ValueChanged);
            // 
            // labelLengthResult
            // 
            this.labelLengthResult.AutoSize = true;
            this.labelLengthResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLengthResult.Location = new System.Drawing.Point(435, 0);
            this.labelLengthResult.Name = "labelLengthResult";
            this.labelLengthResult.Size = new System.Drawing.Size(44, 44);
            this.labelLengthResult.TabIndex = 2;
            this.labelLengthResult.Text = "100";
            this.labelLengthResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutColor
            // 
            this.tableLayoutColor.ColumnCount = 2;
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutColor.Controls.Add(this.labelColor, 0, 0);
            this.tableLayoutColor.Controls.Add(this.comboBoxColor, 1, 0);
            this.tableLayoutColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutColor.Location = new System.Drawing.Point(491, 99);
            this.tableLayoutColor.Name = "tableLayoutColor";
            this.tableLayoutColor.RowCount = 1;
            this.tableLayoutColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutColor.Size = new System.Drawing.Size(482, 42);
            this.tableLayoutColor.TabIndex = 5;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelColor.Location = new System.Drawing.Point(3, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(114, 42);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "画笔颜色";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DataSource = this.dt;
            this.comboBoxColor.DisplayMember = "value";
            this.comboBoxColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.ItemHeight = 20;
            this.comboBoxColor.Location = new System.Drawing.Point(123, 3);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(356, 28);
            this.comboBoxColor.TabIndex = 1;
            this.comboBoxColor.UseWaitCursor = true;
            this.comboBoxColor.ValueMember = "key";
            this.comboBoxColor.SelectedValueChanged += new System.EventHandler(this.comboBoxColor_SelectedValueChanged);
            // 
            // dt
            // 
            this.dt.Namespace = "";
            this.dt.PrimaryKey = new System.Data.DataColumn[0];
            // 
            // tableLayoutDepth
            // 
            this.tableLayoutDepth.ColumnCount = 3;
            this.tableLayoutDepth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutDepth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDepth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutDepth.Controls.Add(this.labelDepth, 0, 0);
            this.tableLayoutDepth.Controls.Add(this.trackBarDepth, 1, 0);
            this.tableLayoutDepth.Controls.Add(this.labelDepthResult, 2, 0);
            this.tableLayoutDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutDepth.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutDepth.Name = "tableLayoutDepth";
            this.tableLayoutDepth.RowCount = 1;
            this.tableLayoutDepth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDepth.Size = new System.Drawing.Size(482, 42);
            this.tableLayoutDepth.TabIndex = 4;
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDepth.Location = new System.Drawing.Point(3, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(114, 42);
            this.labelDepth.TabIndex = 0;
            this.labelDepth.Text = "递归深度";
            this.labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarDepth.LargeChange = 2;
            this.trackBarDepth.Location = new System.Drawing.Point(123, 3);
            this.trackBarDepth.Maximum = 20;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Size = new System.Drawing.Size(306, 36);
            this.trackBarDepth.TabIndex = 1;
            this.trackBarDepth.Value = 5;
            this.trackBarDepth.ValueChanged += new System.EventHandler(this.trackBarDepth_ValueChanged);
            // 
            // labelDepthResult
            // 
            this.labelDepthResult.AutoSize = true;
            this.labelDepthResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDepthResult.Location = new System.Drawing.Point(435, 0);
            this.labelDepthResult.Name = "labelDepthResult";
            this.labelDepthResult.Size = new System.Drawing.Size(44, 42);
            this.labelDepthResult.TabIndex = 2;
            this.labelDepthResult.Text = "5";
            this.labelDepthResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutRightAngle
            // 
            this.tableLayoutRightAngle.ColumnCount = 3;
            this.tableLayoutRightAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutRightAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRightAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRightAngle.Controls.Add(this.labelRightAngle, 0, 0);
            this.tableLayoutRightAngle.Controls.Add(this.trackBarRightAngle, 1, 0);
            this.tableLayoutRightAngle.Controls.Add(this.labelRightAngleResult, 2, 0);
            this.tableLayoutRightAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutRightAngle.Location = new System.Drawing.Point(491, 51);
            this.tableLayoutRightAngle.Name = "tableLayoutRightAngle";
            this.tableLayoutRightAngle.RowCount = 1;
            this.tableLayoutRightAngle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRightAngle.Size = new System.Drawing.Size(482, 42);
            this.tableLayoutRightAngle.TabIndex = 3;
            // 
            // labelRightAngle
            // 
            this.labelRightAngle.AutoSize = true;
            this.labelRightAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightAngle.Location = new System.Drawing.Point(3, 0);
            this.labelRightAngle.Name = "labelRightAngle";
            this.labelRightAngle.Size = new System.Drawing.Size(114, 42);
            this.labelRightAngle.TabIndex = 0;
            this.labelRightAngle.Text = "右分支角度";
            this.labelRightAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarRightAngle
            // 
            this.trackBarRightAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarRightAngle.LargeChange = 2;
            this.trackBarRightAngle.Location = new System.Drawing.Point(123, 3);
            this.trackBarRightAngle.Maximum = 12;
            this.trackBarRightAngle.Name = "trackBarRightAngle";
            this.trackBarRightAngle.Size = new System.Drawing.Size(306, 36);
            this.trackBarRightAngle.SmallChange = 15;
            this.trackBarRightAngle.TabIndex = 1;
            this.trackBarRightAngle.Value = 4;
            this.trackBarRightAngle.ValueChanged += new System.EventHandler(this.trackBarRightAngle_ValueChanged);
            // 
            // labelRightAngleResult
            // 
            this.labelRightAngleResult.AutoSize = true;
            this.labelRightAngleResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightAngleResult.Location = new System.Drawing.Point(435, 0);
            this.labelRightAngleResult.Name = "labelRightAngleResult";
            this.labelRightAngleResult.Size = new System.Drawing.Size(44, 42);
            this.labelRightAngleResult.TabIndex = 2;
            this.labelRightAngleResult.Text = "45";
            this.labelRightAngleResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutRightLength
            // 
            this.tableLayoutRightLength.ColumnCount = 3;
            this.tableLayoutRightLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutRightLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRightLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutRightLength.Controls.Add(this.labelRightLenght, 0, 0);
            this.tableLayoutRightLength.Controls.Add(this.trackBarRightLength, 1, 0);
            this.tableLayoutRightLength.Controls.Add(this.labelRightLengthResult, 2, 0);
            this.tableLayoutRightLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutRightLength.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutRightLength.Name = "tableLayoutRightLength";
            this.tableLayoutRightLength.RowCount = 1;
            this.tableLayoutRightLength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRightLength.Size = new System.Drawing.Size(482, 42);
            this.tableLayoutRightLength.TabIndex = 2;
            // 
            // labelRightLenght
            // 
            this.labelRightLenght.AutoSize = true;
            this.labelRightLenght.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightLenght.Location = new System.Drawing.Point(3, 0);
            this.labelRightLenght.Name = "labelRightLenght";
            this.labelRightLenght.Size = new System.Drawing.Size(114, 42);
            this.labelRightLenght.TabIndex = 0;
            this.labelRightLenght.Text = "右分支长度比";
            this.labelRightLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarRightLength
            // 
            this.trackBarRightLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarRightLength.Location = new System.Drawing.Point(123, 3);
            this.trackBarRightLength.Maximum = 20;
            this.trackBarRightLength.Name = "trackBarRightLength";
            this.trackBarRightLength.Size = new System.Drawing.Size(306, 36);
            this.trackBarRightLength.TabIndex = 1;
            this.trackBarRightLength.Value = 5;
            this.trackBarRightLength.ValueChanged += new System.EventHandler(this.trackBarRightLength_ValueChanged);
            // 
            // labelRightLengthResult
            // 
            this.labelRightLengthResult.AutoSize = true;
            this.labelRightLengthResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightLengthResult.Location = new System.Drawing.Point(435, 0);
            this.labelRightLengthResult.Name = "labelRightLengthResult";
            this.labelRightLengthResult.Size = new System.Drawing.Size(44, 42);
            this.labelRightLengthResult.TabIndex = 2;
            this.labelRightLengthResult.Text = "0.25";
            this.labelRightLengthResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutLeftAngle
            // 
            this.tableLayoutLeftAngle.ColumnCount = 3;
            this.tableLayoutLeftAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutLeftAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeftAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutLeftAngle.Controls.Add(this.labelLeftAngle, 0, 0);
            this.tableLayoutLeftAngle.Controls.Add(this.trackBarLeftAngle, 1, 0);
            this.tableLayoutLeftAngle.Controls.Add(this.labelLeftAngleResult, 2, 0);
            this.tableLayoutLeftAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeftAngle.Location = new System.Drawing.Point(491, 3);
            this.tableLayoutLeftAngle.Name = "tableLayoutLeftAngle";
            this.tableLayoutLeftAngle.RowCount = 1;
            this.tableLayoutLeftAngle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeftAngle.Size = new System.Drawing.Size(482, 42);
            this.tableLayoutLeftAngle.TabIndex = 1;
            // 
            // labelLeftAngle
            // 
            this.labelLeftAngle.AutoSize = true;
            this.labelLeftAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftAngle.Location = new System.Drawing.Point(3, 0);
            this.labelLeftAngle.Name = "labelLeftAngle";
            this.labelLeftAngle.Size = new System.Drawing.Size(114, 42);
            this.labelLeftAngle.TabIndex = 0;
            this.labelLeftAngle.Text = "左分支角度";
            this.labelLeftAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarLeftAngle
            // 
            this.trackBarLeftAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarLeftAngle.LargeChange = 2;
            this.trackBarLeftAngle.Location = new System.Drawing.Point(123, 3);
            this.trackBarLeftAngle.Maximum = 12;
            this.trackBarLeftAngle.Name = "trackBarLeftAngle";
            this.trackBarLeftAngle.Size = new System.Drawing.Size(306, 36);
            this.trackBarLeftAngle.TabIndex = 1;
            this.trackBarLeftAngle.Value = 3;
            this.trackBarLeftAngle.ValueChanged += new System.EventHandler(this.trackBarLeftAngle_ValueChanged);
            // 
            // labelLeftAngleResult
            // 
            this.labelLeftAngleResult.AutoSize = true;
            this.labelLeftAngleResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftAngleResult.Location = new System.Drawing.Point(435, 0);
            this.labelLeftAngleResult.Name = "labelLeftAngleResult";
            this.labelLeftAngleResult.Size = new System.Drawing.Size(44, 42);
            this.labelLeftAngleResult.TabIndex = 2;
            this.labelLeftAngleResult.Text = "45";
            this.labelLeftAngleResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutLeftLength
            // 
            this.tableLayoutLeftLength.ColumnCount = 3;
            this.tableLayoutLeftLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutLeftLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeftLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutLeftLength.Controls.Add(this.labelLeftLength, 0, 0);
            this.tableLayoutLeftLength.Controls.Add(this.trackBarLeftLength, 1, 0);
            this.tableLayoutLeftLength.Controls.Add(this.labelLeftLengthResult, 2, 0);
            this.tableLayoutLeftLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeftLength.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutLeftLength.Name = "tableLayoutLeftLength";
            this.tableLayoutLeftLength.RowCount = 1;
            this.tableLayoutLeftLength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeftLength.Size = new System.Drawing.Size(482, 42);
            this.tableLayoutLeftLength.TabIndex = 0;
            // 
            // labelLeftLength
            // 
            this.labelLeftLength.AutoSize = true;
            this.labelLeftLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftLength.Location = new System.Drawing.Point(3, 0);
            this.labelLeftLength.Name = "labelLeftLength";
            this.labelLeftLength.Size = new System.Drawing.Size(114, 42);
            this.labelLeftLength.TabIndex = 0;
            this.labelLeftLength.Text = "左分支长度比";
            this.labelLeftLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarLeftLength
            // 
            this.trackBarLeftLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarLeftLength.Location = new System.Drawing.Point(123, 3);
            this.trackBarLeftLength.Maximum = 20;
            this.trackBarLeftLength.Name = "trackBarLeftLength";
            this.trackBarLeftLength.Size = new System.Drawing.Size(306, 36);
            this.trackBarLeftLength.TabIndex = 1;
            this.trackBarLeftLength.Value = 8;
            this.trackBarLeftLength.ValueChanged += new System.EventHandler(this.trackBarLeftLength_ValueChanged);
            // 
            // labelLeftLengthResult
            // 
            this.labelLeftLengthResult.AutoSize = true;
            this.labelLeftLengthResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftLengthResult.Location = new System.Drawing.Point(435, 0);
            this.labelLeftLengthResult.Name = "labelLeftLengthResult";
            this.labelLeftLengthResult.Size = new System.Drawing.Size(44, 42);
            this.labelLeftLengthResult.TabIndex = 2;
            this.labelLeftLengthResult.Text = "0.40";
            this.labelLeftLengthResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonDraw.Location = new System.Drawing.Point(685, 154);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(94, 30);
            this.buttonDraw.TabIndex = 7;
            this.buttonDraw.Text = "绘制";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(3, 3);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(976, 547);
            this.panelGraph.TabIndex = 1;
            // 
            // FormCayleyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.tableLayoutForm);
            this.Name = "FormCayleyTree";
            this.Text = "CayleyTree";
            this.tableLayoutForm.ResumeLayout(false);
            this.tableLayoutParams.ResumeLayout(false);
            this.tableLayoutLength.ResumeLayout(false);
            this.tableLayoutLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).EndInit();
            this.tableLayoutColor.ResumeLayout(false);
            this.tableLayoutColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.tableLayoutDepth.ResumeLayout(false);
            this.tableLayoutDepth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            this.tableLayoutRightAngle.ResumeLayout(false);
            this.tableLayoutRightAngle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightAngle)).EndInit();
            this.tableLayoutRightLength.ResumeLayout(false);
            this.tableLayoutRightLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightLength)).EndInit();
            this.tableLayoutLeftAngle.ResumeLayout(false);
            this.tableLayoutLeftAngle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftAngle)).EndInit();
            this.tableLayoutLeftLength.ResumeLayout(false);
            this.tableLayoutLeftLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutForm;
        private TableLayoutPanel tableLayoutParams;
        private TableLayoutPanel tableLayoutLength;
        private Label labelLength;
        private TrackBar trackBarLength;
        private Label labelLengthResult;
        private TableLayoutPanel tableLayoutColor;
        private Label labelColor;
        private TableLayoutPanel tableLayoutDepth;
        private Label labelDepth;
        private TrackBar trackBarDepth;
        private Label labelDepthResult;
        private TableLayoutPanel tableLayoutRightAngle;
        private Label labelRightAngle;
        private TrackBar trackBarRightAngle;
        private Label labelRightAngleResult;
        private TableLayoutPanel tableLayoutRightLength;
        private Label labelRightLenght;
        private TrackBar trackBarRightLength;
        private Label labelRightLengthResult;
        private TableLayoutPanel tableLayoutLeftAngle;
        private Label labelLeftAngle;
        private TrackBar trackBarLeftAngle;
        private Label labelLeftAngleResult;
        private TableLayoutPanel tableLayoutLeftLength;
        private Label labelLeftLength;
        private TrackBar trackBarLeftLength;
        private Label labelLeftLengthResult;
        private ComboBox comboBoxColor;
        private Button buttonDraw;
        private Panel panelGraph;
        private DataTable dt;
    }
}