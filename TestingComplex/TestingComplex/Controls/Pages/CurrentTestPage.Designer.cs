
namespace TestingComplex.Controls.Pages
{
    partial class CurrentTestPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentTestPage));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.questionLabel = new Guna.UI.WinForms.GunaLabel();
            this.progressLabel = new Guna.UI.WinForms.GunaLabel();
            this.answer2Label = new Guna.UI.WinForms.GunaLabel();
            this.answer3Label = new Guna.UI.WinForms.GunaLabel();
            this.answer1Label = new Guna.UI.WinForms.GunaLabel();
            this.answer4Label = new Guna.UI.WinForms.GunaLabel();
            this.progressBar = new Guna.UI.WinForms.GunaProgressBar();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 16;
            this.gunaElipse1.TargetControl = this;
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.questionLabel.ForeColor = System.Drawing.Color.Black;
            this.questionLabel.Location = new System.Drawing.Point(100, 40);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(100, 40, 100, 50);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(810, 129);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "На каком этапе строительства объекта защиты должны вводиться в действие автоматич" +
    "еские системы пожаротушения и сигнализации?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questionLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // progressLabel
            // 
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressLabel.ForeColor = System.Drawing.Color.Gray;
            this.progressLabel.Location = new System.Drawing.Point(102, 510);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(10);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(794, 17);
            this.progressLabel.TabIndex = 14;
            this.progressLabel.Text = "Вопрос 1 из 10";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.progressLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // answer2Label
            // 
            this.answer2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer2Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answer2Label.ForeColor = System.Drawing.Color.DimGray;
            this.answer2Label.Location = new System.Drawing.Point(101, 262);
            this.answer2Label.Name = "answer2Label";
            this.answer2Label.Size = new System.Drawing.Size(801, 69);
            this.answer2Label.TabIndex = 2;
            this.answer2Label.Text = resources.GetString("answer2Label.Text");
            this.answer2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer2Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer2Label.Click += new System.EventHandler(this.Label_Click);
            this.answer2Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer2Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // answer3Label
            // 
            this.answer3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer3Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer3Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answer3Label.ForeColor = System.Drawing.Color.DimGray;
            this.answer3Label.Location = new System.Drawing.Point(101, 331);
            this.answer3Label.Name = "answer3Label";
            this.answer3Label.Size = new System.Drawing.Size(801, 69);
            this.answer3Label.TabIndex = 3;
            this.answer3Label.Text = "IP43";
            this.answer3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer3Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer3Label.Click += new System.EventHandler(this.Label_Click);
            this.answer3Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer3Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // answer1Label
            // 
            this.answer1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer1Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answer1Label.ForeColor = System.Drawing.Color.DimGray;
            this.answer1Label.Location = new System.Drawing.Point(101, 186);
            this.answer1Label.Name = "answer1Label";
            this.answer1Label.Size = new System.Drawing.Size(801, 69);
            this.answer1Label.TabIndex = 1;
            this.answer1Label.Text = resources.GetString("answer1Label.Text");
            this.answer1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer1Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer1Label.Click += new System.EventHandler(this.Label_Click);
            this.answer1Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer1Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // answer4Label
            // 
            this.answer4Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer4Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer4Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answer4Label.ForeColor = System.Drawing.Color.DimGray;
            this.answer4Label.Location = new System.Drawing.Point(101, 400);
            this.answer4Label.Name = "answer4Label";
            this.answer4Label.Size = new System.Drawing.Size(801, 69);
            this.answer4Label.TabIndex = 15;
            this.answer4Label.Text = resources.GetString("answer4Label.Text");
            this.answer4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer4Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer4Label.Click += new System.EventHandler(this.Label_Click);
            this.answer4Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer4Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderColor = System.Drawing.Color.Black;
            this.progressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBar.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressBar.Location = new System.Drawing.Point(105, 537);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progressBar.Size = new System.Drawing.Size(797, 3);
            this.progressBar.TabIndex = 33;
            this.progressBar.Value = 70;
            // 
            // CurrentTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.answer4Label);
            this.Controls.Add(this.answer1Label);
            this.Controls.Add(this.answer3Label);
            this.Controls.Add(this.answer2Label);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "CurrentTestPage";
            this.Size = new System.Drawing.Size(1010, 567);
            this.Load += new System.EventHandler(this.CurrentTestPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel questionLabel;
        private Guna.UI.WinForms.GunaLabel progressLabel;
        private Guna.UI.WinForms.GunaLabel answer3Label;
        private Guna.UI.WinForms.GunaLabel answer2Label;
        private Guna.UI.WinForms.GunaLabel answer1Label;
        private Guna.UI.WinForms.GunaLabel answer4Label;
        private Guna.UI.WinForms.GunaProgressBar progressBar;
    }
}
