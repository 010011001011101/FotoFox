using System;
using System.Windows.Forms;
using System.Drawing;

namespace FotoFox.Logic
{
    public class ContextMenuManager
    {
        private readonly SplitterManager _splitterManager;
        private readonly ImageManager _imageManager;
        private readonly Panel _mainPanel;

        public Color SelectColor { get; set; }
        public Color SubSelectColor { get; set; }

        #region Menus Propertys

        private ContextMenu _panelContextMenu;
        public ContextMenu PanelContextMenu
        {
            get { return _panelContextMenu ?? (_panelContextMenu = CreatePanelContextMenu()); }
        }
        private ContextMenu CreatePanelContextMenu()
        {
            var menu = CreateContextMenu();
            CommonToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            AddImageToContextMenu(menu);
            return menu;
        }

        private ContextMenu _imageContextMenu;
        public ContextMenu ImageContextMenu
        {
            get { return _imageContextMenu ?? (_imageContextMenu = CreateImageContextMenu()); }
        }
        private ContextMenu CreateImageContextMenu()
        {
            var menu = CreateContextMenu();
            CommonToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            RemoveImageToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            FullImageModeToContextMenu(menu);
            return menu;
        }

      private ContextMenu _splitContextMenu;
        public ContextMenu SplitContextMenu
        {
            get { return _splitContextMenu ?? (_splitContextMenu = CreateSplitContextMenu()); }
        }
        private ContextMenu CreateSplitContextMenu()
        {
            var menu = CreateContextMenu();
            SplitControlToContextMenu(menu);
            return menu;
        }

        private ContextMenu _splitPanelContextMenu;
        public ContextMenu SplitPanelContextMenu
        {
            get { return _splitPanelContextMenu ?? (_splitPanelContextMenu = CreateSplitPanelContextMenu()); }
        }
        private ContextMenu CreateSplitPanelContextMenu()
        {
            var menu = CreateContextMenu();
            CommonToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            SplitControlToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            AddImageToContextMenu(menu);
            return menu;
        }

        private ContextMenu _splitImagePanelContextMenu;
        public ContextMenu SplitImagePanelContextMenu
        {
            get { return _splitImagePanelContextMenu ?? (_splitImagePanelContextMenu = CreateSplitImagePanelContextMenu()); }
        }
        private ContextMenu CreateSplitImagePanelContextMenu()
        {
            var menu = CreateContextMenu();
            CommonToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            SplitControlToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            RemoveImageToContextMenu(menu);
            AddSpliterToContextMenu(menu);
            FullImageModeToContextMenu(menu);
            return menu;
        }

        #endregion

        public ContextMenuManager(SplitterManager splitterManager, ImageManager imageManager, Panel mainPanel)
        {
            _imageManager = imageManager;
            _imageManager.ContextMenuManager = this;

            _splitterManager = splitterManager;
            _splitterManager.ContextMenuManager = this;
            _splitterManager.ImageManager = _imageManager;

            SelectColor = Color.Red;
            SubSelectColor = Color.Orange;

            _mainPanel = mainPanel;
        }

        #region Menu Builder

        private void AddImageToContextMenu(ContextMenu contextMenu)
        {
            contextMenu.MenuItems.Add(
                new MenuItem("Добавить изображение", (s, e) =>
                _imageManager.AddImage(_GetSplitterPanel(s)))                                     
            );
        }

        private void RemoveImageToContextMenu(ContextMenu contextMenu)
        {
          contextMenu.MenuItems.Add(
            new MenuItem("Удалить изображение",
              (s, e) => _ImageMenuAction(s, (p, pb) => _imageManager.DeleteImage(p)))
          );                                 
        }

        private void FullImageModeToContextMenu(ContextMenu contextMenu)
        {
          contextMenu.MenuItems.Add(
            new MenuItem("Растянуть оригинальное изображение",
              (s, e) => _ImageMenuAction(s, _imageManager.SetFullImageMode))
          );  
        }

