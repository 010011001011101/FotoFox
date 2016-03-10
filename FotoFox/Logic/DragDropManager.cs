using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox.Logic
{
  public class DragDropManager
  {
    public static void InitForControl(Control control, Action<Image> addAction)
    {
      if(control == null || addAction == null) return;

      control.AllowDrop = true;
      control.DragDrop +=  (s, e) => _OnDragDrop(s, e, addAction);
      control.DragEnter += _OnDragEnter;
    }

    private static void _OnDragEnter(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
        ? DragDropEffects.Copy
        : DragDropEffects.None;
    }

    private static void _OnDragDrop(object sender, DragEventArgs e, Action<Image> addAction)
    {
      var image = _GetImageFromDrop(e.Data);

      if (image != null)
        addAction(image);
    }

    private static Image _GetImageFromDrop(IDataObject data)
    {
      var files = data.GetData(DataFormats.FileDrop) as string[];
      if (files.Length == 0) return null;

      try
      {
        return Image.FromFile(files[0]);
      }
      catch (Exception)
      {
        return null;
      }
    }
  }
}