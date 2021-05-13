
namespace TestingComplex.Controls
{
    partial class TestsPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.testBlocksPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.counterLabel = new Guna.UI.WinForms.GunaLabel();
            this.currentTestBlock = new TestingComplex.Controls.CurrentTestBlockControl();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(-5, 10);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(111, 30);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Все тесты";
            // 
            // testBlocksPanel
            // 
            this.testBlocksPanel.BackColor = System.Drawing.Color.Transparent;
            this.testBlocksPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.testBlocksPanel.Location = new System.Drawing.Point(0, 53);
            this.testBlocksPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.testBlocksPanel.Name = "testBlocksPanel";
            this.testBlocksPanel.Radius = 12;
            this.testBlocksPanel.Size = new System.Drawing.Size(696, 511);
            this.testBlocksPanel.TabIndex = 1;
            this.testBlocksPanel.MouseEnter += new System.EventHandler(this.GunaElipsePanel1_MouseEnter);
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(696, 53);
            this.gunaVScrollBar1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.Radius = 0;
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 511);
            this.gunaVScrollBar1.SmallChange = 3;
            this.gunaVScrollBar1.TabIndex = 2;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.gunaVScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GunaVScrollBar1_Scroll);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaLabel8.Location = new System.Drawing.Point(132, 10);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(148, 30);
            this.gunaLabel8.TabIndex = 4;
            this.gunaLabel8.Text = "Пройденные";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaLabel9.Location = new System.Drawing.Point(311, 10);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(179, 30);
            this.gunaLabel9.TabIndex = 5;
            this.gunaLabel9.Text = "Не пройденные";
            // 
            // counterLabel
            // 
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.counterLabel.Location = new System.Drawing.Point(539, 27);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(157, 23);
            this.counterLabel.TabIndex = 6;
            this.counterLabel.Text = "0 из 0";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.counterLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // currentTestBlock
            // 
            this.currentTestBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.currentTestBlock.Location = new System.Drawing.Point(721, 53);
            this.currentTestBlock.Name = "currentTestBlock";
            this.currentTestBlock.Padding = new System.Windows.Forms.Padding(10);
            this.currentTestBlock.Size = new System.Drawing.Size(281, 511);
            this.currentTestBlock.TabIndex = 7;
            // 
            // TestsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.currentTestBlock);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.testBlocksPanel);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "TestsPage";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Size = new System.Drawing.Size(1002, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel testBlocksPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel counterLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        public CurrentTestBlockControl currentTestBlock;
    }
}
