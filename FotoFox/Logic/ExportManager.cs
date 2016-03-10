using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FotoFox.Logic
{
  public class ExportManager
  {
      public static void Export(BackgroundWorker worker, Panel panel, Size imageSize, FileInfo fileInfo, ImageFormat imageFormat, float coef)
    {
      using (var bitmap = new Bitmap(imageSize.Width, imageSize.Height))
      {
        using (var graphics = Graphics.FromImage(bitmap))
        {
          graphics.CompositingMode = CompositingMode.SourceCopy;
          _Progress(worker);

          _DrawBackground(bitmap, graphics, panel);
          _Progress(worker);

          _DrawImages(worker, bitmap, graphics, panel, coef);
        }

        _SaveImage(bitmap, fileInfo, imageFormat);
        _Progress(worker);
      }
    }

    #region Background

    private static void _DrawBackground(Bitmap bitmap, Graphics graphics, Panel panel)
    {
      if (panel.BackgroundImage == null)
        _SetBackgroundColor(bitmap, graphics, panel.BackColor);
      else
        _SetBackgroundImage(bitmap, graphics, panel.BackgroundImage, panel.BackgroundImageLayout);
    }

    private static void _SetBackgroundColor(Bitmap bitmap, Graphics graphics, Color backColor)
    {
      using (var brush = new SolidBrush(backColor))
        graphics.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
    }

    private static void _SetBackgroundImage(Bitmap bitmap, Graphics graphics, Image image, ImageLayout imageLayout)
    {
      switch (imageLayout)
      {
        case ImageLayout.Tile:
          using (var brush = new TextureBrush(image))
            graphics.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
          break;
        case ImageLayout.Stretch:
          graphics.DrawImage(image, 0, 0, bitmap.Width, bitmap.Height);
          break;
        default:
          throw new Exception("Unsupported ImageLayout for BackgroundImage");
      }
    }

    #endregion

    #region Images

    private static void _DrawImages(BackgroundWorker worker, Bitmap bitmap, Graphics graphics, Panel panel, float coef)
    {
      if(panel.Controls.Count == 0)
        return;

      _DrawControl(worker, graphics, panel.Controls[0], new Rectangle(0, 0, bitmap.Width, bitmap.Height), coef);
    }

    private static void _DrawControl(BackgroundWorker worker, Graphics graphics, Control control, RectangleF rectangle, float coef)
    {
      if(control is ExPictureBox.ExPictureBox)
        _DrawExPictureBox(worker, control as ExPictureBox.ExPictureBox, graphics, rectangle);

      if(control is SplitContainer)
        _DrawSplitContainer(worker, control as SplitContainer, graphics, rectangle, coef);
    }

    private static void _DrawExPictureBox(BackgroundWorker worker, ExPictureBox.ExPictureBox exPictureBox,
      Graphics graphics, RectangleF rectangle)
    {
      exPictureBox.DrawImage(graphics, rectangle, true);

      _Progress(worker);
    }

    private static void _DrawSplitContainer(BackgroundWorker worker, SplitContainer splitContainer, Graphics graphics, RectangleF rectangle, float coef)
    {
      _DrawSplitterPanel(worker, splitContainer.Panel1, graphics, _GetSubRectangle(rectangle, splitContainer.Panel1, coef), coef);
      _DrawSplitterPanel(worker, splitContainer.Panel2, graphics, _GetSubRectangle(rectangle, splitContainer.Panel2, coef), coef);
    }

    private static void _DrawSplitterPanel(BackgroundWorker worker, SplitterPanel panel, Graphics graphics, RectangleF rectangle, float coef)
    {
      if(panel.BackColor != Color.Transparent)
        using (var brush = new SolidBrush(panel.BackColor))
          graphics.FillRectangle(brush, rectangle);
        
      if (panel.Controls.Count != 0)
        _DrawControl(worker, graphics, panel.Controls[0], rectangle, coef);
    }

    private static RectangleF _GetSubRectangle(RectangleF rectangle, SplitterPanel panel, float coef)
    {
        var newRectangle = new RectangleF(
            rectangle.X + panel.Location.X * coef,
            rectangle.Y + panel.Location.Y * coef,
            (panel.Size.Width + 2) * coef,
            (panel.Size.Height + 2) * coef);

        if (Math.Abs(newRectangle.Height - rectangle.Height) < 3)
            newRectangle.Height = rectangle.Height;

        if (Math.Abs(newRectangle.Width - rectangle.Width) < 3)
            newRectangle.Width = rectangle.Width;

        return newRectangle;
    }

    #endregion

    #region Save

    private static void _SaveImage(Bitmap bitmap, FileInfo fileInfo, ImageFormat imageFormat)
    {
      if(fileInfo.Exists)
        fileInfo.Delete();

      bitmap.Save(fileInfo.FullName, imageFormat);
    }

    #endregion

    private static void _Progress(BackgroundWorker worker)
    {
      worker.ReportProgress(1);
    }
  }
}