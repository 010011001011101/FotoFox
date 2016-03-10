using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox
{
  public partial class SetBackGroundImageDialog : Form
  {
    private Panel _Panel;

    public static void ShowDialog(Panel panel, IWin32Window parentWindow)
    {
      if(panel == null) return;

      using (var dialog = new SetBackGroundImageDialog())
      {
        dialog._Panel = panel;
        dialog.ShowDialog(parentWindow);
      }
    }

    public SetBackGroundImageDialog()
    {
      InitializeComponent();
    }

    private void ChooseBtn_Click(object sender, EventArgs e)
    {
      if(_TryChangeBackground(_Panel))
        Close();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      using (var dialog = new OpenFileDialog
      {
        CheckFileExists = true,
        Title = "Открыть картинку"

      })
      {
        if (dialog.ShowDialog(this) != DialogResult.OK)
          return;

        FileNameTB.Text = dialog.FileName;
      }
    }

    private bool _TryChangeBackground(Panel panel)
    {
      Image image;
      try
      {
        image = Image.FromFile(FileNameTB.Text);
      }
      catch (Exception)
      {
        MessageBox.Show(string.Format("Не удалось прочитать файл {0} как картинку", FileNameTB.Text),
          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      if (panel.BackgroundImage != null)
      {
        panel.BackgroundImage.Dispose();
        panel.BackgroundImage = null;
      }
      panel.BackgroundImageLayout = StretchRB.Checked ? ImageLayout.Stretch : ImageLayout.Tile;
      panel.BackgroundImage = image;
      return true;
    }
  }
}
