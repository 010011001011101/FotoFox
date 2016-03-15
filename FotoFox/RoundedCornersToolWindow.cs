using System;
using System.Windows.Forms;

namespace FotoFox
{
  public partial class RoundedCornersToolWindow : Form
  {
    private readonly ExPictureBox.ExPictureBox _PictureBox;
    private bool _CanReactOnValueChange;


    public static void ShowForPictureBox(ExPictureBox.ExPictureBox pictureBox)
    {
      if (pictureBox == null) return;

      using (var window = new RoundedCornersToolWindow(pictureBox))
        window.ShowDialog(pictureBox);
    }

    public RoundedCornersToolWindow()
    {
      InitializeComponent();
    }

    private RoundedCornersToolWindow(ExPictureBox.ExPictureBox pictureBox)
      : this()
    {
      _PictureBox = pictureBox;
      _InitFromPictureBox();
    }

    private void _InitFromPictureBox()
    {
      EnableCB.Checked = _PictureBox.RoundCornersEnable;
      R.Value = _PictureBox.RoundCornerR;

      _CanReactOnValueChange = true;
    }

    private void _OnValueChanged(object sender, EventArgs e)
    {
      if (!_CanReactOnValueChange) return;

      _PictureBox.SetRoundCorners(EnableCB.Checked, (int)R.Value);
    }
  }
}
