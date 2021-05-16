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
using TestingComplex.Classes.Entities;

namespace TestingComplex.Controls.Pages
{
    public partial class CurrentTestPage : UserControl
    {

        public CurrentTestPage()
        {
            InitializeComponent();
            progressLabel.Text = $"Вопрос {State.QuestionIndex + 1} из {State.Questions.Length}";
            questionLabel.Text = State.Questions[State.QuestionIndex].QuestionStr;
            answer1Label.Text = State.Questions[State.QuestionIndex].WrongAnswer1;
            answer2Label.Text = State.Questions[State.QuestionIndex].WrongAnswer2;
            answer3Label.Text = State.Questions[State.QuestionIndex].WrongAnswer3;
            answer4Label.Text = State.Questions[State.QuestionIndex].CorrectAnswer;
            progressBar.Maximum = State.Questions.Length;
            progressBar.Value = State.QuestionIndex;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            var label = (Guna.UI.WinForms.GunaLabel)sender;
            label.ForeColor = Color.FromArgb(97, 156, 250);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = (Guna.UI.WinForms.GunaLabel)sender;
            label.ForeColor = Color.DimGray;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            var label = (Guna.UI.WinForms.GunaLabel)sender;

            if (label.Text == State.Questions[State.QuestionIndex].CorrectAnswer)
            {
                State.Results[State.QuestionIndex] = true;
            }
            else
            {
                State.Results[State.QuestionIndex] = false;
            }
            State.QuestionIndex++;

            if (State.QuestionIndex == State.Questions.Length)
            {
                string a = "";
                foreach (var element in State.Results)
                {
                    if (element == true) a += " 1";
                    else a += " 0";
                }
                State.QuestionIndex = 0;
                State.Watch.Stop();
                State.Form.CurrentPage = new ResultPage();
            }
            else
            {
                var page = new CurrentTestPage();
                State.Form.CurrentPage = page;
            }
        }

        private void CurrentTestPage_Load(object sender, EventArgs e)
        {
            State.Form.SideMenu.SetButtonsEnabled(false);
        }
    }
}