        private void SplitControlToContextMenu(ContextMenu contextMenu)
        {
            contextMenu.MenuItems.Add(
                new MenuItem("Разделитель", new []
                    {
                        new MenuItem("Удалить", (s,e) =>
                            _splitterManager.DeleteSplitter(_GetSplitter(s).Panel1)),
                        new MenuItem("Установить 50% на 50% (1:1)", (s,e) =>
                            _splitterManager.SetProportions(_GetSplitter(s), 50)),
                        new MenuItem("Установить 25% на 75% (1:4)", (s,e) =>
                            _splitterManager.SetProportions(_GetSplitter(s), 25)),
                        new MenuItem("Установить 75% на 25% (4:1)", (s,e) =>
                            _splitterManager.SetProportions(_GetSplitter(s), 75)),
                        new MenuItem("Установить 33.3% на 66.6% (1:2)", (s,e) =>
                            _splitterManager.SetProportions(_GetSplitter(s), 33.3)),
                        new MenuItem("Установить 66.6% на 33.3% (2:1)", (s,e) =>
                            _splitterManager.SetProportions(_GetSplitter(s), 66.6)),
                    })                                    
            );
        }

        private void AddSpliterToContextMenu(ContextMenu contextMenu)
        {
          if (contextMenu.MenuItems.Count > 0)
            contextMenu.MenuItems.Add(new MenuItem("-"));
        }

        private void CommonToContextMenu(ContextMenu contextMenu)
        {
            contextMenu.MenuItems.AddRange(new[]
            {
                new MenuItem("Добавить горизонтальный разделитель", (s,e) => 
                    _splitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Horizontal)),
                new MenuItem("Добавить вертикальный разделитель", (s,e) =>
                    _splitterManager.AddSplitter(_GetSplitterPanel(s), Orientation.Vertical))                                   
            });
        }

        private ContextMenu CreateContextMenu()
        {
            var cMenu = new ContextMenu();

            cMenu.Popup += (s,e) => SetSelectionBorder(s, true);
            cMenu.Collapse += (s, e) => SetSelectionBorder(s, false);

            return cMenu;
        }

        #endregion

        #region Border

        private void SetSelectionBorder(object sender, bool borderVisible)
        {
            var control = _GetControl(sender);
            if(control is SplitContainer)
            {
                SetSubBorders((control as SplitContainer), borderVisible);
                control.Refresh();
                return;
            }

            var splitPanel = _GetSplitterPanel(sender) as SplitterPanel;
            if (splitPanel == null) return;

            SetBorders(splitPanel, borderVisible);
            splitPanel.Parent.Refresh();
        }

        private void SetBorders(SplitterPanel panel, bool borderVisible)
        {
            AddOnPaintEvent(panel, BorderPaint, !borderVisible);

            var splitContainer = (SplitContainer)panel.Parent;

            SetSubBorders(
                splitContainer.Panel1.Equals(panel)
                    ? splitContainer.Panel2
                    : splitContainer.Panel1,
                borderVisible);
        }

        private void SetSubBorders(SplitterPanel panel, bool borderVisible)
        {
            var splitContainer = panel.Controls.Count > 0
                ? panel.Controls[0] as SplitContainer
                : null;

            if (splitContainer != null)
                SetSubBorders(splitContainer, borderVisible);
            else
                AddOnPaintEvent(panel, SubBorderPaint, !borderVisible);

        }

        private void SetSubBorders(SplitContainer split, bool borderVisible)
        {
            SetSubBorders(split.Panel1, borderVisible);
            SetSubBorders(split.Panel2, borderVisible);
        }

        private static void AddOnPaintEvent(Control control, PaintEventHandler drawDelegate, bool remove = false)
        {
            var controlToSubscribe = control.Controls.Count > 0
                ? control.Controls[0]
                : control;

            if (remove)
                controlToSubscribe.Paint -= drawDelegate;
            else
                controlToSubscribe.Paint += drawDelegate;
        }

        private void BorderPaint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(SelectColor, 4))
                e.Graphics.DrawRectangle(pen, e.ClipRectangle);
        }

        private void SubBorderPaint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(SubSelectColor, 4))
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
            while (panel != null && !_mainPanel.Equals(panel) && !(panel is SplitterPanel))
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
