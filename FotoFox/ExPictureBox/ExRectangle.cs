using System;
using System.Drawing;

namespace FotoFox.ExPictureBox
{
  public class ExRectangle
  {
    private RectangleF _Rectangle;
    private int _ImageWidth;
    private int _ImageHeight;

    private const float _MIN_HEIGHT = 30;
    private const float _MIN_WIDTH = 30;

    public float CurrentZoom = 1;

    public ExRectangle(Size controlSize, int imageWidth, int imageHeight)
    {
      _Rectangle = new RectangleF(0, 0, controlSize.Width, controlSize.Height);
      _ImageWidth = imageWidth;
      _ImageHeight = imageHeight;
    }

    public void ChangeProportion(Size newControlSize)
    {
      _Rectangle.Height = _Rectangle.Width * newControlSize.Height / newControlSize.Width;
    }

    public void Zoom(float percent)
    {
      if(percent < -100 || percent > 100)
        throw new Exception("Imposible zoom percent");

      var multi = (-percent + 100) / 100;

      var newHeight = _Rectangle.Height * multi;
      var newWidth = _Rectangle.Width * multi;
      if (newWidth < _MIN_WIDTH || newHeight < _MIN_HEIGHT)
        return;

       CurrentZoom *= multi;

      _Rectangle.Width = newWidth;
      _Rectangle.Height = newHeight;

      Move(-_Rectangle.Left * (multi - 1), -_Rectangle.Top * (multi - 1));
    }


    public Rectangle GetDrawRectangle()
    {
      return new Rectangle((int)_Rectangle.X, (int)_Rectangle.Y, (int)_Rectangle.Width, (int)_Rectangle.Height);
    }

    public void Move(float byX, float byY)
    {
      var newX = _Rectangle.X - byX;
      var newY = _Rectangle.Y - byY;

      //if (newX < 0) newX = 0;
      if (newX > _ImageWidth) newX = _ImageWidth;

      //if (newY < 0) newY = 0;
      if (newY > _ImageHeight) newY = _ImageHeight;

      _Rectangle.Location = new PointF(newX, newY);
    }
  }
}