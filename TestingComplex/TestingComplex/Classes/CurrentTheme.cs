using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingComplex.Classes
{
    public static class CurrentTheme
    {
        public static Color SelectedColor = Properties.Settings.Default.SelectedColor;
        public static Color WindowColor = Properties.Settings.Default.WindowColor;
        public static Color BaseColor = Properties.Settings.Default.BaseColor;
        public static Color PageColor = Properties.Settings.Default.PageColor;
    }
}
