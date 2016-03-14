namespace FotoFox
{
  partial class ExportDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDialog));
      this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.ExportBtn = new System.Windows.Forms.Button();
      this.FilePathText = new System.Windows.Forms.TextBox();
      this.BrowseBtn = new System.Windows.Forms.Button();
      this.ImageFormatCMB = new System.Windows.Forms.ComboBox();
      this.SizeGB = new System.Windows.Forms.GroupBox();
      this.SizeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.HeightText = new System.Windows.Forms.NumericUpDown();
      this.WidthText = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.SizeTrackBar = new System.Windows.Forms.TrackBar();
      this.ExportProgress = new System.Windows.Forms.ProgressBar();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.ExportWorker = new System.ComponentModel.BackgroundWorker();
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.TableLayoutPanel.SuspendLayout();
      this.SizeGB.SuspendLayout();
      this.SizeTableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.HeightText)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.WidthText)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
      this.SuspendLayout();
      // 
      // TableLayoutPanel
      // 
      this.TableLayoutPanel.ColumnCount = 5;
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
      this.TableLayoutPanel.Controls.Add(this.ExportBtn, 3, 1);
      this.TableLayoutPanel.Controls.Add(this.FilePathText, 0, 1);
      this.TableLayoutPanel.Controls.Add(this.BrowseBtn, 1, 1);
      this.TableLayoutPanel.Controls.Add(this.ImageFormatCMB, 2, 1);
      this.TableLayoutPanel.Controls.Add(this.SizeGB, 0, 0);
      this.TableLayoutPanel.Controls.Add(this.ExportProgress, 0, 2);
      this.TableLayoutPanel.Controls.Add(this.CancelBtn, 4, 2);
      this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.TableLayoutPanel.Name = "TableLayoutPanel";
      this.TableLayoutPanel.RowCount = 3;
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TableLayoutPanel.Size = new System.Drawing.Size(774, 129);
      this.TableLayoutPanel.TabIndex = 0;
      // 
      // ExportBtn
      // 
      this.ExportBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.TableLayoutPanel.SetColumnSpan(this.ExportBtn, 2);
      this.ExportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ExportBtn.Image = global::FotoFox.Properties.Resources.wizard;
      this.ExportBtn.Location = new System.Drawing.Point(612, 66);
      this.ExportBtn.Name = "ExportBtn";
      this.ExportBtn.Size = new System.Drawing.Size(158, 26);
      this.ExportBtn.TabIndex = 3;
      this.ExportBtn.Text = "Создать картинку!";
      this.ExportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ExportBtn.UseVisualStyleBackColor = true;
      this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
      // 
      // FilePathText
      // 
      this.FilePathText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.FilePathText.Location = new System.Drawing.Point(3, 69);
      this.FilePathText.Name = "FilePathText";
      this.FilePathText.Size = new System.Drawing.Size(499, 20);
      this.FilePathText.TabIndex = 1;
      // 
      // BrowseBtn
      // 
      this.BrowseBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.BrowseBtn.Image = global::FotoFox.Properties.Resources.folder;
      this.BrowseBtn.Location = new System.Drawing.Point(508, 65);
      this.BrowseBtn.Name = "BrowseBtn";
      this.BrowseBtn.Size = new System.Drawing.Size(33, 28);
      this.BrowseBtn.TabIndex = 4;
      this.BrowseBtn.TabStop = false;
      this.BrowseBtn.UseVisualStyleBackColor = true;
      this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
      // 
      // ImageFormatCMB
      // 
      this.ImageFormatCMB.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ImageFormatCMB.DisplayMember = "Key";
      this.ImageFormatCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ImageFormatCMB.FormattingEnabled = true;
      this.ImageFormatCMB.Location = new System.Drawing.Point(547, 68);
      this.ImageFormatCMB.Name = "ImageFormatCMB";
      this.ImageFormatCMB.Size = new System.Drawing.Size(59, 21);
      this.ImageFormatCMB.TabIndex = 2;
      this.ImageFormatCMB.ValueMember = "Value";
      this.ImageFormatCMB.SelectedIndexChanged += new System.EventHandler(this.ImageFormatCMB_SelectedIndexChanged);
      // 
      // SizeGB
      // 
      this.TableLayoutPanel.SetColumnSpan(this.SizeGB, 5);
      this.SizeGB.Controls.Add(this.SizeTableLayoutPanel);
      this.SizeGB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizeGB.Location = new System.Drawing.Point(3, 3);
      this.SizeGB.Name = "SizeGB";
      this.SizeGB.Size = new System.Drawing.Size(768, 56);
      this.SizeGB.TabIndex = 0;
      this.SizeGB.TabStop = false;
      this.SizeGB.Text = "Размер";
      // 
      // SizeTableLayoutPanel
      // 
      this.SizeTableLayoutPanel.ColumnCount = 4;
      this.SizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
      this.SizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
      this.SizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
      this.SizeTableLayoutPanel.Controls.Add(this.HeightText, 3, 0);
      this.SizeTableLayoutPanel.Controls.Add(this.WidthText, 1, 0);
      this.SizeTableLayoutPanel.Controls.Add(this.label1, 2, 0);
      this.SizeTableLayoutPanel.Controls.Add(this.SizeTrackBar, 0, 0);
      this.SizeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizeTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
      this.SizeTableLayoutPanel.Name = "SizeTableLayoutPanel";
      this.SizeTableLayoutPanel.RowCount = 1;
      this.SizeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.SizeTableLayoutPanel.Size = new System.Drawing.Size(762, 37);
      this.SizeTableLayoutPanel.TabIndex = 0;
      // 
      // HeightText
      // 
      this.HeightText.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.HeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.HeightText.Location = new System.Drawing.Point(693, 8);
      this.HeightText.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.HeightText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.HeightText.Name = "HeightText";
      this.HeightText.Size = new System.Drawing.Size(65, 20);
      this.HeightText.TabIndex = 2;
      this.HeightText.ThousandsSeparator = true;
      this.HeightText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.HeightText.ValueChanged += new System.EventHandler(this.HeightText_ValueChanged);
      // 
      // WidthText
      // 
      this.WidthText.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.WidthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.WidthText.Location = new System.Drawing.Point(596, 8);
      this.WidthText.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.WidthText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.WidthText.Name = "WidthText";
      this.WidthText.Size = new System.Drawing.Size(65, 20);
      this.WidthText.TabIndex = 1;
      this.WidthText.ThousandsSeparator = true;
      this.WidthText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.WidthText.ValueChanged += new System.EventHandler(this.WidthText_ValueChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(667, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(19, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "на";
      // 
      // SizeTrackBar
      // 
      this.SizeTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SizeTrackBar.Location = new System.Drawing.Point(3, 3);
      this.SizeTrackBar.Maximum = 100;
      this.SizeTrackBar.Minimum = 20;
      this.SizeTrackBar.Name = "SizeTrackBar";
      this.SizeTrackBar.Size = new System.Drawing.Size(587, 31);
      this.SizeTrackBar.TabIndex = 0;
      this.SizeTrackBar.Value = 100;
      this.SizeTrackBar.ValueChanged += new System.EventHandler(this.SizeTrackBar_ValueChanged);
      // 
      // ExportProgress
      // 
      this.TableLayoutPanel.SetColumnSpan(this.ExportProgress, 4);
      this.ExportProgress.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ExportProgress.Location = new System.Drawing.Point(3, 99);
      this.ExportProgress.MarqueeAnimationSpeed = 200;
      this.ExportProgress.Name = "ExportProgress";
      this.ExportProgress.Size = new System.Drawing.Size(685, 27);
      this.ExportProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.ExportProgress.TabIndex = 7;
      // 
      // CancelBtn
      // 
      this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Enabled = false;
      this.CancelBtn.Location = new System.Drawing.Point(694, 101);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(75, 23);
      this.CancelBtn.TabIndex = 0;
      this.CancelBtn.TabStop = false;
      this.CancelBtn.Text = "Отмена";
      this.CancelBtn.UseVisualStyleBackColor = true;
      this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
      // 
      // ExportWorker
      // 
      this.ExportWorker.WorkerReportsProgress = true;
      this.ExportWorker.WorkerSupportsCancellation = true;
      this.ExportWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ExportWorker_DoWork);
      this.ExportWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ExportWorker_ProgressChanged);
      this.ExportWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ExportWorker_RunWorkerCompleted);
      // 
      // FolderBrowserDialog
      // 
      this.FolderBrowserDialog.Description = "Папка Картинки";
      // 
      // ExportDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(774, 129);
      this.Controls.Add(this.TableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ExportDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Экспорт в картинку";
      this.TableLayoutPanel.ResumeLayout(false);
      this.TableLayoutPanel.PerformLayout();
      this.SizeGB.ResumeLayout(false);
      this.SizeTableLayoutPanel.ResumeLayout(false);
      this.SizeTableLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.HeightText)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.WidthText)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.Button ExportBtn;
    private System.Windows.Forms.TextBox FilePathText;
    private System.Windows.Forms.Button BrowseBtn;
    private System.Windows.Forms.ComboBox ImageFormatCMB;
    private System.Windows.Forms.GroupBox SizeGB;
    private System.Windows.Forms.TableLayoutPanel SizeTableLayoutPanel;
    private System.Windows.Forms.NumericUpDown HeightText;
    private System.Windows.Forms.NumericUpDown WidthText;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ProgressBar ExportProgress;
    private System.Windows.Forms.TrackBar SizeTrackBar;
    private System.ComponentModel.BackgroundWorker ExportWorker;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
  }
}