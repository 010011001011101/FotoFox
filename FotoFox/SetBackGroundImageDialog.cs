using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox
{
  public partial class SetBackGroundImageDialog : Form
  {
    private Control _ControlForBackground;

    public static void ShowDialog(Control controlForBackground, IWin32Window parent)
    {
      if (controlForBackground == null) return;

      using (var dialog = new SetBackGroundImageDialog())
      {
        dialog._ControlForBackground = controlForBackground;
        dialog.ShowDialog(parent);
      }
    }

    public SetBackGroundImageDialog()
    {
      InitializeComponent();
    }

    private void ChooseBtn_Click(object sender, EventArgs e)
    {
      if(_TryChangeBackground(_ControlForBackground))
        Close();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      using (var dialog = new OpenFileDialog{ CheckFileExists = true, Title = @"Открыть картинку" })
        if (dialog.ShowDialog(this) == DialogResult.OK)
          FileNameTB.Text = dialog.FileName;
    }

    private bool _TryChangeBackground(Control panel)
    {
      var image = _TryGetImage();
      if (image == null) return false;

      if (panel.BackgroundImage != null)
        panel.BackgroundImage.Dispose();

      panel.BackgroundImageLayout = StretchRB.Checked ? ImageLayout.Stretch : ImageLayout.Tile;
      panel.BackgroundImage = image;

      return true;
    }

    private Image _TryGetImage()
    {
      try
      {
        return Image.FromFile(FileNameTB.Text);
      }
      catch (Exception)
      {
        MessageBox.Show(string.Format("Не удалось прочитать файл {0} как картинку", FileNameTB.Text),
          @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return null;
      }
    }
  }
}
