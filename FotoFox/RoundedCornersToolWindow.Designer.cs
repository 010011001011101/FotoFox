namespace FotoFox
{
  partial class RoundedCornersToolWindow
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
      this.EnableCB = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.A = new System.Windows.Forms.NumericUpDown();
      this.B = new System.Windows.Forms.NumericUpDown();
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 4;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.TableLayoutPanel.Controls.Add(this.EnableCB, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.label1, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.label2, 2, 1);
      this.TableLayoutPanel.Controls.Add(this.A, 1, 1);
      this.TableLayoutPanel.Controls.Add(this.B, 3, 1);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 2;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(189, 53);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // EnableCB
      // 
      this.EnableCB.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.EnableCB.AutoSize = true;
      this.TableLayoutPanel.SetColumnSpan(this.EnableCB, 4);
      this.EnableCB.Location = new System.Drawing.Point(57, 3);
      this.EnableCB.Name = "EnableCB";
      this.EnableCB.Size = new System.Drawing.Size(75, 17);
      this.EnableCB.TabIndex = 0;
      this.EnableCB.Text = "Включить";
      this.EnableCB.UseVisualStyleBackColor = true;
      this.EnableCB.CheckedChanged += new System.EventHandler(this._OnValueChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "A :";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(98, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "B :";
      // 
      // A
      // 
      this.A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.A.Location = new System.Drawing.Point(30, 28);
      this.A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.A.Name = "A";
      this.A.Size = new System.Drawing.Size(61, 20);
      this.A.TabIndex = 3;
      this.A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.A.ValueChanged += new System.EventHandler(this._OnValueChanged);
      // 
      // B
      // 
      this.B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.B.Location = new System.Drawing.Point(124, 28);
      this.B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.B.Name = "B";
      this.B.Size = new System.Drawing.Size(62, 20);
      this.B.TabIndex = 4;
      this.B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.B.ValueChanged += new System.EventHandler(this._OnValueChanged);
      // 
      // RoundedCornersToolWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(189, 53);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RoundedCornersToolWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Округление углов";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.CheckBox EnableCB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown A;
    private System.Windows.Forms.NumericUpDown B;
  }
}