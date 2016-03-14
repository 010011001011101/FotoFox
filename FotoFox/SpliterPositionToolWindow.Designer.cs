namespace FotoFox
{
  partial class SpliterPositionToolWindow
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
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.FullSizelabel = new System.Windows.Forms.Label();
      this.ProportionBox = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.FirstPanelLabel1 = new System.Windows.Forms.Label();
      this.SecondPanelLabel1 = new System.Windows.Forms.Label();
      this.FirstPanelLabel2 = new System.Windows.Forms.Label();
      this.SecondPanelLabel2 = new System.Windows.Forms.Label();
      this.FirstPanelProportion = new System.Windows.Forms.NumericUpDown();
      this.SecondPanelProportion = new System.Windows.Forms.NumericUpDown();
      this.FirstPanelExact = new System.Windows.Forms.NumericUpDown();
      this.SecondPanelExact = new System.Windows.Forms.NumericUpDown();
      this.TableLayoutPanel.SuspendLayout();
      this.ProportionBox.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FirstPanelProportion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SecondPanelProportion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FirstPanelExact)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SecondPanelExact)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 1;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Controls.Add(this.FullSizelabel, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.ProportionBox, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.groupBox2, 0, 2);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 3;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(305, 122);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // FullSizelabel
      // 
      this.FullSizelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.FullSizelabel.AutoSize = true;
      this.FullSizelabel.Location = new System.Drawing.Point(73, 3);
      this.FullSizelabel.Name = "FullSizelabel";
      this.FullSizelabel.Size = new System.Drawing.Size(159, 13);
      this.FullSizelabel.TabIndex = 0;
      this.FullSizelabel.Text = "<Общая длина/высота = ???>";
      // 
      // ProportionBox
      // 
      this.ProportionBox.Controls.Add(this.tableLayoutPanel1);
      this.ProportionBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ProportionBox.Location = new System.Drawing.Point(3, 23);
      this.ProportionBox.Name = "ProportionBox";
      this.ProportionBox.Size = new System.Drawing.Size(299, 45);
      this.ProportionBox.TabIndex = 1;
      this.ProportionBox.TabStop = false;
      this.ProportionBox.Text = "Пропорции, %";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.tableLayoutPanel2);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(3, 74);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(299, 45);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Точные велечины";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.FirstPanelLabel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.SecondPanelLabel1, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.FirstPanelProportion, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.SecondPanelProportion, 3, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 26);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 4;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.FirstPanelLabel2, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.SecondPanelLabel2, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.FirstPanelExact, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.SecondPanelExact, 3, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(293, 26);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // FirstPanelLabel1
      // 
      this.FirstPanelLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.FirstPanelLabel1.AutoSize = true;
      this.FirstPanelLabel1.Location = new System.Drawing.Point(18, 6);
      this.FirstPanelLabel1.Name = "FirstPanelLabel1";
      this.FirstPanelLabel1.Size = new System.Drawing.Size(39, 13);
      this.FirstPanelLabel1.TabIndex = 0;
      this.FirstPanelLabel1.Text = "Левая";
      // 
      // SecondPanelLabel1
      // 
      this.SecondPanelLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.SecondPanelLabel1.AutoSize = true;
      this.SecondPanelLabel1.Location = new System.Drawing.Point(158, 6);
      this.SecondPanelLabel1.Name = "SecondPanelLabel1";
      this.SecondPanelLabel1.Size = new System.Drawing.Size(45, 13);
      this.SecondPanelLabel1.TabIndex = 1;
      this.SecondPanelLabel1.Text = "Правая";
      // 
      // FirstPanelLabel2
      // 
      this.FirstPanelLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.FirstPanelLabel2.AutoSize = true;
      this.FirstPanelLabel2.Location = new System.Drawing.Point(8, 6);
      this.FirstPanelLabel2.Name = "FirstPanelLabel2";
      this.FirstPanelLabel2.Size = new System.Drawing.Size(49, 13);
      this.FirstPanelLabel2.TabIndex = 0;
      this.FirstPanelLabel2.Text = "Верхняя";
      // 
      // SecondPanelLabel2
      // 
      this.SecondPanelLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.SecondPanelLabel2.AutoSize = true;
      this.SecondPanelLabel2.Location = new System.Drawing.Point(156, 6);
      this.SecondPanelLabel2.Name = "SecondPanelLabel2";
      this.SecondPanelLabel2.Size = new System.Drawing.Size(47, 13);
      this.SecondPanelLabel2.TabIndex = 1;
      this.SecondPanelLabel2.Text = "Нижняя";
      // 
      // FirstPanelProportion
      // 
      this.FirstPanelProportion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FirstPanelProportion.Location = new System.Drawing.Point(63, 3);
      this.FirstPanelProportion.Name = "FirstPanelProportion";
      this.FirstPanelProportion.Size = new System.Drawing.Size(80, 20);
      this.FirstPanelProportion.TabIndex = 2;
      this.FirstPanelProportion.ValueChanged += new System.EventHandler(this.FirstPanelProportion_ValueChanged);
      // 
      // SecondPanelProportion
      // 
      this.SecondPanelProportion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SecondPanelProportion.Location = new System.Drawing.Point(209, 3);
      this.SecondPanelProportion.Name = "SecondPanelProportion";
      this.SecondPanelProportion.Size = new System.Drawing.Size(81, 20);
      this.SecondPanelProportion.TabIndex = 3;
      this.SecondPanelProportion.ValueChanged += new System.EventHandler(this.SecondPanelProportion_ValueChanged);
      // 
      // FirstPanelExact
      // 
      this.FirstPanelExact.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FirstPanelExact.Location = new System.Drawing.Point(63, 3);
      this.FirstPanelExact.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.FirstPanelExact.Name = "FirstPanelExact";
      this.FirstPanelExact.Size = new System.Drawing.Size(80, 20);
      this.FirstPanelExact.TabIndex = 2;
      this.FirstPanelExact.ThousandsSeparator = true;
      this.FirstPanelExact.ValueChanged += new System.EventHandler(this.FirstPanelExact_ValueChanged);
      // 
      // SecondPanelExact
      // 
      this.SecondPanelExact.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SecondPanelExact.Location = new System.Drawing.Point(209, 3);
      this.SecondPanelExact.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
      this.SecondPanelExact.Name = "SecondPanelExact";
      this.SecondPanelExact.Size = new System.Drawing.Size(81, 20);
      this.SecondPanelExact.TabIndex = 3;
      this.SecondPanelExact.ThousandsSeparator = true;
      this.SecondPanelExact.ValueChanged += new System.EventHandler(this.SecondPanelExact_ValueChanged);
      // 
      // SpliterPositionToolWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(305, 122);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SpliterPositionToolWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Настройка разделителя";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.ProportionBox.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FirstPanelProportion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SecondPanelProportion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FirstPanelExact)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SecondPanelExact)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.Label FullSizelabel;
    private System.Windows.Forms.GroupBox ProportionBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label FirstPanelLabel1;
    private System.Windows.Forms.Label SecondPanelLabel1;
    private System.Windows.Forms.NumericUpDown FirstPanelProportion;
    private System.Windows.Forms.NumericUpDown SecondPanelProportion;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label FirstPanelLabel2;
    private System.Windows.Forms.Label SecondPanelLabel2;
    private System.Windows.Forms.NumericUpDown FirstPanelExact;
    private System.Windows.Forms.NumericUpDown SecondPanelExact;
  }
}