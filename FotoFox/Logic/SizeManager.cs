using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox.Logic
{
  public class SizeManager
  {
    private readonly Control _MainControl;

    public SizeManager(Control mainControl)
    {
      _MainControl = mainControl;
    }

    public string SizeString
    {
      get { return string.Format("{0} на {1}", _MainControl.Width, _MainControl.Height); }
    }

    public string ProportionString
    {
      get { return ((double) _MainControl.Width/_MainControl.Height).ToString("N2"); }
    }

    public string HelpString
    {
      get
      {
        return string.Format("Соотношение отображается одним числом, которое равно X:Y => X деленый на Y.{0}" +
                             "Краткая таблица соответствий :{0}" +
                             "1:1 - 1.00{0}" +
                             "4:3 - 1.33{0}" +
                             "3:4 - 0.75{0}" +
                             "1:2 - 0.5{0}" +
                             "2:1 - 2{0}" +
                             "6:9 - 0.66{0}" +
                             "9:6 - 1.5{0}" +
                             "16:9 - 1.78{0}",
                             Environment.NewLine);
      }
    }

    public int CalculateNewHight(int width, decimal w, decimal h)
    {
      return (int)((width / w) * h);
    }

    public int CalculateNewWidth(int height, decimal w, decimal h)
    {
      return (int)((height / h) * w);
    }

    public Size CalculateNewSize(bool byWidth, bool byHight, decimal widthProp, decimal hightProp)
    {
      var prop = widthProp/hightProp;

      return new Size(
        byHight
          ? (int)(_MainControl.Size.Height * prop)
          : _MainControl.Size.Width,
        byWidth
          ? (int)(_MainControl.Size.Width / prop)
          : _MainControl.Size.Height);
    }
  }
}