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
            this.SplittersGB = new System.Windows.Forms.GroupBox();
            this.SpllitersTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackColorP = new System.Windows.Forms.Panel();
            this.NewPanelColorP = new System.Windows.Forms.Panel();
            this.BackColorBtn = new System.Windows.Forms.Button();
            this.NewPanelColorBtn = new System.Windows.Forms.Button();
            this.SplitterWidthTB = new System.Windows.Forms.TextBox();
            this.TransparentPanelCB = new System.Windows.Forms.CheckBox();
            this.BackGroundColorBtn = new System.Windows.Forms.Button();
            this.SizeGB = new System.Windows.Forms.GroupBox();
            this.SizeTable = new System.Windows.Forms.TableLayoutPanel();
            this.SizeStatusFP = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeL = new System.Windows.Forms.Label();
            this.Size2L = new System.Windows.Forms.Label();
            this.SizeHelpBtn = new System.Windows.Forms.Button();
            this.SizePropFP = new System.Windows.Forms.FlowLayoutPanel();
            this.WidthN = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.HightN = new System.Windows.Forms.NumericUpDown();
            this.ByWidthRB = new System.Windows.Forms.RadioButton();
            this.ByHightRB = new System.Windows.Forms.RadioButton();
            this.SetProportionBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TableLayoutPanel.SuspendLayout();
            this.SplittersGB.SuspendLayout();
            this.SpllitersTable.SuspendLayout();
            this.SizeGB.SuspendLayout();
            this.SizeTable.SuspendLayout();
            this.SizeStatusFP.SuspendLayout();
            this.SizePropFP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HightN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 377F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.TableLayoutPanel.Controls.Add(this.MainPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.SplittersGB, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.SizeGB, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.ExportBtn, 1, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(1181, 806);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightGray;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableLayoutPanel.SetColumnSpan(this.MainPanel, 3);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1181, 664);
            this.MainPanel.TabIndex = 0;
            // 
            // SplittersGB
            // 
            this.SplittersGB.Controls.Add(this.SpllitersTable);
            this.SplittersGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplittersGB.Location = new System.Drawing.Point(4, 668);
            this.SplittersGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplittersGB.Name = "SplittersGB";
            this.SplittersGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplittersGB.Size = new System.Drawing.Size(369, 134);
            this.SplittersGB.TabIndex = 0;
            this.SplittersGB.TabStop = false;
            this.SplittersGB.Text = "Общие";
            // 
            // SpllitersTable
            // 
            this.SpllitersTable.ColumnCount = 5;
            this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.SpllitersTable.Controls.Add(this.label1, 0, 0);
            this.SpllitersTable.Controls.Add(this.label2, 0, 1);
            this.SpllitersTable.Controls.Add(this.label3, 0, 2);
            this.SpllitersTable.Controls.Add(this.BackColorP, 1, 1);
            this.SpllitersTable.Controls.Add(this.NewPanelColorP, 1, 2);
            this.SpllitersTable.Controls.Add(this.BackColorBtn, 2, 1);
            this.SpllitersTable.Controls.Add(this.NewPanelColorBtn, 2, 2);
            this.SpllitersTable.Controls.Add(this.SplitterWidthTB, 4, 0);
            this.SpllitersTable.Controls.Add(this.TransparentPanelCB, 3, 2);
            this.SpllitersTable.Controls.Add(this.BackGroundColorBtn, 3, 1);
            this.SpllitersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpllitersTable.Location = new System.Drawing.Point(4, 19);
            this.SpllitersTable.Margin = new System.Windows.Forms.Padding(0);
            this.SpllitersTable.Name = "SpllitersTable";
            this.SpllitersTable.RowCount = 3;
            this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SpllitersTable.Size = new System.Drawing.Size(361, 111);
            this.SpllitersTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.SpllitersTable.SetColumnSpan(this.label1, 4);
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Растояние между изображениями";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цвет заливки";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет пустых";
            // 
            // BackColorP
            // 
            this.BackColorP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColorP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackColorP.Location = new System.Drawing.Point(120, 43);
            this.BackColorP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackColorP.Name = "BackColorP";
            this.BackColorP.Size = new System.Drawing.Size(31, 24);
            this.BackColorP.TabIndex = 1;
            // 
            // NewPanelColorP
            // 
            this.NewPanelColorP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewPanelColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPanelColorP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NewPanelColorP.Location = new System.Drawing.Point(120, 80);
            this.NewPanelColorP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPanelColorP.Name = "NewPanelColorP";
            this.NewPanelColorP.Size = new System.Drawing.Size(31, 24);
            this.NewPanelColorP.TabIndex = 2;
            // 
            // BackColorBtn
            // 
            this.BackColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackColorBtn.Image = global::FotoFox.Properties.Resources.palette_6845;
            this.BackColorBtn.Location = new System.Drawing.Point(161, 43);
            this.BackColorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackColorBtn.Name = "BackColorBtn";
            this.BackColorBtn.Size = new System.Drawing.Size(33, 25);
            this.BackColorBtn.TabIndex = 1;
            this.BackColorBtn.UseVisualStyleBackColor = true;
            this.BackColorBtn.Click += new System.EventHandler(this.BackColorBtn_Click);
            // 
            // NewPanelColorBtn
            // 
            this.NewPanelColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewPanelColorBtn.Image = global::FotoFox.Properties.Resources.palette_6845;
            this.NewPanelColorBtn.Location = new System.Drawing.Point(161, 80);
            this.NewPanelColorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPanelColorBtn.Name = "NewPanelColorBtn";
            this.NewPanelColorBtn.Size = new System.Drawing.Size(33, 25);
            this.NewPanelColorBtn.TabIndex = 7;
            this.NewPanelColorBtn.UseVisualStyleBackColor = true;
            this.NewPanelColorBtn.Click += new System.EventHandler(this.NewPanelColorBtn_Click);
            // 
            // SplitterWidthTB
            // 
            this.SplitterWidthTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SplitterWidthTB.Location = new System.Drawing.Point(261, 7);
            this.SplitterWidthTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitterWidthTB.Name = "SplitterWidthTB";
            this.SplitterWidthTB.Size = new System.Drawing.Size(44, 22);
            this.SplitterWidthTB.TabIndex = 0;
            this.SplitterWidthTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplitterWidthTB_KeyDown);
            this.SplitterWidthTB.Validating += new System.ComponentModel.CancelEventHandler(this.SplitterWidthText_Validating);
            this.SplitterWidthTB.Validated += new System.EventHandler(this.SplitterWidthText_Validated);
            // 
            // TransparentPanelCB
            // 
            this.TransparentPanelCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TransparentPanelCB.AutoSize = true;
            this.SpllitersTable.SetColumnSpan(this.TransparentPanelCB, 2);
            this.TransparentPanelCB.Location = new System.Drawing.Point(206, 82);
            this.TransparentPanelCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransparentPanelCB.Name = "TransparentPanelCB";
            this.TransparentPanelCB.Size = new System.Drawing.Size(113, 21);
            this.TransparentPanelCB.TabIndex = 4;
            this.TransparentPanelCB.TabStop = false;
            this.TransparentPanelCB.Text = "Прозрачные";
            this.TransparentPanelCB.UseVisualStyleBackColor = true;
            this.TransparentPanelCB.CheckedChanged += new System.EventHandler(this.TransparentPanelCB_CheckedChanged);
            // 
            // BackGroundColorBtn
            // 
            this.BackGroundColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpllitersTable.SetColumnSpan(this.BackGroundColorBtn, 2);
            this.BackGroundColorBtn.Image = global::FotoFox.Properties.Resources.folder_magnify_8999;
            this.BackGroundColorBtn.Location = new System.Drawing.Point(206, 41);
            this.BackGroundColorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackGroundColorBtn.Name = "BackGroundColorBtn";
            this.BackGroundColorBtn.Size = new System.Drawing.Size(151, 28);
            this.BackGroundColorBtn.TabIndex = 3;
            this.BackGroundColorBtn.Text = "Из картинки";
            this.BackGroundColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackGroundColorBtn.UseVisualStyleBackColor = true;
            this.BackGroundColorBtn.Click += new System.EventHandler(this.BackGroundColorBtn_Click);
            // 
            // SizeGB
            // 
            this.SizeGB.Controls.Add(this.SizeTable);
            this.SizeGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizeGB.Location = new System.Drawing.Point(806, 668);
            this.SizeGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeGB.Name = "SizeGB";
            this.SizeGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeGB.Size = new System.Drawing.Size(371, 134);
            this.SizeGB.TabIndex = 1;
            this.SizeGB.TabStop = false;
            this.SizeGB.Text = "Размер изображения";
            // 
            // SizeTable
            // 
            this.SizeTable.ColumnCount = 1;
            this.SizeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SizeTable.Controls.Add(this.SizeStatusFP, 0, 0);
            this.SizeTable.Controls.Add(this.SizePropFP, 0, 1);
            this.SizeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizeTable.Location = new System.Drawing.Point(4, 19);
            this.SizeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeTable.Name = "SizeTable";
            this.SizeTable.RowCount = 2;
            this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.SizeTable.Size = new System.Drawing.Size(363, 111);
            this.SizeTable.TabIndex = 0;
            // 
            // SizeStatusFP
            // 
            this.SizeStatusFP.Controls.Add(this.label6);
            this.SizeStatusFP.Controls.Add(this.SizeL);
            this.SizeStatusFP.Controls.Add(this.Size2L);
            this.SizeStatusFP.Controls.Add(this.SizeHelpBtn);
            this.SizeStatusFP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizeStatusFP.Location = new System.Drawing.Point(0, 0);
            this.SizeStatusFP.Margin = new System.Windows.Forms.Padding(0);
            this.SizeStatusFP.Name = "SizeStatusFP";
            this.SizeStatusFP.Size = new System.Drawing.Size(363, 38);
            this.SizeStatusFP.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Размер :";
            // 
            // SizeL
            // 
            this.SizeL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeL.AutoSize = true;
            this.SizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeL.Location = new System.Drawing.Point(77, 9);
            this.SizeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeL.Name = "SizeL";
            this.SizeL.Size = new System.Drawing.Size(85, 17);
            this.SizeL.TabIndex = 1;
            this.SizeL.Text = "XXX x YYY";
            // 
            // Size2L
            // 
            this.Size2L.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Size2L.AutoSize = true;
            this.Size2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size2L.Location = new System.Drawing.Point(170, 9);
            this.Size2L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Size2L.Name = "Size2L";
            this.Size2L.Size = new System.Drawing.Size(45, 17);
            this.Size2L.TabIndex = 3;
            this.Size2L.Text = "(X:Y)";
            // 
            // SizeHelpBtn
            // 
            this.SizeHelpBtn.Location = new System.Drawing.Point(223, 4);
            this.SizeHelpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeHelpBtn.Name = "SizeHelpBtn";
            this.SizeHelpBtn.Size = new System.Drawing.Size(23, 27);
            this.SizeHelpBtn.TabIndex = 4;
            this.SizeHelpBtn.TabStop = false;
            this.SizeHelpBtn.Text = "?";
            this.SizeHelpBtn.UseVisualStyleBackColor = true;
            this.SizeHelpBtn.Click += new System.EventHandler(this.SizeHelpBtn_Click);
            // 
            // SizePropFP
            // 
            this.SizePropFP.Controls.Add(this.WidthN);
            this.SizePropFP.Controls.Add(this.label8);
            this.SizePropFP.Controls.Add(this.HightN);
            this.SizePropFP.Controls.Add(this.ByWidthRB);
            this.SizePropFP.Controls.Add(this.ByHightRB);
            this.SizePropFP.Controls.Add(this.SetProportionBtn);
            this.SizePropFP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizePropFP.Location = new System.Drawing.Point(0, 38);
            this.SizePropFP.Margin = new System.Windows.Forms.Padding(0);
            this.SizePropFP.Name = "SizePropFP";
            this.SizePropFP.Size = new System.Drawing.Size(363, 73);
            this.SizePropFP.TabIndex = 1;
            // 
            // WidthN
            // 
            this.WidthN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WidthN.Location = new System.Drawing.Point(4, 4);
            this.WidthN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthN.Name = "WidthN";
            this.WidthN.Size = new System.Drawing.Size(47, 22);
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
            this.label8.Location = new System.Drawing.Point(59, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = ":";
            // 
            // HightN
            // 
            this.HightN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HightN.Location = new System.Drawing.Point(80, 4);
            this.HightN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HightN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HightN.Name = "HightN";
            this.HightN.Size = new System.Drawing.Size(47, 22);
            this.HightN.TabIndex = 1;
            this.HightN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ByWidthRB
            // 
            this.ByWidthRB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ByWidthRB.AutoSize = true;
            this.ByWidthRB.Checked = true;
            this.ByWidthRB.Location = new System.Drawing.Point(135, 4);
            this.ByWidthRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ByWidthRB.Name = "ByWidthRB";
            this.ByWidthRB.Size = new System.Drawing.Size(94, 21);
            this.ByWidthRB.TabIndex = 2;
            this.ByWidthRB.TabStop = true;
            this.ByWidthRB.Text = "По Длине";
            this.ByWidthRB.UseVisualStyleBackColor = true;
            // 
            // ByHightRB
            // 
            this.ByHightRB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ByHightRB.AutoSize = true;
            this.ByHightRB.Location = new System.Drawing.Point(237, 4);
            this.ByHightRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ByHightRB.Name = "ByHightRB";
            this.ByHightRB.Size = new System.Drawing.Size(100, 21);
            this.ByHightRB.TabIndex = 3;
            this.ByHightRB.Text = "По Высоте";
            this.ByHightRB.UseVisualStyleBackColor = true;
            // 
            // SetProportionBtn
            // 
            this.SetProportionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetProportionBtn.Image = global::FotoFox.Properties.Resources.image_resize_5062;
            this.SetProportionBtn.Location = new System.Drawing.Point(4, 34);
            this.SetProportionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetProportionBtn.Name = "SetProportionBtn";
            this.SetProportionBtn.Size = new System.Drawing.Size(225, 31);
            this.SetProportionBtn.TabIndex = 4;
            this.SetProportionBtn.Text = "Установить размер окна";
            this.SetProportionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SetProportionBtn.UseVisualStyleBackColor = true;
            this.SetProportionBtn.Click += new System.EventHandler(this.SetProportionBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportBtn.Image = global::FotoFox.Properties.Resources._1355156345_orange_folder_image;
            this.ExportBtn.Location = new System.Drawing.Point(455, 759);
            this.ExportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(268, 43);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 806);
            this.Controls.Add(this.TableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ФотоФокс";
            this.TableLayoutPanel.ResumeLayout(false);
            this.SplittersGB.ResumeLayout(false);
            this.SpllitersTable.ResumeLayout(false);
            this.SpllitersTable.PerformLayout();
            this.SizeGB.ResumeLayout(false);
            this.SizeTable.ResumeLayout(false);
            this.SizeStatusFP.ResumeLayout(false);
            this.SizeStatusFP.PerformLayout();
            this.SizePropFP.ResumeLayout(false);
            this.SizePropFP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HightN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).EndInit();
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
        private System.Windows.Forms.Button BackColorBtn;
        private System.Windows.Forms.Panel BackColorP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel NewPanelColorP;
        private System.Windows.Forms.Button NewPanelColorBtn;
        private System.Windows.Forms.ErrorProvider ValidationErrorProvider;
        private System.Windows.Forms.GroupBox SizeGB;
        private System.Windows.Forms.TableLayoutPanel SizeTable;
        private System.Windows.Forms.FlowLayoutPanel SizeStatusFP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SizeL;
        private System.Windows.Forms.Label Size2L;
        private System.Windows.Forms.Button SizeHelpBtn;
        private System.Windows.Forms.FlowLayoutPanel SizePropFP;
        private System.Windows.Forms.NumericUpDown WidthN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown HightN;
        private System.Windows.Forms.RadioButton ByHightRB;
        private System.Windows.Forms.RadioButton ByWidthRB;
        private System.Windows.Forms.Button SetProportionBtn;
        private System.Windows.Forms.CheckBox TransparentPanelCB;
        private System.Windows.Forms.Button BackGroundColorBtn;
        private System.Windows.Forms.Button ExportBtn;
    }
}

