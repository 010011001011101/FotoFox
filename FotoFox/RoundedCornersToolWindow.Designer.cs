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
      this.R = new System.Windows.Forms.NumericUpDown();
      this.TableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.TableLayoutPanel.Controls.Add(this.EnableCB, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.label1, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.R, 1, 1);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 2;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(174, 65);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // EnableCB
      // 
      this.EnableCB.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.EnableCB.AutoSize = true;
      this.TableLayoutPanel.SetColumnSpan(this.EnableCB, 2);
      this.EnableCB.Location = new System.Drawing.Point(40, 4);
      this.EnableCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.EnableCB.Name = "EnableCB";
      this.EnableCB.Size = new System.Drawing.Size(94, 21);
      this.EnableCB.TabIndex = 0;
      this.EnableCB.Text = "Включить";
      this.EnableCB.UseVisualStyleBackColor = true;
      this.EnableCB.CheckedChanged += new System.EventHandler(this._OnValueChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 39);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "R :";
      // 
      // R
      // 
      this.R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.R.Location = new System.Drawing.Point(40, 36);
      this.R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.R.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.R.Name = "R";
      this.R.Size = new System.Drawing.Size(130, 22);
      this.R.TabIndex = 3;
      this.R.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.R.ValueChanged += new System.EventHandler(this._OnValueChanged);
      // 
      // RoundedCornersToolWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(174, 65);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RoundedCornersToolWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Округление углов";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.CheckBox EnableCB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown R;
  }
}