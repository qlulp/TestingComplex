
namespace TestingComplex.Controls.Pages
{
    partial class ResultPage
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
            this.closeTestButton = new Guna.UI.WinForms.GunaButton();
            this.BlockName = new Guna.UI.WinForms.GunaLabel();
            this.QuestionsLabel = new Guna.UI.WinForms.GunaLabel();
            this.correctAnswersLabel = new Guna.UI.WinForms.GunaLabel();
            this.dateLabel = new Guna.UI.WinForms.GunaLabel();
            this.retryButton = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timePassedLabel = new Guna.UI.WinForms.GunaLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.wrongAnswersLabel = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // closeTestButton
            // 
            this.closeTestButton.Animated = true;
            this.closeTestButton.AnimationHoverSpeed = 0.01F;
            this.closeTestButton.AnimationSpeed = 0.001F;
            this.closeTestButton.BackColor = System.Drawing.Color.Transparent;
            this.closeTestButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.closeTestButton.BorderColor = System.Drawing.Color.Black;
            this.closeTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeTestButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeTestButton.FocusedColor = System.Drawing.Color.Empty;
            this.closeTestButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeTestButton.ForeColor = System.Drawing.Color.White;
            this.closeTestButton.Image = null;
            this.closeTestButton.ImageSize = new System.Drawing.Size(20, 20);
            this.closeTestButton.Location = new System.Drawing.Point(725, 437);
            this.closeTestButton.Name = "closeTestButton";
            this.closeTestButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.closeTestButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeTestButton.OnHoverForeColor = System.Drawing.Color.White;
            this.closeTestButton.OnHoverImage = null;
            this.closeTestButton.OnPressedColor = System.Drawing.Color.Black;
            this.closeTestButton.Radius = 20;
            this.closeTestButton.Size = new System.Drawing.Size(177, 57);
            this.closeTestButton.TabIndex = 13;
            this.closeTestButton.Text = "Выход";
            this.closeTestButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeTestButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.closeTestButton.Click += new System.EventHandler(this.closeTestButton_Click);
            // 
            // BlockName
            // 
            this.BlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockName.BackColor = System.Drawing.Color.Transparent;
            this.BlockName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.BlockName.ForeColor = System.Drawing.Color.Black;
            this.BlockName.Location = new System.Drawing.Point(100, 40);
            this.BlockName.Margin = new System.Windows.Forms.Padding(100, 40, 100, 50);
            this.BlockName.Name = "BlockName";
            this.BlockName.Size = new System.Drawing.Size(802, 129);
            this.BlockName.TabIndex = 14;
            this.BlockName.Text = "П 112.17 Пожарно-технический минимум для руководителей, главных специалистов и ли" +
    "ц, ответственных за обеспечение пожарной безопасности организаций";
            this.BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlockName.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // QuestionsLabel
            // 
            this.QuestionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.QuestionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.QuestionsLabel.Location = new System.Drawing.Point(113, 182);
            this.QuestionsLabel.Name = "QuestionsLabel";
            this.QuestionsLabel.Size = new System.Drawing.Size(368, 42);
            this.QuestionsLabel.TabIndex = 15;
            this.QuestionsLabel.Text = "Всего вопросов: 10";
            this.QuestionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestionsLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // correctAnswersLabel
            // 
            this.correctAnswersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.correctAnswersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.correctAnswersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.correctAnswersLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.correctAnswersLabel.Location = new System.Drawing.Point(113, 235);
            this.correctAnswersLabel.Name = "correctAnswersLabel";
            this.correctAnswersLabel.Size = new System.Drawing.Size(385, 42);
            this.correctAnswersLabel.TabIndex = 16;
            this.correctAnswersLabel.Text = "Верных ответов: 10";
            this.correctAnswersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.correctAnswersLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dateLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.dateLabel.Location = new System.Drawing.Point(517, 182);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(368, 42);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Дата прохождения: 20.10.2000 19:57";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // retryButton
            // 
            this.retryButton.Animated = true;
            this.retryButton.AnimationHoverSpeed = 0.01F;
            this.retryButton.AnimationSpeed = 0.001F;
            this.retryButton.BackColor = System.Drawing.Color.Transparent;
            this.retryButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.retryButton.BorderColor = System.Drawing.Color.Black;
            this.retryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.retryButton.FocusedColor = System.Drawing.Color.Empty;
            this.retryButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retryButton.ForeColor = System.Drawing.Color.White;
            this.retryButton.Image = null;
            this.retryButton.ImageSize = new System.Drawing.Size(20, 20);
            this.retryButton.Location = new System.Drawing.Point(105, 422);
            this.retryButton.Name = "retryButton";
            this.retryButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.retryButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.retryButton.OnHoverForeColor = System.Drawing.Color.White;
            this.retryButton.OnHoverImage = null;
            this.retryButton.OnPressedColor = System.Drawing.Color.Black;
            this.retryButton.Radius = 20;
            this.retryButton.Size = new System.Drawing.Size(177, 57);
            this.retryButton.TabIndex = 18;
            this.retryButton.Text = "Пройти ещё раз";
            this.retryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.retryButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(105, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 20);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(105, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 20);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(509, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 20);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(509, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 20);
            this.panel4.TabIndex = 22;
            // 
            // timePassedLabel
            // 
            this.timePassedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePassedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timePassedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.timePassedLabel.ForeColor = System.Drawing.Color.Gray;
            this.timePassedLabel.Location = new System.Drawing.Point(517, 235);
            this.timePassedLabel.Name = "timePassedLabel";
            this.timePassedLabel.Size = new System.Drawing.Size(385, 42);
            this.timePassedLabel.TabIndex = 21;
            this.timePassedLabel.Text = "Времени затрачено: 20 минут";
            this.timePassedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timePassedLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Location = new System.Drawing.Point(105, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 20);
            this.panel5.TabIndex = 24;
            // 
            // wrongAnswersLabel
            // 
            this.wrongAnswersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongAnswersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wrongAnswersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.wrongAnswersLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongAnswersLabel.Location = new System.Drawing.Point(113, 288);
            this.wrongAnswersLabel.Name = "wrongAnswersLabel";
            this.wrongAnswersLabel.Size = new System.Drawing.Size(385, 42);
            this.wrongAnswersLabel.TabIndex = 23;
            this.wrongAnswersLabel.Text = "Неверных ответов: 0";
            this.wrongAnswersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongAnswersLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // ResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.wrongAnswersLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.timePassedLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.correctAnswersLabel);
            this.Controls.Add(this.QuestionsLabel);
            this.Controls.Add(this.BlockName);
            this.Controls.Add(this.closeTestButton);
            this.Name = "ResultPage";
            this.Size = new System.Drawing.Size(1002, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton closeTestButton;
        private Guna.UI.WinForms.GunaLabel BlockName;
        private Guna.UI.WinForms.GunaLabel QuestionsLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton retryButton;
        private Guna.UI.WinForms.GunaLabel dateLabel;
        private Guna.UI.WinForms.GunaLabel correctAnswersLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaLabel timePassedLabel;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaLabel wrongAnswersLabel;
    }
}
