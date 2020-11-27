using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BakeryManagement
{
    class StyleTheme
    {
        public struct RGBs
        {
            public static Color color1 = Color.FromArgb(223, 246, 253); //nhạt
            public static Color color2 = Color.FromArgb(178, 221, 237); //xanh nhạt
            public static Color color3 = Color.FromArgb(203, 190, 171); //xám nhạt
            public static Color color4 = Color.FromArgb(100, 208, 254); //xanh đậm
            public static Color color5 = Color.FromArgb(54, 39, 39); //nâu đen
        }
        public struct FontChildForm
        {
            public static Font activateFont = new Font("Source Serif Pro Black", 12F, (FontStyle)(FontStyle.Bold | FontStyle.Underline), GraphicsUnit.Point, ((byte)(0)));
            public static Font disableFont = new Font("Source Serif Pro SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

        }
        public struct FontUserControl
        {
            public static Font defaultFont = new Font("Source Serif Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            public static Font activateFont = new Font("Source Serif Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
    }
}
