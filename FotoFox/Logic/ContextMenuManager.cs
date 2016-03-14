using System;
using System.Windows.Forms;
using System.Drawing;

namespace FotoFox.Logic
{
  public class ContextMenuManager
  {
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

    private ContextMenuStrip _PanelContextMenu;
    public ContextMenuStrip PanelContextMenu
    {
      get { return _PanelContextMenu ?? (_PanelContextMenu = _CreatePanelContextMenu()); }
    }
    private ContextMenuStrip _CreatePanelContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _AddImageToContextMenu(menu);
      return menu;
    }

    private ContextMenuStrip _ImageContextMenu;
    public ContextMenuStrip ImageContextMenu
    {
      get { return _ImageContextMenu ?? (_ImageContextMenu = _CreateImageContextMenu()); }
    }
    private ContextMenuStrip _CreateImageContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _FullImageModeToContextMenu(menu);
      _RemoveImageToContextMenu(menu);
      return menu;
    }

    private ContextMenuStrip _SplitContextMenu;
    public ContextMenuStrip SplitContextMenu
    {
      get { return _SplitContextMenu ?? (_SplitContextMenu = _CreateSplitContextMenu()); }
    }
    private ContextMenuStrip _CreateSplitContextMenu()
    {
      var menu = _CreateContextMenu();
      _SplitControlToContextMenu(menu);
      return menu;
    }

    private ContextMenuStrip _SplitPanelContextMenu;
    public ContextMenuStrip SplitPanelContextMenu
    {
      get { return _SplitPanelContextMenu ?? (_SplitPanelContextMenu = _CreateSplitPanelContextMenu()); }
    }
    private ContextMenuStrip _CreateSplitPanelContextMenu()
    {
      var menu = _CreateContextMenu();
      _CommonToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _SplitControlToContextMenu(menu);
      _AddSpliterToContextMenu(menu);
      _AddImageToContextMenu(menu);
      return menu;
    }

    private ContextMenuStrip _SplitImagePanelContextMenu;
    public ContextMenuStrip SplitImagePanelContextMenu
    {
      get { return _SplitImagePanelContextMenu ?? (_SplitImagePanelContextMenu = _CreateSplitImagePanelContextMenu()); }
    }
    private ContextMenuStrip _CreateSplitImagePanelContextMenu()
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

    private void _AddImageToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.Add(
        new ToolStripMenuItem("Добавить изображение", null, (s, e) =>
        _ImageManager.AddImage(_GetSplitterPanel(s)))
      );
    }

    private void _RemoveImageToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.Add(
        new ToolStripMenuItem("Удалить изображение", Properties.Resources.remove, (s, e) =>
        _ImageManager.DeleteImage(_GetSplitterPanel(s)))  
      );                                 
    }

    private void _FullImageModeToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.Add(
        new ToolStripMenuItem("Растянуть оригинальное изображение", null,
          (s, e) => _ImageMenuAction(s, _ImageManager.SetFullImageMode))
      );  
    }

    private void _SplitControlToContextMenu(ContextMenuStrip contextMenu)
    {
      var subMenu = new ToolStripMenuItem("Разделитель", null, new[]
      {
        new ToolStripMenuItem("Установить вручную", null, _ManualSplitSet),
        new ToolStripMenuItem("Установить 50% на 50% (1:1)", null, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 50)),
        new ToolStripMenuItem("Установить 25% на 75% (1:4)", null, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 25)),
        new ToolStripMenuItem("Установить 75% на 25% (4:1)", null, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 75)),
        new ToolStripMenuItem("Установить 33.3% на 66.6% (1:2)", null, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 33.3)),
        new ToolStripMenuItem("Установить 66.6% на 33.3% (2:1)", null, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 66.6))
      });

      subMenu.DropDownItems.Add(new ToolStripSeparator());

      subMenu.DropDownItems.Add(new ToolStripMenuItem("Удалить", null, (s,e) =>
              _SplitterManager.DeleteSplitter(_GetSplitter(s))));

      contextMenu.Items.Add(subMenu);
    }

    private void _ManualSplitSet(object sender, EventArgs e)
    {
      var c = _GetControl(sender);
      _SplitterManager.SetSelectionBorder(c, true);
      SpliterPositionToolWindow.ShowForSplit(_GetSplitter(sender));
      _SplitterManager.SetSelectionBorder(c, false);
    }

    private static void _AddSpliterToContextMenu(ContextMenuStrip contextMenu)
    {
      if (contextMenu.Items.Count > 0)
        contextMenu.Items.Add(new ToolStripSeparator());
    }

    private void _CommonToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.AddRange(new[]
      {
        new ToolStripMenuItem("Добавить горизонтальный разделитель", null, (s,e) => 
          _SplitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Horizontal)),
        new ToolStripMenuItem("Добавить вертикальный разделитель", null, (s,e) =>
          _SplitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Vertical))                                   
      });
    }

    private ContextMenuStrip _CreateContextMenu()
    {
      var cMenu = new ContextMenuStrip();

      //cMenu.Popup += (s, e) => _SplitterManager.SetSelectionBorder(_GetControl(s), true);
      //cMenu.Collapse += (s, e) => _SplitterManager.SetSelectionBorder(_GetControl(s), false);

      return cMenu;
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
      return _SplitterManager.GetSplitterPanel(_GetControl(sender));
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
      if (sender is ContextMenuStrip)
         return (sender as ContextMenuStrip).SourceControl;

      if (sender is ToolStripItem)
        return _GetControl((sender as ToolStripItem).GetCurrentParent());

      if (sender is ToolStripDropDown)
        return _GetControl((sender as ToolStripDropDown).OwnerItem);

      return null;
    }

    #endregion
  }
}
