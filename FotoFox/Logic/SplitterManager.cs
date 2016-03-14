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
        Margin = new Padding(0),
        Dock = DockStyle.Fill,
        Orientation = orientation,
        SplitterWidth = SplittersWidth,
        BackColor = Color.Transparent,
        ContextMenuStrip = _ContextMenuManager.SplitContextMenu,
        Panel1 = {
          ContextMenuStrip = _ContextMenuManager.SplitPanelContextMenu,
            BackColor = SplittersNewPanelColor
        },
        Panel2 = {
          ContextMenuStrip = _ContextMenuManager.SplitPanelContextMenu,
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
        split.Parent.ContextMenuStrip = _ContextMenuManager.PanelContextMenu;
      else
      {
        split.Parent.ContextMenuStrip = _ContextMenuManager.SplitPanelContextMenu;
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

    #region Utils

    public Panel GetSplitterPanel(Control control)
    {
      var panel = control as Panel ?? control.Parent as Panel;
      while (panel != null && !_HostControl.Equals(panel) && !(panel is SplitterPanel))
        panel = panel.Parent as Panel;

      return panel;
    }

    public static IEnumerable<SplitterPanel> GetAllNotParentPanels(Control panel)
    {
      var childContainer = GetChildContainer(panel);

      if (childContainer == null)
      {
        if (panel is SplitterPanel)
          yield return panel as SplitterPanel;
      }
      else
        foreach (var childPanel in GetAllNotParentPanels(childContainer))
          yield return childPanel;
    }

    public static IEnumerable<SplitterPanel> GetAllNotParentPanels(SplitContainer container)
    {
      foreach (var childPanel in GetAllNotParentPanels(container.Panel1))
        yield return childPanel;

      foreach (var childPanel in GetAllNotParentPanels(container.Panel2))
        yield return childPanel;
    }

    public static SplitContainer GetChildContainer(Control panel)
    {
      return panel.Controls.Count > 0
        ? panel.Controls[0] as SplitContainer
        : null;
    }

    #endregion

    #region Drawing

    private static void _AddOnPaintEvent(Control control, PaintEventHandler drawDelegate, bool remove = false)
    {
      var controlToSubscribe = control.Controls.Count > 0
                                 ? control.Controls[0]
                                 : control;

      if (remove)
        controlToSubscribe.Paint -= drawDelegate;
      else
        controlToSubscribe.Paint += drawDelegate;
    }

    #region Border Color

    private const int SelectWidth = 4;
    private readonly Color _SelectColor = Color.Red;
    private readonly Color _SubSelectColor = Color.Orange;


    public void SetSelectionBorder(Control control, bool borderVisible)
    {
      if (control is SplitContainer)
      {
        _SetSubBorders(GetAllNotParentPanels(control as SplitContainer), borderVisible);
        control.Refresh();
        return;
      }

      var splitPanel = GetSplitterPanel(control) as SplitterPanel;
      if (splitPanel == null) return;

      _SetBorders(splitPanel, borderVisible);
      splitPanel.Parent.Refresh();
    }

    private void _SetBorders(SplitterPanel panel, bool borderVisible)
    {
      _AddOnPaintEvent(panel, _BorderPaint, !borderVisible);

      var splitContainer = (SplitContainer)panel.Parent;
      var otherPanel = splitContainer.Panel1.Equals(panel)
                         ? splitContainer.Panel2
                         : splitContainer.Panel1;

      _SetSubBorders(GetAllNotParentPanels(otherPanel), borderVisible);
    }

    private void _SetSubBorders(IEnumerable<SplitterPanel> panels, bool borderVisible)
    {
      foreach (var panel in panels)
        _AddOnPaintEvent(panel, _SubBorderPaint, !borderVisible);
    }

    private void _BorderPaint(object sender, PaintEventArgs e)
    {
      using (var pen = new Pen(_SelectColor, SelectWidth))
        e.Graphics.DrawRectangle(pen, e.ClipRectangle);
    }

    private void _SubBorderPaint(object sender, PaintEventArgs e)
    {
      using (var pen = new Pen(_SubSelectColor, SelectWidth))
        e.Graphics.DrawRectangle(pen, e.ClipRectangle);
    }

    #endregion

    #endregion
  }
}