using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoFox.Logic
{
    public class SizeManager
    {
        private readonly Panel _mainPanel;

        public SizeManager(Panel mainPanel)
        {
            _mainPanel = mainPanel;
        }

        public string GetSizeString()
        {
            return string.Format("{0} на {1}", _mainPanel.Width, _mainPanel.Height);
        }

        public string GetProportionString()
        {
            return (Convert.ToDouble(_mainPanel.Width) / Convert.ToDouble(_mainPanel.Height)).ToString("N2");
        }

        public int CalculateNewHight(int width, decimal w, decimal h)
        {
            return (int)((width / w) * h);
        }

        public int CalculateNewWidth(int height, decimal w, decimal h)
        {
            return (int)((height / h) * w);
        }
    }
}