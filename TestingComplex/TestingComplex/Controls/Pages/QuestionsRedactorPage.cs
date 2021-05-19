using Guna.UI.Lib.ScrollBar;
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
    public partial class QuestionsRedactorPage : UserControl
    {
        public int BlockID { get; set; }
        private string _BlockName = "";
        public string BlockName
        {
            get => _BlockName;
            set
            {
                _BlockName = value;
                titleLabel.Text = value;
                toolTip1.SetToolTip(titleLabel, value);
            }
        }
        private PanelScrollHelper helper;
        List<Question> Questions;
        public QuestionsRedactorPage()
        {
            InitializeComponent();
            ConfigureScrollBar();
            AddQuestions();
            UpdateCounter();
        }
        public QuestionsRedactorPage(int blockID)
        {
            InitializeComponent();
            BlockID = blockID;
            ConfigureScrollBar();
            AddQuestions();
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
            counterLabel.Text = $"Всего: {count}";
        }

        private void AddQuestions()
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
                AddQuestions();
                UpdateCounter();
                CleatTextBoxes();
            } else MessageBox.Show("Входная строка имеет неверный формат! Длина строки должна быть от 3 до 255 символов");
        }

        private void CleatTextBoxes()
        {
            foreach (var control in selectedBlockPanel.Controls.OfType<GunaTextBox>())
            {
                control.Text = "";
            }
        }

        private bool IsValidInput()
        {
            foreach (var textbox in selectedBlockPanel.Controls.OfType<Guna.UI.WinForms.GunaTextBox>().Where(i => !i.ReadOnly))
            {
                if (textbox.Text == "")
                    return false;
                if (textbox.Text.Length < 3 || textbox.Text.Length > 255)
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(questionIDTextBox.Text, out int id))
            {
                if (id > 0)
                {
                    if (MessageBox.Show("Вы действительно хотите удалить выбранный вопрос?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBManager.DeleteQuestion(id);
                        AddQuestions();
                        UpdateCounter();
                        CleatTextBoxes();
                    }
                }
            }
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            CleatTextBoxes();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                try
                {
                    Question temp = new Question()
                    {
                        BlockID = BlockID,
                        ID = Convert.ToInt32(questionIDTextBox.Text),
                        QuestionStr = questionTextBox.Text,
                        WrongAnswer1 = answer1TextBox.Text,
                        WrongAnswer2 = answer2TextBox.Text,
                        WrongAnswer3 = answer3TextBox.Text,
                        CorrectAnswer = answer4TextBox.Text
                    };
                    DBManager.UpdateQuestion(temp);
                    AddQuestions();
                    UpdateCounter();
                    CleatTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Входная строка имеет неверный формат! Длина строки должна быть от 3 до 255 символов");
        }

        private void pageTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
