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

namespace TestingComplex.Controls
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();

            BackColor = CurrentTheme.PageColor;
            minimizeButton.OnHoverBaseColor = CurrentTheme.SelectedColor;
            // 192; 192; 255
            minimizeButton.BaseColor = CurrentTheme.BaseColor;
            closeButton.OnHoverBaseColor = CurrentTheme.SelectedColor;
            closeButton.BaseColor = CurrentTheme.BaseColor;
            BackColor = CurrentTheme.PageColor;
        }

        private void MaximizeMinimizeButton_Click(object sender, EventArgs e)
        {
            if (State.Form.WindowState == FormWindowState.Normal)
                State.Form.WindowState = FormWindowState.Maximized;
            else State.Form.WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            State.Form.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            State.Form.Close();
        }
    }
}
