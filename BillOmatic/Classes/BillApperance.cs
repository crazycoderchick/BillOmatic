using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOmatic.Classes
{
    [Serializable]
    public class BillAppearance
    {
        private Color _backgroundColor;
        private Color _fontColor;

        public Color fontColor
        {
            get { return _fontColor; }
            set { _fontColor = value; }
        }

        public Color backgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }
    }
}
