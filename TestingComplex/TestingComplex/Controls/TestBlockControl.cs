using System;
using System.Drawing;
using System.Windows.Forms;
using TestingComplex.Classes;
using TestingComplex.Classes.Entities;
using TestingComplex.Controls.Pages;

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

        private Color _BaseColor = Color.FromArgb(128, 128, 255);
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
            if (State.Form.CurrentPage is TestsPage)
            {
                (State.Form.CurrentPage as TestsPage).currentTestBlock.titleLabel.Text = titleLabel.Text;
                // Получение кол-ва вопросов и даты создания
                (State.Form.CurrentPage as TestsPage).currentTestBlock.countLabel.Text = DBManager.GetCountOfQuestions(CurrentBlock.ID).ToString();
                (State.Form.CurrentPage as TestsPage).currentTestBlock.SelectedBlockID = CurrentBlock.ID;
            }
            else if (State.Form.CurrentPage is BlocksRedactorPage)
            {
                (State.Form.CurrentPage as BlocksRedactorPage).renameTextBox.Text = titleLabel.Text;
                // Получение кол-ва вопросов и даты создания
                (State.Form.CurrentPage as BlocksRedactorPage).countLabel.Text = DBManager.GetCountOfQuestions(CurrentBlock.ID).ToString();
                (State.Form.CurrentPage as BlocksRedactorPage).SelectedBlockID = CurrentBlock.ID;
            }
        }
    }
}
