namespace FotoFox
{
    partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.MainPanel = new System.Windows.Forms.Panel();
      this.ControlsFlow = new System.Windows.Forms.FlowLayoutPanel();
      this.SplittersGB = new System.Windows.Forms.GroupBox();
      this.SpllitersTable = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.BackColorP = new System.Windows.Forms.Panel();
      this.NewPanelColorP = new System.Windows.Forms.Panel();
      this.TransparentPanelCB = new System.Windows.Forms.CheckBox();
      this.BackGroundColorBtn = new System.Windows.Forms.Button();
      this.SplitterWidthTB = new System.Windows.Forms.TextBox();
      this.SizeGB = new System.Windows.Forms.GroupBox();
      this.SizeTable = new System.Windows.Forms.TableLayoutPanel();
      this.SizeStatusFP = new System.Windows.Forms.FlowLayoutPanel();
      this.SizeL = new System.Windows.Forms.Label();
      this.Size2L = new System.Windows.Forms.Label();
      this.SizeHelpBtn = new System.Windows.Forms.Button();
      this.SizePropFP2 = new System.Windows.Forms.FlowLayoutPanel();
      this.ByWidthRB = new System.Windows.Forms.RadioButton();
      this.ByHightRB = new System.Windows.Forms.RadioButton();
      this.SetProportionBtn = new System.Windows.Forms.Button();
      this.SizePropFP1 = new System.Windows.Forms.FlowLayoutPanel();
      this.WidthN = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.HightN = new System.Windows.Forms.NumericUpDown();
      this.IndentsGB = new System.Windows.Forms.GroupBox();
      this.IndentsTable = new System.Windows.Forms.TableLayoutPanel();
      this.IndentTop = new System.Windows.Forms.NumericUpDown();
      this.IndentLeft = new System.Windows.Forms.NumericUpDown();
      this.IndentRight = new System.Windows.Forms.NumericUpDown();
      this.IndentBottom = new System.Windows.Forms.NumericUpDown();
      this.PicLeft = new System.Windows.Forms.PictureBox();
      this.PicTop = new System.Windows.Forms.PictureBox();
      this.PicRight = new System.Windows.Forms.PictureBox();
      this.PicBottom = new System.Windows.Forms.PictureBox();
      this.ExportBtn = new System.Windows.Forms.Button();
      this.ValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.ControlsTable = new System.Windows.Forms.TableLayoutPanel();
      this.ControlsPanel = new System.Windows.Forms.Panel();
      this.TableLayoutPanel.SuspendLayout();
      this.ControlsFlow.SuspendLayout();
      this.SplittersGB.SuspendLayout();
      this.SpllitersTable.SuspendLayout();
      this.SizeGB.SuspendLayout();
      this.SizeTable.SuspendLayout();
      this.SizeStatusFP.SuspendLayout();
      this.SizePropFP2.SuspendLayout();
      this.SizePropFP1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WidthN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.HightN)).BeginInit();
      this.IndentsGB.SuspendLayout();
      this.IndentsTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.IndentTop)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.IndentLeft)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.IndentRight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.IndentBottom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicLeft)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicTop)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicRight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicBottom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).BeginInit();
      this.ControlsTable.SuspendLayout();
      this.ControlsPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
      this.TableLayoutPanel.Controls.Add(this.MainPanel, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.ControlsPanel, 1, 0);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 1;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(1055, 614);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // MainPanel
      // 
      this.MainPanel.BackColor = System.Drawing.Color.LightGray;
      this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainPanel.Location = new System.Drawing.Point(0, 0);
      this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
      this.MainPanel.Name = "MainPanel";
      this.MainPanel.Size = new System.Drawing.Size(856, 614);
      this.MainPanel.TabIndex = 0;
      // 
      // ControlsFlow
      // 
      this.ControlsFlow.Controls.Add(this.SplittersGB);
      this.ControlsFlow.Controls.Add(this.IndentsGB);
      this.ControlsFlow.Controls.Add(this.SizeGB);
      this.ControlsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ControlsFlow.Location = new System.Drawing.Point(0, 0);
      this.ControlsFlow.Margin = new System.Windows.Forms.Padding(0);
      this.ControlsFlow.Name = "ControlsFlow";
      this.ControlsFlow.Size = new System.Drawing.Size(197, 574);
      this.ControlsFlow.TabIndex = 3;
      // 
      // SplittersGB
      // 
      this.SplittersGB.Controls.Add(this.SpllitersTable);
      this.SplittersGB.Location = new System.Drawing.Point(3, 3);
      this.SplittersGB.Name = "SplittersGB";
      this.SplittersGB.Size = new System.Drawing.Size(190, 109);
      this.SplittersGB.TabIndex = 0;
      this.SplittersGB.TabStop = false;
      this.SplittersGB.Text = "Общие";
      // 
      // SpllitersTable
      // 
      this.SpllitersTable.ColumnCount = 4;
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SpllitersTable.Controls.Add(this.label1, 0, 0);
      this.SpllitersTable.Controls.Add(this.label2, 0, 1);
      this.SpllitersTable.Controls.Add(this.label3, 0, 2);
      this.SpllitersTable.Controls.Add(this.BackColorP, 1, 1);
      this.SpllitersTable.Controls.Add(this.NewPanelColorP, 1, 2);
      this.SpllitersTable.Controls.Add(this.TransparentPanelCB, 2, 2);
      this.SpllitersTable.Controls.Add(this.BackGroundColorBtn, 2, 1);
      this.SpllitersTable.Controls.Add(this.SplitterWidthTB, 2, 0);
      this.SpllitersTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SpllitersTable.Location = new System.Drawing.Point(3, 16);
      this.SpllitersTable.Margin = new System.Windows.Forms.Padding(0);
      this.SpllitersTable.Name = "SpllitersTable";
      this.SpllitersTable.RowCount = 3;
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.SpllitersTable.Size = new System.Drawing.Size(184, 90);
      this.SpllitersTable.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.SpllitersTable.SetColumnSpan(this.label1, 2);
      this.label1.Location = new System.Drawing.Point(3, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Разделитель";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 38);
      this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Заливка";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 68);
      this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Пустые";
      // 
      // BackColorP
      // 
      this.BackColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.BackColorP.Cursor = System.Windows.Forms.Cursors.Hand;
      this.BackColorP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BackColorP.Location = new System.Drawing.Point(56, 33);
      this.BackColorP.Name = "BackColorP";
      this.BackColorP.Size = new System.Drawing.Size(29, 24);
      this.BackColorP.TabIndex = 1;
      this.BackColorP.Click += new System.EventHandler(this.BackColorBtn_Click);
      // 
      // NewPanelColorP
      // 
      this.NewPanelColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.NewPanelColorP.Cursor = System.Windows.Forms.Cursors.Hand;
      this.NewPanelColorP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.NewPanelColorP.Location = new System.Drawing.Point(56, 63);
      this.NewPanelColorP.Name = "NewPanelColorP";
      this.NewPanelColorP.Size = new System.Drawing.Size(29, 24);
      this.NewPanelColorP.TabIndex = 2;
      this.NewPanelColorP.Click += new System.EventHandler(this.NewPanelColorBtn_Click);
      // 
      // TransparentPanelCB
      // 
      this.TransparentPanelCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.TransparentPanelCB.AutoSize = true;
      this.SpllitersTable.SetColumnSpan(this.TransparentPanelCB, 2);
      this.TransparentPanelCB.Location = new System.Drawing.Point(91, 66);
      this.TransparentPanelCB.Name = "TransparentPanelCB";
      this.TransparentPanelCB.Size = new System.Drawing.Size(89, 17);
      this.TransparentPanelCB.TabIndex = 4;
      this.TransparentPanelCB.TabStop = false;
      this.TransparentPanelCB.Text = "Прозрачные";
      this.TransparentPanelCB.UseVisualStyleBackColor = true;
      this.TransparentPanelCB.CheckedChanged += new System.EventHandler(this.TransparentPanelCB_CheckedChanged);
      // 
      // BackGroundColorBtn
      // 
      this.SpllitersTable.SetColumnSpan(this.BackGroundColorBtn, 2);
      this.BackGroundColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BackGroundColorBtn.Image = global::FotoFox.Properties.Resources.image_Add;
      this.BackGroundColorBtn.Location = new System.Drawing.Point(91, 33);
      this.BackGroundColorBtn.Name = "BackGroundColorBtn";
      this.BackGroundColorBtn.Size = new System.Drawing.Size(90, 24);
      this.BackGroundColorBtn.TabIndex = 3;
      this.BackGroundColorBtn.Text = "Картинка";
      this.BackGroundColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BackGroundColorBtn.UseVisualStyleBackColor = true;
      this.BackGroundColorBtn.Click += new System.EventHandler(this.BackGroundColorBtn_Click);
      // 
      // SplitterWidthTB
      // 
      this.SplitterWidthTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.SplitterWidthTB.Location = new System.Drawing.Point(91, 5);
      this.SplitterWidthTB.Name = "SplitterWidthTB";
      this.SplitterWidthTB.Size = new System.Drawing.Size(53, 20);
      this.SplitterWidthTB.TabIndex = 0;
      this.SplitterWidthTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplitterWidthTB_KeyDown);
      this.SplitterWidthTB.Validating += new System.ComponentModel.CancelEventHandler(this.SplitterWidthText_Validating);
      this.SplitterWidthTB.Validated += new System.EventHandler(this.SplitterWidthText_Validated);
      // 
      // SizeGB
      // 
      this.SizeGB.Controls.Add(this.SizeTable);
      this.SizeGB.Location = new System.Drawing.Point(3, 227);
      this.SizeGB.Name = "SizeGB";
      this.SizeGB.Size = new System.Drawing.Size(190, 130);
      this.SizeGB.TabIndex = 1;
      this.SizeGB.TabStop = false;
      this.SizeGB.Text = "Размер изображения";
      // 
      // SizeTable
      // 
      this.SizeTable.ColumnCount = 1;
      this.SizeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SizeTable.Controls.Add(this.SizeStatusFP, 0, 0);
      this.SizeTable.Controls.Add(this.SizePropFP2, 0, 2);
      this.SizeTable.Controls.Add(this.SetProportionBtn, 0, 3);
      this.SizeTable.Controls.Add(this.SizePropFP1, 0, 1);
      this.SizeTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizeTable.Location = new System.Drawing.Point(3, 16);
      this.SizeTable.Margin = new System.Windows.Forms.Padding(0);
      this.SizeTable.Name = "SizeTable";
      this.SizeTable.RowCount = 4;
      this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SizeTable.Size = new System.Drawing.Size(184, 111);
      this.SizeTable.TabIndex = 0;
      // 
      // SizeStatusFP
      // 
      this.SizeStatusFP.Controls.Add(this.SizeL);
      this.SizeStatusFP.Controls.Add(this.Size2L);
      this.SizeStatusFP.Controls.Add(this.SizeHelpBtn);
      this.SizeStatusFP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizeStatusFP.Location = new System.Drawing.Point(0, 0);
      this.SizeStatusFP.Margin = new System.Windows.Forms.Padding(0);
      this.SizeStatusFP.Name = "SizeStatusFP";
      this.SizeStatusFP.Size = new System.Drawing.Size(184, 28);
      this.SizeStatusFP.TabIndex = 0;
      // 
      // SizeL
      // 
      this.SizeL.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.SizeL.AutoSize = true;
      this.SizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SizeL.Location = new System.Drawing.Point(3, 7);
      this.SizeL.Name = "SizeL";
      this.SizeL.Size = new System.Drawing.Size(69, 13);
      this.SizeL.TabIndex = 1;
      this.SizeL.Text = "XXX x YYY";
      // 
      // Size2L
      // 
      this.Size2L.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.Size2L.AutoSize = true;
      this.Size2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Size2L.Location = new System.Drawing.Point(78, 7);
      this.Size2L.Name = "Size2L";
      this.Size2L.Size = new System.Drawing.Size(35, 13);
      this.Size2L.TabIndex = 3;
      this.Size2L.Text = "(X:Y)";
      // 
      // SizeHelpBtn
      // 
      this.SizeHelpBtn.Location = new System.Drawing.Point(119, 3);
      this.SizeHelpBtn.Name = "SizeHelpBtn";
      this.SizeHelpBtn.Size = new System.Drawing.Size(17, 22);
      this.SizeHelpBtn.TabIndex = 4;
      this.SizeHelpBtn.TabStop = false;
      this.SizeHelpBtn.Text = "?";
      this.SizeHelpBtn.UseVisualStyleBackColor = true;
      this.SizeHelpBtn.Click += new System.EventHandler(this.SizeHelpBtn_Click);
      // 
      // SizePropFP2
      // 
      this.SizePropFP2.Controls.Add(this.ByWidthRB);
      this.SizePropFP2.Controls.Add(this.ByHightRB);
      this.SizePropFP2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizePropFP2.Location = new System.Drawing.Point(0, 54);
      this.SizePropFP2.Margin = new System.Windows.Forms.Padding(0);
      this.SizePropFP2.Name = "SizePropFP2";
      this.SizePropFP2.Size = new System.Drawing.Size(184, 25);
      this.SizePropFP2.TabIndex = 1;
      // 
      // ByWidthRB
      // 
      this.ByWidthRB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ByWidthRB.AutoSize = true;
      this.ByWidthRB.Checked = true;
      this.ByWidthRB.Location = new System.Drawing.Point(3, 3);
      this.ByWidthRB.Name = "ByWidthRB";
      this.ByWidthRB.Size = new System.Drawing.Size(75, 17);
      this.ByWidthRB.TabIndex = 2;
      this.ByWidthRB.TabStop = true;
      this.ByWidthRB.Text = "По Длине";
      this.ByWidthRB.UseVisualStyleBackColor = true;
      // 
      // ByHightRB
      // 
      this.ByHightRB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ByHightRB.AutoSize = true;
      this.ByHightRB.Location = new System.Drawing.Point(84, 3);
      this.ByHightRB.Name = "ByHightRB";
      this.ByHightRB.Size = new System.Drawing.Size(80, 17);
      this.ByHightRB.TabIndex = 3;
      this.ByHightRB.Text = "По Высоте";
      this.ByHightRB.UseVisualStyleBackColor = true;
      // 
      // SetProportionBtn
      // 
      this.SetProportionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SetProportionBtn.Image = global::FotoFox.Properties.Resources.resize;
      this.SetProportionBtn.Location = new System.Drawing.Point(3, 82);
      this.SetProportionBtn.Name = "SetProportionBtn";
      this.SetProportionBtn.Size = new System.Drawing.Size(178, 26);
      this.SetProportionBtn.TabIndex = 4;
      this.SetProportionBtn.Text = "Установить размер окна";
      this.SetProportionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.SetProportionBtn.UseVisualStyleBackColor = true;
      this.SetProportionBtn.Click += new System.EventHandler(this.SetProportionBtn_Click);
      // 
      // SizePropFP1
      // 
      this.SizePropFP1.Controls.Add(this.WidthN);
      this.SizePropFP1.Controls.Add(this.label8);
      this.SizePropFP1.Controls.Add(this.HightN);
      this.SizePropFP1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizePropFP1.Location = new System.Drawing.Point(0, 28);
      this.SizePropFP1.Margin = new System.Windows.Forms.Padding(0);
      this.SizePropFP1.Name = "SizePropFP1";
      this.SizePropFP1.Size = new System.Drawing.Size(184, 26);
      this.SizePropFP1.TabIndex = 5;
      // 
      // WidthN
      // 
      this.WidthN.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.WidthN.Location = new System.Drawing.Point(3, 3);
      this.WidthN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.WidthN.Name = "WidthN";
      this.WidthN.Size = new System.Drawing.Size(35, 20);
      this.WidthN.TabIndex = 0;
      this.WidthN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(44, 6);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(11, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = ":";
      // 
      // HightN
      // 
      this.HightN.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.HightN.Location = new System.Drawing.Point(61, 3);
      this.HightN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.HightN.Name = "HightN";
      this.HightN.Size = new System.Drawing.Size(35, 20);
      this.HightN.TabIndex = 1;
      this.HightN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // IndentsGB
      // 
      this.IndentsGB.Controls.Add(this.IndentsTable);
      this.IndentsGB.Location = new System.Drawing.Point(3, 118);
      this.IndentsGB.Name = "IndentsGB";
      this.IndentsGB.Size = new System.Drawing.Size(190, 103);
      this.IndentsGB.TabIndex = 2;
      this.IndentsGB.TabStop = false;
      this.IndentsGB.Text = "Отступы";
      // 
      // IndentsTable
      // 
      this.IndentsTable.ColumnCount = 5;
      this.IndentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.IndentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.IndentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.IndentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.IndentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.IndentsTable.Controls.Add(this.IndentTop, 2, 0);
      this.IndentsTable.Controls.Add(this.IndentLeft, 0, 1);
      this.IndentsTable.Controls.Add(this.IndentRight, 4, 1);
      this.IndentsTable.Controls.Add(this.IndentBottom, 2, 3);
      this.IndentsTable.Controls.Add(this.PicLeft, 1, 1);
      this.IndentsTable.Controls.Add(this.PicTop, 2, 1);
      this.IndentsTable.Controls.Add(this.PicRight, 3, 1);
      this.IndentsTable.Controls.Add(this.PicBottom, 2, 2);
      this.IndentsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.IndentsTable.Location = new System.Drawing.Point(3, 16);
      this.IndentsTable.Margin = new System.Windows.Forms.Padding(0);
      this.IndentsTable.Name = "IndentsTable";
      this.IndentsTable.RowCount = 4;
      this.IndentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.IndentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.IndentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.IndentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.IndentsTable.Size = new System.Drawing.Size(184, 84);
      this.IndentsTable.TabIndex = 0;
      // 
      // IndentTop
      // 
      this.IndentTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.IndentTop.Location = new System.Drawing.Point(69, 3);
      this.IndentTop.Name = "IndentTop";
      this.IndentTop.Size = new System.Drawing.Size(44, 20);
      this.IndentTop.TabIndex = 0;
      this.IndentTop.ValueChanged += new System.EventHandler(this.Indent_ValueChanged);
      // 
      // IndentLeft
      // 
      this.IndentLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.IndentLeft.Location = new System.Drawing.Point(3, 32);
      this.IndentLeft.Name = "IndentLeft";
      this.IndentsTable.SetRowSpan(this.IndentLeft, 2);
      this.IndentLeft.Size = new System.Drawing.Size(44, 20);
      this.IndentLeft.TabIndex = 1;
      this.IndentLeft.ValueChanged += new System.EventHandler(this.Indent_ValueChanged);
      // 
      // IndentRight
      // 
      this.IndentRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.IndentRight.Location = new System.Drawing.Point(135, 32);
      this.IndentRight.Name = "IndentRight";
      this.IndentsTable.SetRowSpan(this.IndentRight, 2);
      this.IndentRight.Size = new System.Drawing.Size(46, 20);
      this.IndentRight.TabIndex = 2;
      this.IndentRight.ValueChanged += new System.EventHandler(this.Indent_ValueChanged);
      // 
      // IndentBottom
      // 
      this.IndentBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.IndentBottom.Location = new System.Drawing.Point(69, 61);
      this.IndentBottom.Name = "IndentBottom";
      this.IndentBottom.Size = new System.Drawing.Size(44, 20);
      this.IndentBottom.TabIndex = 3;
      this.IndentBottom.ValueChanged += new System.EventHandler(this.Indent_ValueChanged);
      // 
      // PicLeft
      // 
      this.PicLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.PicLeft.Image = global::FotoFox.Properties.Resources.left;
      this.PicLeft.Location = new System.Drawing.Point(50, 34);
      this.PicLeft.Margin = new System.Windows.Forms.Padding(0);
      this.PicLeft.Name = "PicLeft";
      this.IndentsTable.SetRowSpan(this.PicLeft, 2);
      this.PicLeft.Size = new System.Drawing.Size(16, 16);
      this.PicLeft.TabIndex = 4;
      this.PicLeft.TabStop = false;
      // 
      // PicTop
      // 
      this.PicTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.PicTop.Image = global::FotoFox.Properties.Resources.top;
      this.PicTop.Location = new System.Drawing.Point(83, 26);
      this.PicTop.Margin = new System.Windows.Forms.Padding(0);
      this.PicTop.Name = "PicTop";
      this.PicTop.Size = new System.Drawing.Size(16, 16);
      this.PicTop.TabIndex = 5;
      this.PicTop.TabStop = false;
      // 
      // PicRight
      // 
      this.PicRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.PicRight.Image = global::FotoFox.Properties.Resources.right;
      this.PicRight.Location = new System.Drawing.Point(116, 34);
      this.PicRight.Margin = new System.Windows.Forms.Padding(0);
      this.PicRight.Name = "PicRight";
      this.IndentsTable.SetRowSpan(this.PicRight, 2);
      this.PicRight.Size = new System.Drawing.Size(16, 16);
      this.PicRight.TabIndex = 6;
      this.PicRight.TabStop = false;
      // 
      // PicBottom
      // 
      this.PicBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.PicBottom.Image = global::FotoFox.Properties.Resources.bottom;
      this.PicBottom.Location = new System.Drawing.Point(83, 42);
      this.PicBottom.Margin = new System.Windows.Forms.Padding(0);
      this.PicBottom.Name = "PicBottom";
      this.PicBottom.Size = new System.Drawing.Size(16, 16);
      this.PicBottom.TabIndex = 7;
      this.PicBottom.TabStop = false;
      // 
      // ExportBtn
      // 
      this.ExportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ExportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ExportBtn.Location = new System.Drawing.Point(3, 577);
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(191, 32);
      this.ExportBtn.TabIndex = 2;
      this.ExportBtn.Text = "Экспорт в картинку";
      this.ExportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ExportBtn.UseVisualStyleBackColor = true;
      this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // ValidationErrorProvider
      // 
      this.ValidationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.ValidationErrorProvider.ContainerControl = this;
      // 
      // ControlsTable
      // 
      this.ControlsTable.ColumnCount = 1;
      this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.ControlsTable.Controls.Add(this.ControlsFlow, 0, 0);
      this.ControlsTable.Controls.Add(this.ExportBtn, 0, 1);
      this.ControlsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ControlsTable.Location = new System.Drawing.Point(0, 0);
      this.ControlsTable.Margin = new System.Windows.Forms.Padding(0);
      this.ControlsTable.Name = "ControlsTable";
      this.ControlsTable.RowCount = 2;
      this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
      this.ControlsTable.Size = new System.Drawing.Size(197, 612);
      this.ControlsTable.TabIndex = 4;
      // 
      // ControlsPanel
      // 
      this.ControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ControlsPanel.Controls.Add(this.ControlsTable);
      this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ControlsPanel.Location = new System.Drawing.Point(856, 0);
      this.ControlsPanel.Margin = new System.Windows.Forms.Padding(0);
      this.ControlsPanel.Name = "ControlsPanel";
      this.ControlsPanel.Size = new System.Drawing.Size(199, 614);
      this.ControlsPanel.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ClientSize = new System.Drawing.Size(1055, 614);
      this.Controls.Add(this.TableLayoutPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ФотоФокс";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Resize += new System.EventHandler(this.MainForm_Resize);
      this.TableLayoutPanel.ResumeLayout(false);
      this.ControlsFlow.ResumeLayout(false);
      this.SplittersGB.ResumeLayout(false);
      this.SpllitersTable.ResumeLayout(false);
      this.SpllitersTable.PerformLayout();
      this.SizeGB.ResumeLayout(false);
      this.SizeTable.ResumeLayout(false);
      this.SizeStatusFP.ResumeLayout(false);
      this.SizeStatusFP.PerformLayout();
      this.SizePropFP2.ResumeLayout(false);
      this.SizePropFP2.PerformLayout();
      this.SizePropFP1.ResumeLayout(false);
      this.SizePropFP1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WidthN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.HightN)).EndInit();
      this.IndentsGB.ResumeLayout(false);
      this.IndentsTable.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.IndentTop)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.IndentLeft)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.IndentRight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.IndentBottom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicLeft)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicTop)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicRight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PicBottom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).EndInit();
      this.ControlsTable.ResumeLayout(false);
      this.ControlsPanel.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox SplittersGB;
        private System.Windows.Forms.TableLayoutPanel SpllitersTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SplitterWidthTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BackColorP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel NewPanelColorP;
        private System.Windows.Forms.ErrorProvider ValidationErrorProvider;
        private System.Windows.Forms.CheckBox TransparentPanelCB;
        private System.Windows.Forms.Button BackGroundColorBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.FlowLayoutPanel ControlsFlow;
        private System.Windows.Forms.GroupBox SizeGB;
        private System.Windows.Forms.TableLayoutPanel SizeTable;
        private System.Windows.Forms.FlowLayoutPanel SizeStatusFP;
        private System.Windows.Forms.Label SizeL;
        private System.Windows.Forms.Label Size2L;
        private System.Windows.Forms.Button SizeHelpBtn;
        private System.Windows.Forms.FlowLayoutPanel SizePropFP2;
        private System.Windows.Forms.NumericUpDown WidthN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown HightN;
        private System.Windows.Forms.RadioButton ByWidthRB;
        private System.Windows.Forms.RadioButton ByHightRB;
        private System.Windows.Forms.Button SetProportionBtn;
        private System.Windows.Forms.FlowLayoutPanel SizePropFP1;
        private System.Windows.Forms.GroupBox IndentsGB;
        private System.Windows.Forms.TableLayoutPanel IndentsTable;
        private System.Windows.Forms.NumericUpDown IndentTop;
        private System.Windows.Forms.NumericUpDown IndentLeft;
        private System.Windows.Forms.NumericUpDown IndentRight;
        private System.Windows.Forms.NumericUpDown IndentBottom;
        private System.Windows.Forms.PictureBox PicLeft;
        private System.Windows.Forms.PictureBox PicTop;
        private System.Windows.Forms.PictureBox PicRight;
        private System.Windows.Forms.PictureBox PicBottom;
        private System.Windows.Forms.TableLayoutPanel ControlsTable;
        private System.Windows.Forms.Panel ControlsPanel;
    }
}

