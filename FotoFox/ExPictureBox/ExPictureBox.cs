using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FotoFox.ExPictureBox
{
  public class ExPictureBox : Panel
  {
    private Image _Image;
    private ExRectangle _VisibleRect;
    private Point _MouseStartDragPoint;
    private bool _IgnoreFirstMouseMove = true;//TODO Убрать индусизм

    public int RoundCornerR { get; private set; }
    public bool RoundCornersEnable { get; private set; }


    private bool _FullImageMode;
    public bool FullImageMode 
    {
      get { return _FullImageMode; }
      set
      {
        _FullImageMode = value;
        Invalidate();
      }
    }

    public void SetRoundCorners(bool enable, int r)
    {
      RoundCornersEnable = enable;
      RoundCornerR = r;

      if (RoundCornerR <= 0)
        RoundCornersEnable = false;

      Invalidate();
    }

    public ExPictureBox(Image image)
    {
      _Image = image;
      base.DoubleBuffered = true;
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      
      if(Size.Height == 0 || Size.Width == 0)
        return;

      if (_VisibleRect == null)
        _VisibleRect = new ExRectangle(Size, _Image.Width, _Image.Height);
      else
        _VisibleRect.ChangeProportion(Size);

      Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      DrawImage(pe.Graphics, DisplayRectangle);

      base.OnPaint(pe);
    }

    public void DrawImage(Graphics g, RectangleF dstRect, bool fixOverSize = false, float globalZoom = 1)
    {
      if (FullImageMode)
        MakeRoundCorners(g, dstRect, globalZoom, () => g.DrawImage(_Image, dstRect));
      else
      {
        var imageRect = _VisibleRect.GetDrawRectangle();
        if (fixOverSize)
        {
          if (imageRect.X > _Image.Width || imageRect.Y > _Image.Height) return;

          dstRect = _FixDstRectangle(dstRect, imageRect);
          imageRect = _FixImageRectangle(imageRect);
        }

        MakeRoundCorners(g, dstRect, globalZoom, () => g.DrawImage(_Image, dstRect, imageRect, GraphicsUnit.Pixel));
      }
    }

    private RectangleF _FixDstRectangle(RectangleF dstRect, Rectangle imageRect)
    {
      if (imageRect.X + imageRect.Width > _Image.Width)
        dstRect.Width *= (float)(_Image.Width - imageRect.X)/imageRect.Width;

      if (imageRect.Y + imageRect.Height > _Image.Height)
        dstRect.Height *= (float)(_Image.Height - imageRect.Y) / imageRect.Height;

      return dstRect;
    }

    private Rectangle _FixImageRectangle(Rectangle imageRect)
    {
      if (imageRect.X + imageRect.Width > _Image.Width)
        imageRect.Width = _Image.Width - imageRect.X;

      if (imageRect.Y + imageRect.Height > _Image.Height)
        imageRect.Height = _Image.Height - imageRect.Y;

      return imageRect;
    }

    public void MakeRoundCorners(Graphics g, RectangleF dstRect, float globalZoom, Action drawAction)
    {
      if (!RoundCornersEnable)
      {
        drawAction();
        return;
      }

      using (var path = new GraphicsPath())
      {
        var d = 2 * RoundCornerR * globalZoom;

        path.AddArc(dstRect.Right - d, dstRect.Top, d, d, 270, 90);
        path.AddArc(dstRect.Right - d, dstRect.Bottom - d, d, d, 0, 90);
        path.AddArc(dstRect.Left, dstRect.Bottom - d, d, d, 90, 90);
        path.AddArc(dstRect.Left, dstRect.Top, d, d, 180, 90);
        g.SetClip(path);

        drawAction();

        g.ResetClip();
      }
    }

    public void ResetImage(Image image)
    {
      _Image.Dispose();
      _Image = image;
      _VisibleRect = new ExRectangle(Size, _Image.Width, _Image.Height);
      _FullImageMode = false;
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);

      if (FullImageMode) return;

      _VisibleRect.Zoom((float)e.Delta / 15);
      Invalidate();
    }


    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);

      Focus();

      if (FullImageMode || e.Button != MouseButtons.Left)
        return;

      Cursor = Cursors.SizeAll;
      _MouseStartDragPoint = e.Location;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);

      ResetCursor();
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);

      if (FullImageMode || e.Button != MouseButtons.Left)
        return;

      if (_IgnoreFirstMouseMove)
      {
        _IgnoreFirstMouseMove = false;
        return;
      }

      var dX = (e.Location.X - _MouseStartDragPoint.X);
      var dY = (e.Location.Y - _MouseStartDragPoint.Y);

      _VisibleRect.Move(dX * _VisibleRect.CurrentZoom, dY * _VisibleRect.CurrentZoom);
      _MouseStartDragPoint = e.Location;

      Invalidate();
    }

    #region MaxIncreasePercent

    public float GetMaxIncreasePercent()
    {
      var imagePartSize = FullImageMode
        ? _Image.Size
        : _VisibleRect.GetDrawRectangle().Size;

      var byX = _CalculateMaxPercent(imagePartSize.Width, Size.Width);
      var byY = _CalculateMaxPercent(imagePartSize.Height, Size.Height);

      return Math.Min(byX, byY);
    }

    private static float _CalculateMaxPercent(int imageSize, int controlSize)
    {
      return controlSize < imageSize
        ? 100 * (imageSize - controlSize) / controlSize
        : 0;
    }

    #endregion

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (_Image != null)
            _Image.Dispose();
    }
  }
}