
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 12;
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
            this.questionLabel.Size = new System.Drawing.Size(802, 129);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "На каком этапе строительства объекта защиты должны вводиться в действие автоматич" +
    "еские системы пожаротушения и сигнализации?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questionLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressLabel.ForeColor = System.Drawing.Color.Gray;
            this.progressLabel.Location = new System.Drawing.Point(10, 10);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(10);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(101, 17);
            this.progressLabel.TabIndex = 14;
            this.progressLabel.Text = "Вопрос 1 из 10";
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
            this.answer2Label.Size = new System.Drawing.Size(793, 69);
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
            this.answer3Label.Size = new System.Drawing.Size(793, 69);
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
            this.answer1Label.Size = new System.Drawing.Size(793, 69);
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
            this.answer4Label.Size = new System.Drawing.Size(793, 69);
            this.answer4Label.TabIndex = 15;
            this.answer4Label.Text = resources.GetString("answer4Label.Text");
            this.answer4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer4Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer4Label.Click += new System.EventHandler(this.Label_Click);
            this.answer4Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer4Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(81, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(81, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(81, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(81, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "-";
            // 
            // CurrentTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer4Label);
            this.Controls.Add(this.answer1Label);
            this.Controls.Add(this.answer3Label);
            this.Controls.Add(this.answer2Label);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "CurrentTestPage";
            this.Size = new System.Drawing.Size(1002, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel questionLabel;
        private Guna.UI.WinForms.GunaLabel progressLabel;
        private Guna.UI.WinForms.GunaLabel answer3Label;
        private Guna.UI.WinForms.GunaLabel answer2Label;
        private Guna.UI.WinForms.GunaLabel answer1Label;
        private Guna.UI.WinForms.GunaLabel answer4Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
