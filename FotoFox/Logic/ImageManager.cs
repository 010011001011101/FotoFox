using System.Drawing;
using System.Windows.Forms;

namespace FotoFox.Logic
{
  public class ImageManager
  {
    private readonly Control _HostControl;
    private ContextMenuManager _ContextMenuManager;

    public int DefaultRoundCornerA { get; set; }
    public int DefaultRoundCornerB { get; set; }
    public bool DefaultCornersEnable { get; set; }


    public ImageManager(Control hostControl)
    {
      _HostControl = hostControl;

      DefaultRoundCornerA = 6;
      DefaultRoundCornerB = 12;
      DefaultCornersEnable = true;
    }

    public void Initialize(ContextMenuManager contextMenuManager)
    {
      _ContextMenuManager = contextMenuManager;
    }

    public void AddImage(Control control, Image image = null)
    {
      if (control == null) return;

        if (image == null) image = _AskForImage();
        if (image == null) return;

        var isMainPanel = _HostControl.Equals(control);
        control.Controls.Add(_CreatePictureBox(image, isMainPanel));
        control.ContextMenu = null;
    }

    public void DeleteImage(Control control)
    {
      if (control == null || control.Controls.Count == 0) return;
      var pictureBox = control.Controls[0] as ExPictureBox.ExPictureBox;
      if (pictureBox == null) return;

      var isMainPanel = _HostControl.Equals(control);
      control.ContextMenuStrip = isMainPanel
          ? _ContextMenuManager.CreatePanelContextMenu()
          : _ContextMenuManager.CreateSplitPanelContextMenu();
      control.Controls.Remove(pictureBox);

      pictureBox.Dispose();
    }

    public bool SetFullImageMode(Panel panel, ExPictureBox.ExPictureBox pictureBox)
    {
      return pictureBox.FullImageMode = !pictureBox.FullImageMode;
    }

    public bool SetRoundCornersMode(Panel panel, ExPictureBox.ExPictureBox pictureBox)
    {
      RoundedCornersToolWindow.ShowForPictureBox(pictureBox);

      return pictureBox.RoundCornersEnable;
    }

    private Control _CreatePictureBox(Image image, bool fromMainPanel)
    {
      var pictureBox = new ExPictureBox.ExPictureBox(image)
      {
          Dock = DockStyle.Fill,
      };

      pictureBox.SetRoundCorners(DefaultCornersEnable, DefaultRoundCornerA, DefaultRoundCornerB);

      pictureBox.ContextMenuStrip = fromMainPanel
        ? _ContextMenuManager.CreateImageContextMenu(pictureBox)
        : _ContextMenuManager.CreateSplitImagePanelContextMenu(pictureBox);
      
      DragDropManager.InitForControl(pictureBox, pictureBox.ResetImage);

      return pictureBox;
    }

    private Image _AskForImage()
    {
      using (var dialog = new OpenFileDialog{ CheckFileExists = true, Title = @"Открыть картинку" })
        try
        {
          if (dialog.ShowDialog(_HostControl) == DialogResult.OK)
            return Image.FromFile(dialog.FileName);
        }
        catch
        {
        }

      return null;
    }
  }
}