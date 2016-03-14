using System;
using System.Windows.Forms;
using System.Drawing;

namespace FotoFox.Logic
{
  public class ContextMenuManager
  {
    private readonly Color _SelectColor = Color.Red;
    private readonly Color _SubSelectColor = Color.Orange;

    private readonly Control _HostControl;
    private SplitterManager _SplitterManager;
    private ImageManager _ImageManager;


    public ContextMenuManager(Control hostControl)
    {
      _HostControl = hostControl;
    }

    public void Initialize(SplitterManager splitterManager, ImageManager imageManager)
    {
      _SplitterManager = splitterManager;
      _ImageManager = imageManager;
    }

    #region Menus Propertys

    private ContextMenu _PanelContextMenu;
    public ContextMenu PanelContextMenu
    {
      get { return _PanelContextMenu ?? (_PanelContextMenu = _CreatePanelContextMenu()); }
    }
    private ContextMenu _CreatePanelContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _AddImageToContextMenu(menu);
      return menu;
    }

    private ContextMenu _ImageContextMenu;
    public ContextMenu ImageContextMenu
    {
      get { return _ImageContextMenu ?? (_ImageContextMenu = _CreateImageContextMenu()); }
    }
    private ContextMenu _CreateImageContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _RemoveImageToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _FullImageModeToContextMenu(menu);
      return menu;
    }

    private ContextMenu _SplitContextMenu;
    public ContextMenu SplitContextMenu
    {
      get { return _SplitContextMenu ?? (_SplitContextMenu = _CreateSplitContextMenu()); }
    }
    private ContextMenu _CreateSplitContextMenu()
    {
      var menu = _CreateContextMenu();
      _SplitControlToContextMenu(menu);
      return menu;
    }

    private ContextMenu _SplitPanelContextMenu;
    public ContextMenu SplitPanelContextMenu
    {
      get { return _SplitPanelContextMenu ?? (_SplitPanelContextMenu = _CreateSplitPanelContextMenu()); }
    }
    private ContextMenu _CreateSplitPanelContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _SplitControlToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _AddImageToContextMenu(menu);
      return menu;
    }

    private ContextMenu _SplitImagePanelContextMenu;
    public ContextMenu SplitImagePanelContextMenu
    {
      get { return _SplitImagePanelContextMenu ?? (_SplitImagePanelContextMenu = _CreateSplitImagePanelContextMenu()); }
    }
    private ContextMenu _CreateSplitImagePanelContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _SplitControlToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _RemoveImageToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _FullImageModeToContextMenu(menu);
      return menu;
    }

    #endregion

    #region Menu Builder

    private void _AddImageToContextMenu(ContextMenu contextMenu)
    {
      contextMenu.MenuItems.Add(
        new MenuItem("Добавить изображение", (s, e) =>
        _ImageManager.AddImage(_GetSplitterPanel(s)))
      );
    }

    private void _RemoveImageToContextMenu(ContextMenu contextMenu)
    {
      contextMenu.MenuItems.Add(
        new MenuItem("Удалить изображение",(s, e) =>
        _ImageManager.DeleteImage(_GetSplitterPanel(s)))  
      );                                 
    }

    private void _FullImageModeToContextMenu(ContextMenu contextMenu)
    {
      contextMenu.MenuItems.Add(
        new MenuItem("Растянуть оригинальное изображение",
          (s, e) => _ImageMenuAction(s, _ImageManager.SetFullImageMode))
      );  
    }

    private void _SplitControlToContextMenu(ContextMenu contextMenu)
    {
      contextMenu.MenuItems.Add(
        new MenuItem("Разделитель", new []
        {
          new MenuItem("Удалить", (s,e) =>
              _SplitterManager.DeleteSplitter(_GetSplitter(s))),
          new MenuItem("Установить 50% на 50% (1:1)", (s,e) =>
              _SplitterManager.SetProportions(_GetSplitter(s), 50)),
          new MenuItem("Установить 25% на 75% (1:4)", (s,e) =>
              _SplitterManager.SetProportions(_GetSplitter(s), 25)),
          new MenuItem("Установить 75% на 25% (4:1)", (s,e) =>
              _SplitterManager.SetProportions(_GetSplitter(s), 75)),
          new MenuItem("Установить 33.3% на 66.6% (1:2)", (s,e) =>
              _SplitterManager.SetProportions(_GetSplitter(s), 33.3)),
          new MenuItem("Установить 66.6% на 33.3% (2:1)", (s,e) =>
              _SplitterManager.SetProportions(_GetSplitter(s), 66.6)),
        })                                    
      );
    }

    private static void _AddSpliterToContextMenu(ContextMenu contextMenu)
    {
      if (contextMenu.MenuItems.Count > 0)
        contextMenu.MenuItems.Add(new MenuItem("-"));
    }

    private void _CommonToContextMenu(ContextMenu contextMenu)
    {
      contextMenu.MenuItems.AddRange(new[]
      {
        new MenuItem("Добавить горизонтальный разделитель", (s,e) => 
          _SplitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Horizontal)),
        new MenuItem("Добавить вертикальный разделитель", (s,e) =>
          _SplitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Vertical))                                   
      });
    }

    private ContextMenu _CreateContextMenu()
    {
      var cMenu = new ContextMenu();

      cMenu.Popup += (s,e) => _SetSelectionBorder(s, true);
      cMenu.Collapse += (s, e) => _SetSelectionBorder(s, false);

      return cMenu;
    }

    #endregion

    #region Border

    private void _SetSelectionBorder(object sender, bool borderVisible)
    {
      var control = _GetControl(sender);
      if(control is SplitContainer)
      {
        _SetSubBorders((control as SplitContainer), borderVisible);
        control.Refresh();
        return;
      }

      var splitPanel = _GetSplitterPanel(sender) as SplitterPanel;
      if (splitPanel == null) return;

      _SetBorders(splitPanel, borderVisible);
      splitPanel.Parent.Refresh();
    }

    private void _SetBorders(SplitterPanel panel, bool borderVisible)
    {
      _AddOnPaintEvent(panel, _BorderPaint, !borderVisible);

      var splitContainer = (SplitContainer)panel.Parent;

      _SetSubBorders(
        splitContainer.Panel1.Equals(panel)
          ? splitContainer.Panel2
          : splitContainer.Panel1,
        borderVisible);
    }

    private void _SetSubBorders(SplitterPanel panel, bool borderVisible)
    {
      var splitContainer = panel.Controls.Count > 0
        ? panel.Controls[0] as SplitContainer
        : null;

      if (splitContainer != null)
        _SetSubBorders(splitContainer, borderVisible);
      else
        _AddOnPaintEvent(panel, _SubBorderPaint, !borderVisible);
    }

    private void _SetSubBorders(SplitContainer split, bool borderVisible)
    {
      _SetSubBorders(split.Panel1, borderVisible);
      _SetSubBorders(split.Panel2, borderVisible);
    }

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

    private void _BorderPaint(object sender, PaintEventArgs e)
    {
      using (var pen = new Pen(_SelectColor, 4))
        e.Graphics.DrawRectangle(pen, e.ClipRectangle);
    }

    private void _SubBorderPaint(object sender, PaintEventArgs e)
    {
      using (var pen = new Pen(_SubSelectColor, 4))
        e.Graphics.DrawRectangle(pen, e.ClipRectangle);
    }

    #endregion

    #region utils

    private void _ImageMenuAction(object sender, Func<Panel, ExPictureBox.ExPictureBox, bool> imageActionDelegate)
    {
      var menuItem = sender as MenuItem;
      var panel = _GetSplitterPanel(sender);
      var pictureBox = _GetPictureBox(panel);

      if (menuItem == null || pictureBox == null || panel == null)
        return;

      menuItem.Checked = imageActionDelegate(panel, pictureBox);
    }

    private Panel _GetSplitterPanel(object sender)
    {
        var control = _GetControl(sender);
        var panel = control as Panel ?? control.Parent as Panel;
        while (panel != null && !_HostControl.Equals(panel) && !(panel is SplitterPanel))
            panel = panel.Parent as Panel;

        return panel;
    }

    private static ExPictureBox.ExPictureBox _GetPictureBox(Panel panel)
    {
      if (panel == null || panel.Controls.Count == 0) return null;
      return panel.Controls[0] as ExPictureBox.ExPictureBox;
    }

    private static SplitContainer _GetSplitter(object sender)
    {
        var panel = _GetControl(sender);
        while (panel != null && !(panel is SplitContainer))
            panel = panel.Parent;

        return panel as SplitContainer;
    }

    private static Control _GetControl(object sender)
    {
        ContextMenu contextMenu = null;
        if (sender is ContextMenu)
            contextMenu = sender as ContextMenu;
        else if (sender is MenuItem)
            contextMenu = (sender as MenuItem).GetContextMenu();
        if (contextMenu == null) return null;

        return contextMenu.SourceControl;
    }

    #endregion
  }
}
