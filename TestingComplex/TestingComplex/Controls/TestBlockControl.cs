using System;
using System.Linq;
using System.Windows.Forms;
using TestingComplex.Classes;
using TestingComplex.Classes.Entities;
using TestingComplex.Controls.Pages;

namespace TestingComplex.Controls
{
    public partial class TestBlockControl : UserControl
    {
        public TestBlock CurrentBlock;

        private bool _IsSelected = false;
        public bool IsSelected
        {
            get => _IsSelected;
            set
            {
                _IsSelected = value;
                if (value)
                {
                    BackColor = CurrentTheme.SelectedColor; 
                }
                else
                {
                    BackColor = CurrentTheme.BaseColor;
                }
            }
        }

        public TestBlockControl()
        {
            InitializeComponent();
            BackColor = CurrentTheme.BaseColor;
        }

        public TestBlockControl(TestBlock testBlock)
        {
            InitializeComponent();
            CurrentBlock = testBlock;
            titleLabel.Text = CurrentBlock.Name;
        }

        private void TestBlock_MouseEnter(object sender, EventArgs e)
        {
            BackColor = CurrentTheme.SelectedColor;
        }

        private void TestBlock_MouseLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
                BackColor = CurrentTheme.BaseColor;
        }

        private void TestBlockControl_Click(object sender, EventArgs e)
        {
            if (State.Form.CurrentPage is TestsPage)
            {
                (State.Form.CurrentPage as TestsPage).currentTestBlock.titleLabel.Text = titleLabel.Text;
                // Получение кол-ва вопросов и даты создания
                (State.Form.CurrentPage as TestsPage).currentTestBlock.countLabel.Text = DBManager.GetCountOfQuestions(CurrentBlock.ID).ToString();
                (State.Form.CurrentPage as TestsPage).currentTestBlock.SelectedBlockID = CurrentBlock.ID;

                // Подсветка выбранного блока

                foreach (var block in (State.Form.CurrentPage as TestsPage).testBlocksPanel.Controls.OfType<TestBlockControl>())
                {
                    block.IsSelected = false;
                }
                this.IsSelected = true;
                
            }
            else if (State.Form.CurrentPage is BlocksRedactorPage)
            {
                (State.Form.CurrentPage as BlocksRedactorPage).renameTextBox.Text = titleLabel.Text;
                // Получение кол-ва вопросов и даты создания
                (State.Form.CurrentPage as BlocksRedactorPage).countLabel.Text = DBManager.GetCountOfQuestions(CurrentBlock.ID).ToString();
                (State.Form.CurrentPage as BlocksRedactorPage).SelectedBlockID = CurrentBlock.ID;

                // Подсветка выбранного блока

                foreach (var block in (State.Form.CurrentPage as BlocksRedactorPage).testBlocksPanel.Controls.OfType<TestBlockControl>())
                {
                    block.IsSelected = false;
                }
                this.IsSelected = true;
            }
        }
    }
}
