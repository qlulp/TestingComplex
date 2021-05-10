using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingComplex.Classes;

namespace TestingComplex.Controls.Pages
{
    public partial class CurrentTestPage : UserControl
    {
        public CurrentTestPage()
        {
            InitializeComponent();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            var label = (Guna.UI.WinForms.GunaLabel)sender;
            // label.ForeColor = Color.FromArgb(95, 54, 255);
            label.ForeColor = Color.FromArgb(97, 156, 250);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = (Guna.UI.WinForms.GunaLabel)sender;
            label.ForeColor = Color.DimGray;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            // Следующий вопрос
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
