using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib.ScrollBar;
using TestingComplex.Classes;

namespace TestingComplex.Controls
{
    public partial class TestsPage : UserControl
    {
        PanelScrollHelper helper;
        public TestsPage()
        {
            InitializeComponent();
            ConfigureScrollBar();
            AddTestBlocks();
            UpdateCounter();
        }

        private void UpdateCounter()
        {
            int count = testBlocksPanel.Controls.OfType<TestBlockControl>().ToList().Count;
            counterLabel.Text = $"Всего: {count}";
        }

        private void ConfigureScrollBar()
        {
            helper = new PanelScrollHelper(testBlocksPanel, gunaVScrollBar1, true);
            testBlocksPanel.VerticalScroll.Visible = false;
            testBlocksPanel.VerticalScroll.Enabled = false;
            helper.UpdateScrollBar();
        }

        private void AddTestBlocks()
        {
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


        private void GunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            testBlocksPanel.Update();
            testBlocksPanel.Radius = testBlocksPanel.Radius;
        }

        private void GunaElipsePanel1_MouseEnter(object sender, EventArgs e)
        {
            testBlocksPanel.Focus();
        }
    }
}
