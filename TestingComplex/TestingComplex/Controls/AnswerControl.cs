using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingComplex.Controls
{
    public partial class AnswerControl : UserControl
    {
        public bool IsTrueAnswer { get; set; }
        public AnswerControl()
        {
            InitializeComponent();
        }

        private void gunaImageCheckBox1_Click(object sender, EventArgs e)
        {
            try
            {
                var label = (Guna.UI.WinForms.GunaLabel)sender;
                label.ForeColor = Color.DimGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void answerLabel_MouseEnter(object sender, EventArgs e)
        {
            answerLabel.ForeColor = Color.FromArgb(97, 156, 250);
        }

        private void answerLabel_MouseLeave(object sender, EventArgs e)
        {
            answerLabel.ForeColor = Color.DimGray;
        }

        private void answerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            answerLabel.ForeColor = Color.FromArgb(97, 156, 250);
        }

        private void answerCheckBox_MouseEnter(object sender, EventArgs e)
        {
            answerLabel.ForeColor = Color.FromArgb(97, 156, 250);
        }

        private void answerCheckBox_MouseLeave(object sender, EventArgs e)
        {
            answerLabel.ForeColor = Color.DimGray;
        }
    }
}
