using System;
using System.Linq;
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
    private const string DefaultFileName = "FoxImage";
    private const float DefaultmaxIncreasePercent = 1000;

    private Control _ImageHostControl;

    private int _DefaultHeight;
    private int _DefaultWidth;
    private decimal _DefaultProportion;

    private int _MaxHeight;
    private int _MaxWidth;

    public static void ShowDialog(Control imageHostControl, IWin32Window parentWindow)
    {
      if (imageHostControl == null) return;

      using (var dialog = new ExportDialog())
      {
        dialog._ImageHostControl = imageHostControl;
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
      _DefaultHeight = _ImageHostControl.Height;
      _DefaultWidth = _ImageHostControl.Width;
      _DefaultProportion = (decimal)_DefaultHeight / _DefaultWidth;

      SizeTrackBar.Maximum += (int)_GetMaxIncreasePercent(_ImageHostControl);

      _MaxHeight = (int)((decimal)_DefaultHeight * SizeTrackBar.Maximum / 100);
      _MaxWidth = (int)((decimal)_DefaultWidth * SizeTrackBar.Maximum / 100);

      _SizeChangeAction(() =>
      {
        HeightText.Value = _DefaultHeight;
        WidthText.Value = _DefaultWidth;
      });

      FilePathText.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), DefaultFileName);
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

    private static float _GetMaxIncreasePercent(Control control)
    {
      return _GetAllExPictureBox(control).
              Select(pb => pb.GetMaxIncreasePercent()).
              DefaultIfEmpty(DefaultmaxIncreasePercent).
              Min();
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

    private bool _IgnoreSizeChangesEvents;
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
          @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        HeightText.ForeColor = 
        WidthText.ForeColor = Color.Red;
      }
      else
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

      FilePathText.Text = Path.Combine(selectedPath, fileName ?? DefaultFileName);
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

    private void ExportBtn_Click(object sender, EventArgs e)
    {
        var fileInfo = new FileInfo(FilePathText.Text);
        if (!_CheckFilePath(fileInfo)) return;

        var exportParams = new ExportManager.ExportParams(
            _ImageHostControl,
            fileInfo,
            ((KeyValuePair<string, ImageFormat>) ImageFormatCMB.SelectedItem).Value,
            new Size((int) WidthText.Value, (int) HeightText.Value),
            (float)Math.Min(WidthText.Value / _DefaultWidth, HeightText.Value / _DefaultHeight));

        _OnStartExport();
        ExportWorker.RunWorkerAsync(exportParams);
    }

    private static bool _CheckFilePath(FileInfo fileInfo)
    {
      if (!fileInfo.Directory.Exists)
      {
        MessageBox.Show(@"Указанной папки не существует!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }

      if (fileInfo.Exists)
        return DialogResult.Yes ==
          MessageBox.Show(@"Указанный файл уже существует. Перезаписать?", @"Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
      ExportProgress.Maximum = _GetImagesCount(_ImageHostControl) + 3;
      Text += @" (Экспортируется...)";
    }

    private void _OnEndExport()
    {
      BrowseBtn.Enabled = FilePathText.Enabled = ImageFormatCMB.Enabled = ExportBtn.Enabled = SizeGB.Enabled = true;
      CancelBtn.Enabled = false;
      ExportProgress.Value = 0;
      Text = Text.Replace(" (Экспортируется...)", string.Empty);
    }

    private static int _GetImagesCount(Control control)
    {
      return _GetAllExPictureBox(control).Count();
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
        MessageBox.Show(e.Error.Message, @"Ошибка Экспорта!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if(!e.Cancelled)
        MessageBox.Show(@"Картинка успешно создана!", @"Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ExportWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var parameters = (ExportManager.ExportParams)e.Argument;
      var worker = (BackgroundWorker)sender;

      ExportManager.Export(worker, parameters);

      if (worker.CancellationPending)
        e.Cancel = true;
    }

    #endregion

    #endregion

    private static IEnumerable<ExPictureBox.ExPictureBox> _GetAllExPictureBox(Control control)
    {
      if (control.Controls.Count == 0)
        yield break;

      var inerControl = control.Controls[0];

      if (inerControl is ExPictureBox.ExPictureBox)
        yield return (inerControl as ExPictureBox.ExPictureBox);

      if (inerControl is SplitContainer)
      {
        foreach (var pictureBox in _GetAllExPictureBox((inerControl as SplitContainer).Panel1))
          yield return pictureBox;

        foreach (var pictureBox in _GetAllExPictureBox((inerControl as SplitContainer).Panel2))
          yield return pictureBox;
      }
    }
  }
}
