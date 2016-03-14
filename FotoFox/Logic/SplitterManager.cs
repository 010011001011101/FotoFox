using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FotoFox.Logic
{
  public class SplitterManager
  {
    private readonly List<SplitContainer> _Splits = new List<SplitContainer>();
    private readonly Control _HostControl;
    private ContextMenuManager _ContextMenuManager;
    private ImageManager _ImageManager;


    public SplitterManager(Control hostControl)
    {
      _HostControl = hostControl;
    }

    public void Initialize(ContextMenuManager contextMenuManager, ImageManager imageManager)
    {
      _ContextMenuManager = contextMenuManager;
      _ImageManager = imageManager;
    }

    #region Width

    private int _SplittersWidth = 7;
    public int SplittersWidth
    {
      get { return _SplittersWidth; }
      set
      {
        _SplittersWidth = value;
        _UpdateWidth();
      }
    }

    private void _UpdateWidth()
    {
      _Splits.ForEach(split =>
          split.SplitterWidth = SplittersWidth);
    }

    #endregion

    #region NewPanelColor

    private Color _SplittersNewPanelColor = Color.White;
    public Color SplittersNewPanelColor
    {
      get { return _SplittersNewPanelColor; }
      set
      {
        _SplittersNewPanelColor = value;
        _UpdateNewPanelColor();
      }
    }

    private void _UpdateNewPanelColor()
    {
      foreach (var panel in from split in _Splits
                            from panel in new[] { split.Panel1, split.Panel2 }
                            where _IsLastBranch(panel)
                            select panel)
        panel.BackColor = SplittersNewPanelColor;
    }
        
    private static bool _IsLastBranch(Control panel)
    {
      return panel.Controls.Count == 0 ||
             !(panel.Controls[0] is SplitContainer);
    }

    #endregion

    public void AddSplitter(Panel panel, Orientation orientation)
    {
      if (panel == null) return;

      var newSplit = _CreateSplit(orientation);

      if (panel.Controls.Count > 0)
        _ImageManager.DeleteImage(panel);
      panel.Controls.Add(newSplit);
      panel.ContextMenu = null;
      if (!Equals(_HostControl, panel))
        panel.BackColor = Color.Transparent;

      SetProportions(newSplit, 50);

      _Splits.Add(newSplit);
    }

    private SplitContainer _CreateSplit(Orientation orientation)
    {
      var splitContainer = new SplitContainer
      {
        Dock = DockStyle.Fill,
        Orientation = orientation,
        SplitterWidth = SplittersWidth,
        BackColor = Color.Transparent,
        ContextMenu = _ContextMenuManager.SplitContextMenu,
        Panel1 = {
            ContextMenu = _ContextMenuManager.SplitPanelContextMenu,
            BackColor = SplittersNewPanelColor
        },
        Panel2 = {
            ContextMenu = _ContextMenuManager.SplitPanelContextMenu,
            BackColor = SplittersNewPanelColor
        }
      };

      DragDropManager.InitForControl(splitContainer.Panel1, image => _ImageManager.AddImage(splitContainer.Panel1, image));
      DragDropManager.InitForControl(splitContainer.Panel2, image => _ImageManager.AddImage(splitContainer.Panel2, image));

      return splitContainer;
    }

    public void DeleteSplitter(SplitContainer split)
    {
      if (split == null) return;

      if(DialogResult.Yes !=  MessageBox.Show(
          @"Подтвердите удаление разделения со всеми картинками",
          @"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
          return;

      _Splits.Remove(split);
      if (_HostControl.Equals(split.Parent))
        split.Parent.ContextMenu = _ContextMenuManager.PanelContextMenu;
      else
      {
        split.Parent.ContextMenu = _ContextMenuManager.SplitPanelContextMenu;
        split.Parent.BackColor = SplittersNewPanelColor;
      }
      split.Parent.Controls.Remove(split);
      split.Dispose();
    }

    public void SetProportions(SplitContainer split, double splitterDistance)
    {
      var now = (split.Orientation == Orientation.Horizontal ? split.Height : split.Width)
        - split.SplitterWidth;

      split.SplitterDistance = Convert.ToInt32(now * splitterDistance / 100);
    }
  }
}