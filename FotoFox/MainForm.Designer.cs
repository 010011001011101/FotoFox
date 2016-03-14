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
      this.SplitterWidthTB = new System.Windows.Forms.TextBox();
      this.TransparentPanelCB = new System.Windows.Forms.CheckBox();
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
      this.ValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.BackColorBtn = new System.Windows.Forms.Button();
      this.NewPanelColorBtn = new System.Windows.Forms.Button();
      this.BackGroundColorBtn = new System.Windows.Forms.Button();
      this.SetProportionBtn = new System.Windows.Forms.Button();
      this.ExportBtn = new System.Windows.Forms.Button();
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
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
      this.TableLayoutPanel.Controls.Add(this.MainPanel, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.SplittersGB, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.SizeGB, 2, 1);
      this.TableLayoutPanel.Controls.Add(this.ExportBtn, 1, 1);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 2;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(886, 655);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // MainPanel
      // 
      this.MainPanel.BackColor = System.Drawing.Color.LightGray;
      this.TableLayoutPanel.SetColumnSpan(this.MainPanel, 3);
      this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainPanel.Location = new System.Drawing.Point(0, 0);
      this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
      this.MainPanel.Name = "MainPanel";
      this.MainPanel.Size = new System.Drawing.Size(886, 540);
      this.MainPanel.TabIndex = 0;
      // 
      // SplittersGB
      // 
      this.SplittersGB.Controls.Add(this.SpllitersTable);
      this.SplittersGB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SplittersGB.Location = new System.Drawing.Point(3, 543);
      this.SplittersGB.Name = "SplittersGB";
      this.SplittersGB.Size = new System.Drawing.Size(277, 109);
      this.SplittersGB.TabIndex = 0;
      this.SplittersGB.TabStop = false;
      this.SplittersGB.Text = "Общие";
      // 
      // SpllitersTable
      // 
      this.SpllitersTable.ColumnCount = 5;
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SpllitersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
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
      this.SpllitersTable.Location = new System.Drawing.Point(3, 16);
      this.SpllitersTable.Margin = new System.Windows.Forms.Padding(0);
      this.SpllitersTable.Name = "SpllitersTable";
      this.SpllitersTable.RowCount = 3;
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.SpllitersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.SpllitersTable.Size = new System.Drawing.Size(271, 90);
      this.SpllitersTable.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.SpllitersTable.SetColumnSpan(this.label1, 4);
      this.label1.Location = new System.Drawing.Point(3, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(182, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Растояние между изображениями";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Цвет заливки";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Цвет пустых";
      // 
      // BackColorP
      // 
      this.BackColorP.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.BackColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.BackColorP.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.BackColorP.Location = new System.Drawing.Point(90, 35);
      this.BackColorP.Name = "BackColorP";
      this.BackColorP.Size = new System.Drawing.Size(24, 20);
      this.BackColorP.TabIndex = 1;
      // 
      // NewPanelColorP
      // 
      this.NewPanelColorP.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.NewPanelColorP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.NewPanelColorP.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.NewPanelColorP.Location = new System.Drawing.Point(90, 65);
      this.NewPanelColorP.Name = "NewPanelColorP";
      this.NewPanelColorP.Size = new System.Drawing.Size(24, 20);
      this.NewPanelColorP.TabIndex = 2;
      // 
      // SplitterWidthTB
      // 
      this.SplitterWidthTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.SplitterWidthTB.Location = new System.Drawing.Point(196, 5);
      this.SplitterWidthTB.Name = "SplitterWidthTB";
      this.SplitterWidthTB.Size = new System.Drawing.Size(34, 20);
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
      this.TransparentPanelCB.Location = new System.Drawing.Point(155, 66);
      this.TransparentPanelCB.Name = "TransparentPanelCB";
      this.TransparentPanelCB.Size = new System.Drawing.Size(89, 17);
      this.TransparentPanelCB.TabIndex = 4;
      this.TransparentPanelCB.TabStop = false;
      this.TransparentPanelCB.Text = "Прозрачные";
      this.TransparentPanelCB.UseVisualStyleBackColor = true;
      this.TransparentPanelCB.CheckedChanged += new System.EventHandler(this.TransparentPanelCB_CheckedChanged);
      // 
      // SizeGB
      // 
      this.SizeGB.Controls.Add(this.SizeTable);
      this.SizeGB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizeGB.Location = new System.Drawing.Point(605, 543);
      this.SizeGB.Name = "SizeGB";
      this.SizeGB.Size = new System.Drawing.Size(278, 109);
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
      this.SizeTable.Location = new System.Drawing.Point(3, 16);
      this.SizeTable.Name = "SizeTable";
      this.SizeTable.RowCount = 2;
      this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.SizeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.SizeTable.Size = new System.Drawing.Size(272, 90);
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
      this.SizeStatusFP.Size = new System.Drawing.Size(272, 31);
      this.SizeStatusFP.TabIndex = 0;
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 7);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(52, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Размер :";
      // 
      // SizeL
      // 
      this.SizeL.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.SizeL.AutoSize = true;
      this.SizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SizeL.Location = new System.Drawing.Point(61, 7);
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
      this.Size2L.Location = new System.Drawing.Point(136, 7);
      this.Size2L.Name = "Size2L";
      this.Size2L.Size = new System.Drawing.Size(35, 13);
      this.Size2L.TabIndex = 3;
      this.Size2L.Text = "(X:Y)";
      // 
      // SizeHelpBtn
      // 
      this.SizeHelpBtn.Location = new System.Drawing.Point(177, 3);
      this.SizeHelpBtn.Name = "SizeHelpBtn";
      this.SizeHelpBtn.Size = new System.Drawing.Size(17, 22);
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
      this.SizePropFP.Location = new System.Drawing.Point(0, 31);
      this.SizePropFP.Margin = new System.Windows.Forms.Padding(0);
      this.SizePropFP.Name = "SizePropFP";
      this.SizePropFP.Size = new System.Drawing.Size(272, 59);
      this.SizePropFP.TabIndex = 1;
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
      // ByWidthRB
      // 
      this.ByWidthRB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ByWidthRB.AutoSize = true;
      this.ByWidthRB.Checked = true;
      this.ByWidthRB.Location = new System.Drawing.Point(102, 4);
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
      this.ByHightRB.Location = new System.Drawing.Point(183, 4);
      this.ByHightRB.Name = "ByHightRB";
      this.ByHightRB.Size = new System.Drawing.Size(80, 17);
      this.ByHightRB.TabIndex = 3;
      this.ByHightRB.Text = "По Высоте";
      this.ByHightRB.UseVisualStyleBackColor = true;
      // 
      // ValidationErrorProvider
      // 
      this.ValidationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.ValidationErrorProvider.ContainerControl = this;
      // 
      // BackColorBtn
      // 
      this.BackColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.BackColorBtn.Image = global::FotoFox.Properties.Resources.palette_6845;
      this.BackColorBtn.Location = new System.Drawing.Point(121, 35);
      this.BackColorBtn.Name = "BackColorBtn";
      this.BackColorBtn.Size = new System.Drawing.Size(25, 20);
      this.BackColorBtn.TabIndex = 1;
      this.BackColorBtn.UseVisualStyleBackColor = true;
      this.BackColorBtn.Click += new System.EventHandler(this.BackColorBtn_Click);
      // 
      // NewPanelColorBtn
      // 
      this.NewPanelColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.NewPanelColorBtn.Image = global::FotoFox.Properties.Resources.palette_6845;
      this.NewPanelColorBtn.Location = new System.Drawing.Point(121, 65);
      this.NewPanelColorBtn.Name = "NewPanelColorBtn";
      this.NewPanelColorBtn.Size = new System.Drawing.Size(25, 20);
      this.NewPanelColorBtn.TabIndex = 7;
      this.NewPanelColorBtn.UseVisualStyleBackColor = true;
      this.NewPanelColorBtn.Click += new System.EventHandler(this.NewPanelColorBtn_Click);
      // 
      // BackGroundColorBtn
      // 
      this.BackGroundColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.SpllitersTable.SetColumnSpan(this.BackGroundColorBtn, 2);
      this.BackGroundColorBtn.Image = global::FotoFox.Properties.Resources.folder;
      this.BackGroundColorBtn.Location = new System.Drawing.Point(155, 33);
      this.BackGroundColorBtn.Name = "BackGroundColorBtn";
      this.BackGroundColorBtn.Size = new System.Drawing.Size(113, 23);
      this.BackGroundColorBtn.TabIndex = 3;
      this.BackGroundColorBtn.Text = "Из картинки";
      this.BackGroundColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BackGroundColorBtn.UseVisualStyleBackColor = true;
      this.BackGroundColorBtn.Click += new System.EventHandler(this.BackGroundColorBtn_Click);
      // 
      // SetProportionBtn
      // 
      this.SetProportionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SetProportionBtn.Image = global::FotoFox.Properties.Resources.resize;
      this.SetProportionBtn.Location = new System.Drawing.Point(3, 29);
      this.SetProportionBtn.Name = "SetProportionBtn";
      this.SetProportionBtn.Size = new System.Drawing.Size(169, 25);
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
      this.ExportBtn.Location = new System.Drawing.Point(342, 617);
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(201, 35);
      this.ExportBtn.TabIndex = 2;
      this.ExportBtn.Text = "Экспорт в картинку";
      this.ExportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ExportBtn.UseVisualStyleBackColor = true;
      this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(886, 655);
      this.Controls.Add(this.TableLayoutPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

