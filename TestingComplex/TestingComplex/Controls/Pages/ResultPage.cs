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
    public partial class ResultPage : UserControl
    {
        public ResultPage()
        {
            InitializeComponent();
            CommitResult();
            QuestionsLabel.Text = $"Всего вопросов: {State.Questions.Length}";

            int correctAnswersCount = 0;
            foreach (var answer in State.Results)
            {
                if (answer)
                    correctAnswersCount++;
            }
            correctAnswersLabel.Text = $"Верных ответов: {correctAnswersCount}";
            DateTime now = DateTime.Now;
            dateLabel.Text = $"Дата прохождения: {now.ToShortDateString()} {now.ToShortTimeString()}";
            wrongAnswersLabel.Text = $"Неверных ответов: {State.Questions.Length - correctAnswersCount}";
            TimeSpan ts = State.Watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}",
            ts.Minutes, ts.Seconds);
            timePassedLabel.Text = $"Времени затрачено: " + elapsedTime;
        }

        private void CommitResult()
        {
            int correctAnswersCount = 0;
            foreach (var answer in State.Results)
            {
                if (answer)
                    correctAnswersCount++;
            }
            var result = new TestResult()
            {
                Login = "admin",
                BlockID = State.SelectedBlockID,
                CountOfQuestions = State.Questions.Length,
                CountOfCorrectAnswers = correctAnswersCount,
                Date = DateTime.Now,
                SecondsElapsed = (int)State.Watch.ElapsedMilliseconds / 1000
            };

            DBManager.CommitResult(result);
        }

        private void closeTestButton_Click(object sender, EventArgs e)
        {
            State.Form.CurrentPage = new TestsPage();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            State.Questions = Parser.ToQuestionList(DBManager.GetQuestions(State.SelectedBlockID)).ToArray();
            State.Results = new bool[State.Questions.Length];
            State.Watch = new System.Diagnostics.Stopwatch();
            State.Watch.Start();
            var page = new CurrentTestPage();
            State.Form.CurrentPage = page;
        }

        private void ResultPage_Load(object sender, EventArgs e)
        {
            State.Form.SideMenu.SetButtonsEnabled(true);
        }
    }
}
