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
    public partial class CurrentTestBlockControl : UserControl
    {
        private int _SelectedBlockID = -1;
        public int SelectedBlockID
        {
            get => _SelectedBlockID;
            set
            {
                _SelectedBlockID = value;
            }
        }
        public CurrentTestBlockControl()
        {
            InitializeComponent();

            BackColor = CurrentTheme.SelectedColor;
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if (SelectedBlockID > 0 && DBManager.GetCountOfQuestions(SelectedBlockID) > 0)
            {
                State.SelectedBlockID = SelectedBlockID;
                State.Questions = Parser.ToQuestionList(DBManager.GetQuestions(State.SelectedBlockID)).ToArray();
                State.Results = new bool[State.Questions.Length];
                State.Watch.Start();
                var page = new CurrentTestPage();
                State.Form.CurrentPage = page;
            }     
        }
    }
}
