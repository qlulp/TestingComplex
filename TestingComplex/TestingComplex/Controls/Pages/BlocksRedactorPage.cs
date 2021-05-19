using Guna.UI.Lib.ScrollBar;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestingComplex.Classes;

namespace TestingComplex.Controls.Pages
{
    public partial class BlocksRedactorPage : UserControl
    {
        private PanelScrollHelper helper;
        private int _SelectedBlockID = -1;
        public int SelectedBlockID
        {
            get => _SelectedBlockID;
            set
            {
                _SelectedBlockID = value;
            }
        }
        public BlocksRedactorPage()
        {
            InitializeComponent();
            ConfigureScrollBar();
            AddTestBlocks();
            UpdateCounter();
        }

        private void ConfigureScrollBar()
        {
            helper = new PanelScrollHelper(testBlocksPanel, gunaVScrollBar1, true);
            testBlocksPanel.VerticalScroll.Visible = false;
            testBlocksPanel.VerticalScroll.Enabled = false;
            helper.UpdateScrollBar();
        }

        private void UpdateCounter()
        {
            int count = testBlocksPanel.Controls.OfType<TestBlockControl>().ToList().Count;
            counterLabel.Text = $"Всего: {count}";
        }

        private void AddTestBlocks()
        {
            testBlocksPanel.Controls.Clear();
            int offset = 20;
            var point = new Point(offset, offset);

            var testBlocks = DBManager.GetTestBlocks();
            var TestBlockControls = new List<TestBlockControl>();

            // Создание панелей
            for (int m = 0; m < testBlocks.Count; m++)
            {
                TestBlockControls.Add(new TestBlockControl(testBlocks[m]));
            }

            int controlIndex = 0;
            // Первый столбец -- добавление на панель
            int firstColumnCount = testBlocks.Count / 2 + testBlocks.Count % 2;
            for (; controlIndex < firstColumnCount; controlIndex++)
            {
                TestBlockControls[controlIndex].Location = point;
                point.Y = point.Y + TestBlockControls[controlIndex].Height + offset;
                testBlocksPanel.Controls.Add(TestBlockControls[controlIndex]);
            }

            if (TestBlockControls.Count > 0)
            {
                // Второй столбец -- добавление на панель
                point = new Point(offset * 2 + TestBlockControls[0].Width, offset);
                int secondColumnCount = testBlocks.Count / 2;
                for (int i = 0; i < secondColumnCount; i++, controlIndex++)
                {
                    TestBlockControls[controlIndex].Location = point;
                    point.Y = point.Y + TestBlockControls[controlIndex].Height + offset;
                    testBlocksPanel.Controls.Add(TestBlockControls[controlIndex]);
                }
            }

            // Затычка для нормального отображения отступа внизу 
            var k = new Panel
            {
                Size = new Size(1, 1),
                Location = point
            };
            testBlocksPanel.Controls.Add(k);
        }

        private void CreateButton_Click(object sender, System.EventArgs e)
        {
            string blockName = blockNameTextBox.Text;
            if (IsValidString(blockName))
            {
                DBManager.AddTestBlock(blockName);
                blockNameTextBox.Text = "";
                AddTestBlocks();
                UpdateCounter();
            }
            else MessageBox.Show("Входная строка имеет неверный формат! Длина строки должна быть от 3 до 255 символов");
        }

        private bool IsValidString(string str)
        {
            if (str == "")
                return false;
            if (str.Length < 3 || str.Length > 255)
                return false;
            List<char> blackList = new List<char>
            {
                '\''
            };

            foreach (var sign in blackList)
            {
                if (str.Contains(sign))
                    return false;
            }

            return true;
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (SelectedBlockID > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный тестовый блок?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBManager.DeleteQuestions(SelectedBlockID);
                    DBManager.DeleteTestBlock(SelectedBlockID);
                    renameTextBox.Text = "";
                    countLabel.Text = "Нет данных";
                    AddTestBlocks();
                    UpdateCounter();
                    SelectedBlockID = -1;
                }
            }
        }

        private void updateNameButton_Click(object sender, System.EventArgs e)
        {
            string blockName = renameTextBox.Text;
            if (SelectedBlockID > 0 && IsValidString(blockName))
            { 
                DBManager.RenameBlock(SelectedBlockID, blockName);
                renameTextBox.Text = "";
                AddTestBlocks();
                UpdateCounter();
                SelectedBlockID = -1;
            }
            else MessageBox.Show("Входная строка имеет неверный формат! Длина строки должна быть от 3 до 255 символов");
        }

        private void editBlockButton_Click(object sender, System.EventArgs e)
        {
            if (SelectedBlockID > 0)
            {
                var page = new QuestionsRedactorPage(SelectedBlockID);
                page.BlockName = renameTextBox.Text;
                State.Form.CurrentPage = page;
            }
        }
    }
}
