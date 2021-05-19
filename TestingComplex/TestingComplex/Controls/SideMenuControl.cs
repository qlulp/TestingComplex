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
using TestingComplex.Controls.Pages;

namespace TestingComplex.Controls
{
    public partial class SideMenuControl : UserControl
    {
        public SideMenuControl()
        {
            InitializeComponent();
            BackColor = CurrentTheme.PageColor;
        }

        private void testsButton_Click(object sender, EventArgs e)
        {
            State.Form.CurrentPage = new TestsPage();
            linePanel.Location = new Point(linePanel.Location.X, testsButton.Location.Y);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            State.Form.CurrentPage = new BlocksRedactorPage();
            linePanel.Location = new Point(linePanel.Location.X, editButton.Location.Y);
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            linePanel.Location = new Point(linePanel.Location.X, settingButton.Location.Y);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            linePanel.Location = new Point(linePanel.Location.X, aboutButton.Location.Y);
            State.Form.CurrentPage = new AboutProgramPage();
        }

        public void SetButtonsEnabled(bool param)
        {
            foreach (GunaImageButton control in Controls.OfType<GunaImageButton>())
            {
                control.Enabled = param;
            }
        }
    }
}
