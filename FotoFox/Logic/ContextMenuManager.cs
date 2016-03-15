using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace FotoFox.Logic
{
  public class ContextMenuManager
  {
    private readonly Control _HostControl;
    private SplitterManager _SplitterManager;
    private ImageManager _ImageManager;
    private Control _ContextMenuSourceControl;


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

      menu.Opening += Menu_Opening;
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

      menu.Opening += Menu_Opening;
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

      menu.Opening += Menu_Opening;
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

      menu.Opening += Menu_Opening;
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
      _FullImageModeToContextMenu(menu);
      _RemoveImageToContextMenu(menu);
      
      menu.Opening += Menu_Opening;
      return menu;
    }

    private void Menu_Opening(object sender, CancelEventArgs e)
    {
      _ContextMenuSourceControl = ((ContextMenuStrip)sender).SourceControl as Control;
    }

    #endregion

    #region Menu Builder

    private void _AddImageToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.Add(
        new ToolStripMenuItem("Добавить изображение", Properties.Resources.image_Add, (s, e) =>
        _ImageManager.AddImage(_GetSplitterPanel(s)))
      );
    }

    private void _RemoveImageToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.Add(
        new ToolStripMenuItem("Удалить изображение", Properties.Resources.image_Del, (s, e) =>
        _ImageManager.DeleteImage(_GetSplitterPanel(s)))  
      );                                 
    }

    private void _FullImageModeToContextMenu(ContextMenuStrip contextMenu)
    {
      contextMenu.Items.Add(
        new ToolStripMenuItem("Растянуть оригинальное изображение", Properties.Resources.resize,
          (s, e) => _ImageMenuAction(s, _ImageManager.SetFullImageMode))
      );  
    }

    private void _SplitControlToContextMenu(ContextMenuStrip contextMenu)
    {
      var subMenu = new ToolStripMenuItem("Разделитель", null, new[]
      {
        new ToolStripMenuItem("Установить вручную", Properties.Resources.pencil, _ManualSplitSet),
        new ToolStripMenuItem("Установить [50% - 50%]", Properties.Resources._11, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 50)),
        new ToolStripMenuItem("Установить [33% - 66%]", Properties.Resources._12, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 33.3)),
        new ToolStripMenuItem("Установить [66% - 33%]", Properties.Resources._21, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 66.6)),
        new ToolStripMenuItem("Установить [25% - 75%]", Properties.Resources._14, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 25)),
        new ToolStripMenuItem("Установить [75% - 25%]", Properties.Resources._41, (s,e) =>
          _SplitterManager.SetProportions(_GetSplitter(s), 75))
      });

      subMenu.DropDownItems.Add(new ToolStripSeparator());

      subMenu.DropDownItems.Add(new ToolStripMenuItem("Удалить", Properties.Resources.remove, (s,e) =>
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
        new ToolStripMenuItem("Добавить горизонтальный разделитель", Properties.Resources.split_Hor, (s,e) => 
          _SplitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Horizontal)),
        new ToolStripMenuItem("Добавить вертикальный разделитель", Properties.Resources.split_Vert, (s,e) =>
          _SplitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Vertical))                                   
      });
    }

    private ContextMenuStrip _CreateContextMenu()
    {
      var cMenu = new ContextMenuStrip();

      cMenu.Opening += (s, e) => _SplitterManager.SetSelectionBorder(((ContextMenuStrip)s).SourceControl as Control, true);
      cMenu.Closing += (s, e) => _SplitterManager.SetSelectionBorder(_GetControl(s), false);

      return cMenu;
    }

    #endregion

    #region utils

    private void _ImageMenuAction(object sender, Func<Panel, ExPictureBox.ExPictureBox, bool> imageActionDelegate)
    {
      var menuItem = sender as ToolStripMenuItem;
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

    private SplitContainer _GetSplitter(object sender)
    {
      var panel = _GetControl(sender);
      while (panel != null && !(panel is SplitContainer))
          panel = panel.Parent;

      return panel as SplitContainer;
    }

    private Control _GetControl(object sender)
    {
      // ибо нормального спсоба узнать контрол источник контекстного меню, в котором есть подменю - нельзя... ппц товарищи
      return _ContextMenuSourceControl;
    }

    #endregion
  }
}
