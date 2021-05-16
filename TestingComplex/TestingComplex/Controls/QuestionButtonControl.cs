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
using TestingComplex.Classes.Entities;
using TestingComplex.Controls.Pages;

namespace TestingComplex.Controls
{
    public partial class QuestionButtonControl : UserControl
    {
        public int QuestionID { get; set; }
        private Question _Question;
        public Question Question
        {
            get => _Question;
            set
            {
                _Question = value;
                toolTip1.SetToolTip(titleLabel, Question.QuestionStr);
                toolTip1.SetToolTip(this, Question.QuestionStr);
            }
        }
        public string Value 
        {
            get => titleLabel.Text;
            set => titleLabel.Text = value;
        }
        public QuestionButtonControl()
        {
            InitializeComponent();
        }

        private void titleLabel_MouseEnter(object sender, EventArgs e)
        {
            backPanel.BaseColor = Color.FromArgb(95, 54, 255);
        }

        private void titleLabel_MouseLeave(object sender, EventArgs e)
        {
            backPanel.BaseColor = Color.FromArgb(128, 128, 255);
        }

        private void backPanel_Click(object sender, EventArgs e)
        {
            if (State.Form.CurrentPage is QuestionsRedactorPage)
            {
                (State.Form.CurrentPage as QuestionsRedactorPage).questionIDTextBox.Text = Question.ID.ToString();
                (State.Form.CurrentPage as QuestionsRedactorPage).questionTextBox.Text = Question.QuestionStr;
                (State.Form.CurrentPage as QuestionsRedactorPage).answer1TextBox.Text = Question.WrongAnswer1;
                (State.Form.CurrentPage as QuestionsRedactorPage).answer2TextBox.Text = Question.WrongAnswer2;
                (State.Form.CurrentPage as QuestionsRedactorPage).answer3TextBox.Text = Question.WrongAnswer3;
                (State.Form.CurrentPage as QuestionsRedactorPage).answer4TextBox.Text = Question.CorrectAnswer;
            }
        }
    }
}
