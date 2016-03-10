using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FotoFox.Logic;

namespace FotoFox
{
    public partial class MainForm : Form
    {
        private ContextMenuManager _ContextMenuManager;
        private SplitterManager _SplitterManager;
        private ImageManager _ImageManager;
        private SizeManager _SizeManager;

        public MainForm()
        {
            InitializeComponent();

            _InitializeManagers();
            _InitializeCommonControls();

            MainPanel.ContextMenu = _ContextMenuManager.PanelContextMenu;
            DragDropManager.InitForControl(MainPanel, image => _ImageManager.AddImage(MainPanel, image));
        }

        private void _InitializeManagers()
        {
            _SizeManager = new SizeManager(MainPanel);
            _ImageManager = new ImageManager(MainPanel);
            _SplitterManager = new SplitterManager(MainPanel);
            _ContextMenuManager = new ContextMenuManager(_SplitterManager, _ImageManager, MainPanel);
        }

        protected override void OnLoad(EventArgs eventArgs)
        {
            base.OnLoad(eventArgs);
            _DisplaySizeLabels();
            Resize += (s, e) => _DisplaySizeLabels();
        }

        #region Common Controls

        private void _InitializeCommonControls()
        {
            SplitterWidthTB.Text = _SplitterManager.SplittersWidth.ToString(CultureInfo.InvariantCulture);
            _RefreshSplittersBackColor();
            _RefreshSplittersNewPanelColor();
        }

        private void _RefreshSplittersBackColor()
        {
            BackColorP.BackColor = MainPanel.BackColor;
        }

        private void _RefreshSplittersNewPanelColor()
        {
            NewPanelColorP.BackColor = _SplitterManager.SplittersNewPanelColor;
        }

        private void SplitterWidthText_Validating(object sender, CancelEventArgs e)
        {
            int width;
            if(int.TryParse(SplitterWidthTB.Text, out width)) return;

            e.Cancel = true;
            ValidationErrorProvider.SetError(SplitterWidthTB, "Растояние должно быть целым числом");
        }

        private void SplitterWidthText_Validated(object sender, EventArgs e)
        {
            ValidationErrorProvider.SetError(SplitterWidthTB, string.Empty);

            _SplitterManager.SplittersWidth = int.Parse(SplitterWidthTB.Text);
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            var backColor = _AskForColor();
            if(!backColor.HasValue) return;

            if(MainPanel.BackgroundImage != null)
            {
                var image = MainPanel.BackgroundImage;
                MainPanel.BackgroundImage = null;
                BackColorP.BackgroundImage = null;
                image.Dispose();
            }
            
            MainPanel.BackColor = backColor.Value;
            _RefreshSplittersBackColor();
        }

        private void BackGroundColorBtn_Click(object sender, EventArgs e)
        {
          SetBackGroundImageDialog.ShowDialog(MainPanel, this);
          BackColorP.BackgroundImage = MainPanel.BackgroundImage;
          BackColorP.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void NewPanelColorBtn_Click(object sender, EventArgs e)
        {
          var newPanelColor = _AskForColor();
          if (!newPanelColor.HasValue) return;

          _SplitterManager.SplittersNewPanelColor = newPanelColor.Value;
          _RefreshSplittersNewPanelColor();
        }

        private void TransparentPanelCB_CheckedChanged(object sender, EventArgs e)
        {
          _SplitterManager.SplittersNewPanelColor = TransparentPanelCB.Checked
            ? Color.Transparent
            : NewPanelColorP.BackColor;
          NewPanelColorBtn.Enabled = !TransparentPanelCB.Checked;
        }

        private void SplitterWidthTB_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
          {
            ValidateChildren();
            e.SuppressKeyPress = true;
          }
        }

        private Color? _AskForColor()
        {
          using (var dialog = new ColorDialog { AnyColor = true })
            return dialog.ShowDialog(this) == DialogResult.OK
                ? (Color?)dialog.Color
                : null;
        }

        #endregion

        #region Size

        private void _DisplaySizeLabels()
        {
            Text = string.Format("FotoFox ({0})", _SizeManager.GetSizeString());
            SizeL.Text = _SizeManager.GetSizeString();
            Size2L.Text = string.Format("({0})", _SizeManager.GetProportionString());
        }

        private void SizeHelpBtn_Click(object sender, EventArgs e)
        {
            var text = string.Format("Соотношение отображается одним числом, которое равно X:Y => X деленый на Y.{0}" +
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
            MessageBox.Show(text, "Справка по соотношениям", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetProportionBtn_Click(object sender, EventArgs e)
        {
            var newMainpanelSize = _CalculateNewSize();

            _ResizeToNewSize(newMainpanelSize);
        }

        private Size _CalculateNewSize()
        {
            var newHight = ByWidthRB.Checked
                ? _SizeManager.CalculateNewHight(MainPanel.Size.Width, WidthN.Value, HightN.Value)
                : MainPanel.Size.Height;

            var newWidth = ByHightRB.Checked
                ? _SizeManager.CalculateNewWidth(MainPanel.Size.Height, WidthN.Value, HightN.Value)
                : MainPanel.Size.Width;

            return new Size(newWidth, newHight);
        }

        private void _ResizeToNewSize(Size newMainpanelSize)
        {
            Size += newMainpanelSize - MainPanel.Size;
        }

        #endregion

        #region Export

        private void ExportBtn_Click(object sender, EventArgs e)
        {
          if (MainPanel.Controls.Count == 0)
            return;

          ExportDialog.ShowDialog(MainPanel, this);
        }

        #endregion
    }
}
