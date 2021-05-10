
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
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.answer4Label = new Guna.UI.WinForms.GunaLabel();
            this.answer2Label = new Guna.UI.WinForms.GunaLabel();
            this.answer3Label = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaImageCheckBox7 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.gunaImageCheckBox1 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.gunaImageCheckBox2 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.gunaImageCheckBox3 = new Guna.UI.WinForms.GunaImageCheckBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
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
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel2.Location = new System.Drawing.Point(10, 10);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 17);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Вопрос 1 из 10";
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // answer4Label
            // 
            this.answer4Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer4Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer4Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answer4Label.ForeColor = System.Drawing.Color.DimGray;
            this.answer4Label.Location = new System.Drawing.Point(135, 394);
            this.answer4Label.Name = "answer4Label";
            this.answer4Label.Size = new System.Drawing.Size(763, 69);
            this.answer4Label.TabIndex = 16;
            this.answer4Label.Text = resources.GetString("answer4Label.Text");
            this.answer4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer4Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer4Label.Click += new System.EventHandler(this.Label_Click);
            this.answer4Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer4Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // answer2Label
            // 
            this.answer2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer2Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answer2Label.ForeColor = System.Drawing.Color.DimGray;
            this.answer2Label.Location = new System.Drawing.Point(135, 256);
            this.answer2Label.Name = "answer2Label";
            this.answer2Label.Size = new System.Drawing.Size(763, 69);
            this.answer2Label.TabIndex = 17;
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
            this.answer3Label.Location = new System.Drawing.Point(135, 325);
            this.answer3Label.Name = "answer3Label";
            this.answer3Label.Size = new System.Drawing.Size(763, 69);
            this.answer3Label.TabIndex = 18;
            this.answer3Label.Text = "IP43";
            this.answer3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer3Label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answer3Label.Click += new System.EventHandler(this.Label_Click);
            this.answer3Label.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.answer3Label.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(778, 492);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(40, 40, 40, 30);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 12;
            this.gunaButton1.Size = new System.Drawing.Size(124, 42);
            this.gunaButton1.TabIndex = 19;
            this.gunaButton1.Text = "Далее";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaImageCheckBox7
            // 
            this.gunaImageCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageCheckBox7.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox7.ImageCheckedOff")));
            this.gunaImageCheckBox7.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox7.ImageCheckedOn")));
            this.gunaImageCheckBox7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageCheckBox7.Location = new System.Drawing.Point(105, 394);
            this.gunaImageCheckBox7.Name = "gunaImageCheckBox7";
            this.gunaImageCheckBox7.Size = new System.Drawing.Size(24, 69);
            this.gunaImageCheckBox7.TabIndex = 26;
            // 
            // gunaImageCheckBox1
            // 
            this.gunaImageCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageCheckBox1.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox1.ImageCheckedOff")));
            this.gunaImageCheckBox1.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox1.ImageCheckedOn")));
            this.gunaImageCheckBox1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageCheckBox1.Location = new System.Drawing.Point(105, 187);
            this.gunaImageCheckBox1.Name = "gunaImageCheckBox1";
            this.gunaImageCheckBox1.Size = new System.Drawing.Size(24, 69);
            this.gunaImageCheckBox1.TabIndex = 27;
            // 
            // gunaImageCheckBox2
            // 
            this.gunaImageCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageCheckBox2.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox2.ImageCheckedOff")));
            this.gunaImageCheckBox2.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox2.ImageCheckedOn")));
            this.gunaImageCheckBox2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageCheckBox2.Location = new System.Drawing.Point(105, 262);
            this.gunaImageCheckBox2.Name = "gunaImageCheckBox2";
            this.gunaImageCheckBox2.Size = new System.Drawing.Size(24, 69);
            this.gunaImageCheckBox2.TabIndex = 28;
            // 
            // gunaImageCheckBox3
            // 
            this.gunaImageCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageCheckBox3.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox3.ImageCheckedOff")));
            this.gunaImageCheckBox3.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("gunaImageCheckBox3.ImageCheckedOn")));
            this.gunaImageCheckBox3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageCheckBox3.Location = new System.Drawing.Point(105, 325);
            this.gunaImageCheckBox3.Name = "gunaImageCheckBox3";
            this.gunaImageCheckBox3.Size = new System.Drawing.Size(24, 69);
            this.gunaImageCheckBox3.TabIndex = 29;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(135, 187);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(763, 69);
            this.gunaLabel1.TabIndex = 30;
            this.gunaLabel1.Text = resources.GetString("gunaLabel1.Text");
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaLabel1.Click += new System.EventHandler(this.Label_Click);
            this.gunaLabel1.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.gunaLabel1.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // CurrentTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaImageCheckBox3);
            this.Controls.Add(this.gunaImageCheckBox2);
            this.Controls.Add(this.gunaImageCheckBox1);
            this.Controls.Add(this.gunaImageCheckBox7);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.answer3Label);
            this.Controls.Add(this.answer2Label);
            this.Controls.Add(this.answer4Label);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.questionLabel);
            this.Name = "CurrentTestPage";
            this.Size = new System.Drawing.Size(1002, 572);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel questionLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel answer3Label;
        private Guna.UI.WinForms.GunaLabel answer2Label;
        private Guna.UI.WinForms.GunaLabel answer4Label;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaImageCheckBox gunaImageCheckBox3;
        private Guna.UI.WinForms.GunaImageCheckBox gunaImageCheckBox2;
        private Guna.UI.WinForms.GunaImageCheckBox gunaImageCheckBox1;
        private Guna.UI.WinForms.GunaImageCheckBox gunaImageCheckBox7;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
