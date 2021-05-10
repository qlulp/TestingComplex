using System;
using System.Drawing;
using System.Windows.Forms;
using TestingComplex.Classes;
using TestingComplex.Classes.Entities;

namespace TestingComplex.Controls
{
    public partial class TestBlockControl : UserControl
    {
        public TestBlock CurrentBlock;

        private Color _OnHoverColor = Color.FromArgb(95, 54, 255);
        public Color OnHoverColor
        {
            get => _OnHoverColor;
            set => _OnHoverColor = value;
        }

        private Color _BaseColor = Color.FromArgb(104, 150, 250);
        public Color BaseColor
        {
            get => _BaseColor;
            set
            {
                _BaseColor = value;
                BackColor = value;
            }
        }

        public TestBlockControl()
        {
            InitializeComponent();
        }

        public TestBlockControl(TestBlock testBlock)
        {
            InitializeComponent();
            CurrentBlock = testBlock;
            titleLabel.Text = CurrentBlock.Name;
        }

        private void TestBlock_MouseEnter(object sender, EventArgs e)
        {
            BackColor = OnHoverColor;
        }

        private void TestBlock_MouseLeave(object sender, EventArgs e)
        {
            BackColor = BaseColor;
        }

        private void TestBlockControl_Click(object sender, EventArgs e)
        {

        }
    }
}
