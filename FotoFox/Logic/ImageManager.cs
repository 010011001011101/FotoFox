using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox.Logic
{
    public class ImageManager
    {
        private readonly Panel _mainPanel;

        public ContextMenuManager ContextMenuManager { get; set; }

        public ImageManager(Panel mainPanel)
        {
            _mainPanel = mainPanel;
        }

        public void AddImage(Panel panel, Image image = null)
        {
            if (panel == null) return;

            if (image == null) image = AskForImage();
            if (image == null) return;

            var isMainPanel = _mainPanel.Equals(panel);
            panel.Controls.Add(CreatePictureBox(image, isMainPanel));
            panel.ContextMenu = null;
        }

        public bool DeleteImage(Panel panel)
        {
          if (panel == null || panel.Controls.Count == 0) return false;
          var pictureBox = panel.Controls[0] as ExPictureBox.ExPictureBox;
          if (pictureBox == null) return false;

          var isMainPanel = _mainPanel.Equals(panel);
          panel.ContextMenu = isMainPanel
              ? ContextMenuManager.PanelContextMenu
              : ContextMenuManager.SplitPanelContextMenu;
          panel.Controls.Remove(pictureBox);
          pictureBox.Dispose();

          return false;
        }

        public bool SetFullImageMode(Panel panel, ExPictureBox.ExPictureBox pictureBox)
        {
          pictureBox.FullImageMode = !pictureBox.FullImageMode;
          return pictureBox.FullImageMode;
        }

        private Control CreatePictureBox(Image image, bool fromMainPanel)
        {
          var pictureBox = new ExPictureBox.ExPictureBox(image)
            {
                Dock = DockStyle.Fill,
                ContextMenu = fromMainPanel
                    ? ContextMenuManager.ImageContextMenu
                    : ContextMenuManager.SplitImagePanelContextMenu
            };

          DragDropManager.InitForControl(pictureBox, pictureBox.ResetImage);

          return pictureBox;
        }

        private Image AskForImage()
        {
            using (var dialog = new OpenFileDialog
            { 
                CheckFileExists = true,
                Title = "Открыть картинку"

            })
            {
                if (dialog.ShowDialog(_mainPanel.Parent) != DialogResult.OK)
                    return null;
                try
                {
                    return Image.FromFile(dialog.FileName);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}