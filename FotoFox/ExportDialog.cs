using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FotoFox.Logic;

namespace FotoFox
{
  public partial class ExportDialog : Form
  {
    private const string _DEFAULT_FILE_NAME = "FoxImage";
    private const float _DEFAULTMAX_INCREASE_PERCENT = 1000;


    private Panel _Panel;

    private int _DefaultHeight;
    private int _DefaultWidth;
    private decimal _DefaultProportion;

    private int _MaxHeight;
    private int _MaxWidth;

    private bool _IgnoreSizeChangesEvents;

    public static void ShowDialog(Panel panel, IWin32Window parentWindow)
    {
      if (panel == null) return;

      using (var dialog = new ExportDialog())
      {
        dialog._Panel = panel;
        dialog._Initialize();
        dialog.ShowDialog(parentWindow);
      }
    }

    #region Initialize

    public ExportDialog()
    {
      InitializeComponent();
    }

    private void _Initialize()
    {
      _DefaultHeight = _Panel.Height;
      _DefaultWidth = _Panel.Width;
      _DefaultProportion = (decimal)_DefaultHeight / _DefaultWidth;

      _IgnoreSizeChangesEvents = true;
      HeightText.Value = _DefaultHeight;
      WidthText.Value = _DefaultWidth;
      _IgnoreSizeChangesEvents = false;

      var maxIncreasePercent = (int)_GetMaxIncreasePercent(_Panel);
      SizeTrackBar.Maximum += maxIncreasePercent;

      _MaxHeight = (int)((decimal)_DefaultHeight * SizeTrackBar.Maximum / 100);
      _MaxWidth = (int)((decimal)_DefaultWidth * SizeTrackBar.Maximum / 100);

      FilePathText.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), _DEFAULT_FILE_NAME);
      _InitializeImageFormat();
    }

    private void _InitializeImageFormat()
    {
      ImageFormatCMB.Items.AddRange(new object[]
      {
        new KeyValuePair<string, ImageFormat>("JPEG", ImageFormat.Jpeg),
        new KeyValuePair<string, ImageFormat>("PNG", ImageFormat.Png),
        new KeyValuePair<string, ImageFormat>("BMP", ImageFormat.Bmp)
      });

      ImageFormatCMB.SelectedIndex = 0;
    }

    private static float _GetMaxIncreasePercent(Panel panel)
    {
      if (panel.Controls.Count == 0)
        return _DEFAULTMAX_INCREASE_PERCENT;
      var inerControl = panel.Controls[0];

      if (inerControl is ExPictureBox.ExPictureBox)
        return (inerControl as ExPictureBox.ExPictureBox).GetMaxIncreasePercent();

      if (inerControl is SplitContainer)
      {
        var panel1MaxPercent = _GetMaxIncreasePercent((inerControl as SplitContainer).Panel1);
        var panel2MaxPercent = _GetMaxIncreasePercent((inerControl as SplitContainer).Panel2);
        return Math.Min(panel1MaxPercent, panel2MaxPercent);
      }

      return 0;
    }

    #endregion

    #region Size Change

    private void SizeTrackBar_ValueChanged(object sender, EventArgs e)
    {
      _SizeChangeAction(() =>
      {
        WidthText.Value = (int)((decimal)_DefaultWidth * SizeTrackBar.Value / 100);
        HeightText.Value = (int)((decimal)_DefaultHeight * SizeTrackBar.Value / 100);
      });
    }

    private void HeightText_ValueChanged(object sender, EventArgs e)
    {
      _SizeChangeAction(() => WidthText.Value = (int)(HeightText.Value / _DefaultProportion));
    }

    private void WidthText_ValueChanged(object sender, EventArgs e)
    {
      _SizeChangeAction(() => HeightText.Value = (int)(WidthText.Value*_DefaultProportion));
    }

    private void _SizeChangeAction(Action action)
    {
      if (_IgnoreSizeChangesEvents) return;
      _IgnoreSizeChangesEvents = true;

      action();

      _CheckMaxSize();
      _IgnoreSizeChangesEvents = false;
    }

    private void _CheckMaxSize()
    {
      if (HeightText.Value > _MaxHeight || WidthText.Value > _MaxWidth)
      {
        MessageBox.Show(string.Format("Выбранны размер ({0} на {1}) превышает максимальный допустимый ({2} на {3}).{4}Некоторая часть изображения будет растянута.",
          WidthText.Value, HeightText.Value, _MaxWidth, _MaxHeight, Environment.NewLine),
          "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        HeightText.ForeColor = Color.Red;
        WidthText.ForeColor = Color.Red;
      }
      else if (HeightText.ForeColor == Color.Red || WidthText.ForeColor == Color.Red)
       {
         HeightText.ResetForeColor();
         WidthText.ResetForeColor();
       }
    }

    #endregion

    #region File path

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
        _UpdateFilePath(FolderBrowserDialog.SelectedPath);
    }

    private void _UpdateFilePath(string selectedPath)
    {
      string fileName = null;
      try
      {
        fileName = Path.GetFileName(FilePathText.Text);
      }
      catch (Exception)
      {
      }

      FilePathText.Text = Path.Combine(selectedPath, fileName ?? _DEFAULT_FILE_NAME);
      _UpdateExtension();
    }

    private void ImageFormatCMB_SelectedIndexChanged(object sender, EventArgs e)
    {
      _UpdateExtension();
    }

    private void _UpdateExtension()
    {
      string newPath;
      try
      {
        newPath = Path.ChangeExtension(FilePathText.Text, _GetExtension());
      }
      catch (Exception)
      {
        return;
      }

      FilePathText.Text = newPath;
    }

    private string _GetExtension()
    {
      var format = ((KeyValuePair<string, ImageFormat>) ImageFormatCMB.SelectedItem).Value;

      if (ImageFormat.Bmp.Equals(format))
        return ".bmp";
      if (ImageFormat.Jpeg.Equals(format))
        return ".jpg";
      if (ImageFormat.Png.Equals(format))
        return ".png";

      return string.Empty;
    }

    #endregion

    #region Export

    private class ExportParams
    {
      public Panel Panel { get; private set; }
      public FileInfo FileInfo { get; private set; }
      public ImageFormat ImageFormat { get; private set; }
      public Size Size { get; private set; }
      public float Coef { get; private set; }


      public ExportParams(Panel panel, FileInfo fileInfo, ImageFormat imageFormat, Size size, float coef)
      {
        Panel = panel;
        Size = size;
        FileInfo = fileInfo;
        ImageFormat = imageFormat;
        Coef = coef;
      }
    }

    private void ExportBtn_Click(object sender, EventArgs e)
    {
        var fileInfo = new FileInfo(FilePathText.Text);
        if (!_CheckFilePath(fileInfo)) return;

        var exportParams = new ExportParams(
            _Panel,
            fileInfo,
            ((KeyValuePair<string, ImageFormat>) ImageFormatCMB.SelectedItem).Value,
            new Size((int) WidthText.Value, (int) HeightText.Value),
            (float)Math.Min(WidthText.Value / _DefaultWidth, HeightText.Value / _DefaultHeight));

        _OnStartExport();
        ExportWorker.RunWorkerAsync(exportParams);
    }

    private bool _CheckFilePath(FileInfo fileInfo)
    {
      if (!fileInfo.Directory.Exists)
      {
        MessageBox.Show("Указанной папки не существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }

      if (fileInfo.Exists)
        return DialogResult.Yes ==
          MessageBox.Show("Указанный файл уже существует. Перезаписать?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      return true;
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
      ExportWorker.CancelAsync();
    }

    private void _OnStartExport()
    {
      BrowseBtn.Enabled = FilePathText.Enabled = ImageFormatCMB.Enabled = ExportBtn.Enabled = SizeGB.Enabled = false;
      CancelBtn.Enabled = true;
      ExportProgress.Maximum = _GetImagesCount(_Panel) + 3;
      Text += " (Экспортируется...)";
    }

    private void _OnEndExport()
    {
      BrowseBtn.Enabled = FilePathText.Enabled = ImageFormatCMB.Enabled = ExportBtn.Enabled = SizeGB.Enabled = true;
      CancelBtn.Enabled = false;
      ExportProgress.Value = 0;
      Text = Text.Replace(" (Экспортируется...)", string.Empty);
    }

    private static int _GetImagesCount(Panel panel)
    {
      if (panel.Controls.Count == 0)
        return 0;
      var inerControl = panel.Controls[0];

      if (inerControl is ExPictureBox.ExPictureBox)
        return 1;

      if (inerControl is SplitContainer)
      {
        var panel1Count = _GetImagesCount((inerControl as SplitContainer).Panel1);
        var panel2Count = _GetImagesCount((inerControl as SplitContainer).Panel2);
        return panel1Count + panel2Count;
      }

      return 0;
    }

    #region Worker

    private void ExportWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      ExportProgress.Value++;
    }

    private void ExportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      _OnEndExport();

      if(e.Error != null)
      {
        MessageBox.Show(e.Error.Message, "Ошибка Экспорта!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if(!e.Cancelled)
        MessageBox.Show("Картинка успешно создана!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ExportWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var parameters = e.Argument as ExportParams;
      var worker = sender as BackgroundWorker;

      ExportManager.Export(worker, parameters.Panel, parameters.Size, parameters.FileInfo, parameters.ImageFormat, parameters.Coef);

      if (worker.CancellationPending)
        e.Cancel = true;
    }

    #endregion

    #endregion
  }
}
