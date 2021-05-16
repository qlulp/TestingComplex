using Guna.UI.Lib.ScrollBar;
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
    public partial class QuestionsRedactorPage : UserControl
    {
        public int BlockID { get; set; }
        private PanelScrollHelper helper;
        List<Question> Questions;
        public QuestionsRedactorPage()
        {
            InitializeComponent();
            ConfigureScrollBar();
            AddButtons();
            UpdateCounter();
        }
        private void ConfigureScrollBar()
        {
            helper = new PanelScrollHelper(questionsPanel, gunaVScrollBar1, true);
            questionsPanel.VerticalScroll.Visible = false;
            questionsPanel.VerticalScroll.Enabled = false;
            helper.UpdateScrollBar();
        }

        private void UpdateCounter()
        {
            int count = questionsPanel.Controls.OfType<QuestionButtonControl>().ToList().Count;
            counterLabel.Text = $"Вопросов: {count}";
        }

        private void AddButtons()
        {
            questionsPanel.Controls.Clear();
            Questions = Parser.ToQuestionList(DBManager.GetQuestions(BlockID));
            Point startPoint = new Point(20, 20);
            const int buttonsInRow = 16;
            int x = startPoint.X;
            int y = startPoint.Y;

            int countOfQuestions = Questions.Count;
            int k = 0;
            int rows = 0;

            while (countOfQuestions > 16)
            {
                rows++;
                countOfQuestions -= 16;
            }

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < buttonsInRow; i++)
                {
                    var button = new QuestionButtonControl();
                    button.Question = Questions[k];
                    button.Value = (k + 1).ToString();
                    button.Location = new Point(x, y);
                    x += 6 + 36;
                    questionsPanel.Controls.Add(button);
                    k++;
                }
                y += 6 + 36;
                x = startPoint.X;
            }

            for (int i = 0; i < countOfQuestions % buttonsInRow; i++)
            {
                var button = new QuestionButtonControl();
                button.Question = Questions[k];
                button.Value = (k + 1).ToString();
                button.Location = new Point(x, y);
                x += 6 + 36;
                questionsPanel.Controls.Add(button);
                k++;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Question temp = new Question()
                {
                    BlockID = BlockID,
                    QuestionStr = questionTextBox.Text,
                    WrongAnswer1 = answer1TextBox.Text,
                    WrongAnswer2 = answer2TextBox.Text,
                    WrongAnswer3 = answer3TextBox.Text,
                    CorrectAnswer = answer4TextBox.Text
                };
                DBManager.AddQuestion(temp);
                AddButtons();
                UpdateCounter();
            }
        }

        private bool IsValidInput()
        {
            foreach (var textbox in Controls.OfType<Guna.UI.WinForms.GunaTextBox>().Where(i => !i.ReadOnly))
            {
                if (textbox.Text == "")
                    return false;
                if (textbox.Text.Length < 8 || textbox.Text.Length > 255)
                    return false;
                List<char> blackList = new List<char>
                {
                    '\''
                };

                foreach (var sign in blackList)
                {
                    if (textbox.Text.Contains(sign))
                        return false;
                }
            }

            return true;
        }
    }
}
