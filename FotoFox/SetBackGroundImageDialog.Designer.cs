namespace FotoFox
{
  partial class SetBackGroundImageDialog
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
      this.FileNameTB = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.StretchRB = new System.Windows.Forms.RadioButton();
      this.TileRB = new System.Windows.Forms.RadioButton();
      this.ChooseBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.BrowseBtn = new System.Windows.Forms.Button();
      this.TableLayoutPanel.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 2;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Controls.Add(this.FileNameTB, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.BrowseBtn, 1, 0);
      this.TableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.ChooseBtn, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 1, 2);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 3;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(281, 86);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // FileNameTB
      // 
      this.FileNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.FileNameTB.Location = new System.Drawing.Point(3, 6);
      this.FileNameTB.Name = "FileNameTB";
      this.FileNameTB.Size = new System.Drawing.Size(208, 20);
      this.FileNameTB.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      this.TableLayoutPanel.SetColumnSpan(this.flowLayoutPanel1, 2);
      this.flowLayoutPanel1.Controls.Add(this.StretchRB);
      this.flowLayoutPanel1.Controls.Add(this.TileRB);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 25);
      this.flowLayoutPanel1.TabIndex = 2;
      // 
      // StretchRB
      // 
      this.StretchRB.AutoSize = true;
      this.StretchRB.Checked = true;
      this.StretchRB.Location = new System.Drawing.Point(3, 3);
      this.StretchRB.Name = "StretchRB";
      this.StretchRB.Size = new System.Drawing.Size(77, 17);
      this.StretchRB.TabIndex = 0;
      this.StretchRB.Text = "Растянуть";
      this.StretchRB.UseVisualStyleBackColor = true;
      // 
      // TileRB
      // 
      this.TileRB.AutoSize = true;
      this.TileRB.Location = new System.Drawing.Point(86, 3);
      this.TileRB.Name = "TileRB";
      this.TileRB.Size = new System.Drawing.Size(80, 17);
      this.TileRB.TabIndex = 1;
      this.TileRB.Text = "Замостить";
      this.TileRB.UseVisualStyleBackColor = true;
      // 
      // ChooseBtn
      // 
      this.ChooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ChooseBtn.Location = new System.Drawing.Point(146, 60);
      this.ChooseBtn.Name = "ChooseBtn";
      this.ChooseBtn.Size = new System.Drawing.Size(65, 23);
      this.ChooseBtn.TabIndex = 1;
      this.ChooseBtn.Text = "Выбрать";
      this.ChooseBtn.UseVisualStyleBackColor = true;
      this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
      // 
      // CancelBtn
      // 
      this.CancelBtn.Location = new System.Drawing.Point(217, 60);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(60, 23);
      this.CancelBtn.TabIndex = 2;
      this.CancelBtn.TabStop = false;
      this.CancelBtn.Text = "Отмена";
      this.CancelBtn.UseVisualStyleBackColor = true;
      this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
      // 
      // BrowseBtn
      // 
      this.BrowseBtn.Image = global::FotoFox.Properties.Resources.folder_magnify_8999;
      this.BrowseBtn.Location = new System.Drawing.Point(217, 3);
      this.BrowseBtn.Name = "BrowseBtn";
      this.BrowseBtn.Size = new System.Drawing.Size(31, 26);
      this.BrowseBtn.TabIndex = 1;
      this.BrowseBtn.TabStop = false;
      this.BrowseBtn.UseVisualStyleBackColor = true;
      this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
      // 
      // SetBackGroundImageDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(281, 86);
      this.ControlBox = false;
      this.Controls.Add(this.TableLayoutPanel);
      this.Name = "SetBackGroundImageDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Выбор картинки";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.TextBox FileNameTB;
    private System.Windows.Forms.Button BrowseBtn;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.RadioButton StretchRB;
    private System.Windows.Forms.RadioButton TileRB;
    private System.Windows.Forms.Button ChooseBtn;
    private System.Windows.Forms.Button CancelBtn;
  }
}