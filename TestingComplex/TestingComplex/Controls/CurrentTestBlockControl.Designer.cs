
namespace TestingComplex.Controls
{
    partial class CurrentTestBlockControl
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
            this.countLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startTestButton = new Guna.UI.WinForms.GunaButton();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 12;
            this.gunaElipse1.TargetControl = this;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.countLabel.ForeColor = System.Drawing.Color.White;
            this.countLabel.Location = new System.Drawing.Point(27, 395);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(85, 19);
            this.countLabel.TabIndex = 15;
            this.countLabel.Text = "Нет данных";
            this.countLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.gunaLabel4.Location = new System.Drawing.Point(13, 373);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(115, 19);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Всего вопросов:";
            this.gunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Location = new System.Drawing.Point(18, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 19);
            this.panel1.TabIndex = 13;
            // 
            // startTestButton
            // 
            this.startTestButton.Animated = true;
            this.startTestButton.AnimationHoverSpeed = 0.01F;
            this.startTestButton.AnimationSpeed = 0.001F;
            this.startTestButton.BackColor = System.Drawing.Color.Transparent;
            this.startTestButton.BaseColor = System.Drawing.Color.White;
            this.startTestButton.BorderColor = System.Drawing.Color.Black;
            this.startTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTestButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startTestButton.FocusedColor = System.Drawing.Color.Empty;
            this.startTestButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.startTestButton.Image = null;
            this.startTestButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startTestButton.Location = new System.Drawing.Point(34, 441);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.startTestButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startTestButton.OnHoverForeColor = System.Drawing.Color.White;
            this.startTestButton.OnHoverImage = null;
            this.startTestButton.OnPressedColor = System.Drawing.Color.Black;
            this.startTestButton.Radius = 20;
            this.startTestButton.Size = new System.Drawing.Size(219, 57);
            this.startTestButton.TabIndex = 12;
            this.startTestButton.Text = "Пройти тест";
            this.startTestButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startTestButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(13, 139);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(255, 234);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Тестовый блок не выбран";
            this.titleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::TestingComplex.Properties.Resources.Block_Image;
            this.gunaPictureBox1.Location = new System.Drawing.Point(13, 13);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 12;
            this.gunaPictureBox1.Size = new System.Drawing.Size(255, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 19;
            this.gunaPictureBox1.TabStop = false;
            // 
            // CurrentTestBlockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "CurrentTestBlockControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(281, 511);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton startTestButton;
        public Guna.UI.WinForms.GunaLabel titleLabel;
        public Guna.UI.WinForms.GunaLabel countLabel;
    }
}
