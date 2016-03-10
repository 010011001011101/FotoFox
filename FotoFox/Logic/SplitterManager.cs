using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox.Logic
{
    public class SplitterManager
    {
        private readonly List<SplitContainer> _Splits = new List<SplitContainer>();
        private readonly Panel _MainPanel;

        public ContextMenuManager ContextMenuManager { get; set; }
        public ImageManager ImageManager { get; set; }

        public SplitterManager(Panel mainPanel)
        {
            _MainPanel = mainPanel;
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
            _Splits.ForEach(split =>
            {
              if (_IsLastbranch(split.Panel1))
                split.Panel1.BackColor = SplittersNewPanelColor;
              if (_IsLastbranch(split.Panel2))
                split.Panel2.BackColor = SplittersNewPanelColor;
            });
        }
        
        private static bool _IsLastbranch(Control panel)
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
                ImageManager.DeleteImage(panel);
            panel.Controls.Add(newSplit);
            panel.ContextMenu = null;
            if(!Equals(_MainPanel, panel))
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
              ContextMenu = ContextMenuManager.SplitContextMenu,
              Panel1 = {
                  ContextMenu = ContextMenuManager.SplitPanelContextMenu,
                  BackColor = SplittersNewPanelColor
              },
              Panel2 = {
                  ContextMenu = ContextMenuManager.SplitPanelContextMenu,
                  BackColor = SplittersNewPanelColor
              }
          };

          DragDropManager.InitForControl(splitContainer.Panel1, image => ImageManager.AddImage(splitContainer.Panel1, image));
          DragDropManager.InitForControl(splitContainer.Panel2, image => ImageManager.AddImage(splitContainer.Panel2, image));

          return splitContainer;
        }

      public void DeleteSplitter(Panel panel)
        {
            if (panel == null) return;

            if(DialogResult.Yes !=  MessageBox.Show(
                @"Подтвердите удаление разделения со всеми картинками",
                @"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;

            var split = GetSplit(panel);
            if(split == null) return;

            _Splits.Remove(split);
            if(_MainPanel.Equals(split.Parent))
              split.Parent.ContextMenu = ContextMenuManager.PanelContextMenu;
            else
            {
              split.Parent.ContextMenu = ContextMenuManager.SplitPanelContextMenu;
              split.Parent.BackColor = SplittersNewPanelColor;
            }
            split.Parent.Controls.Remove(split);
            split.Dispose();
        }


        private SplitContainer GetSplit(Control control)
        {
            if (control == null) return null;

            return control is SplitterPanel
                ? (control as SplitterPanel).Parent as SplitContainer
                : GetSplit(control.Parent);
        }

        public void SetProportions(SplitContainer split, double splitterDistance)
        {
            var now = (split.Orientation == Orientation.Horizontal
                          ? split.Height
                          : split.Width) - split.SplitterWidth;

            split.SplitterDistance = Convert.ToInt32(now * splitterDistance / 100);
        }
    }
}