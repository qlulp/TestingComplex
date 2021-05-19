using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingComplex.Controls.Pages
{
    public partial class AboutProgramPage : UserControl
    {
        public AboutProgramPage()
        {
            InitializeComponent();
        }
        

        private void logoPictureBox_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/qlulp/TestingComplex");
        }
    }
}
