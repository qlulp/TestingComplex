
namespace TestingComplex.Controls
{
    partial class QuestionButtonControl
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
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.retryButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(602, 13);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(41, 38);
            this.gunaCircleButton1.TabIndex = 0;
            this.gunaCircleButton1.Text = "x";
            this.gunaCircleButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
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
            this.retryButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retryButton.ForeColor = System.Drawing.Color.White;
            this.retryButton.Image = null;
            this.retryButton.ImageSize = new System.Drawing.Size(20, 20);
            this.retryButton.Location = new System.Drawing.Point(502, 13);
            this.retryButton.Name = "retryButton";
            this.retryButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.retryButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.retryButton.OnHoverForeColor = System.Drawing.Color.White;
            this.retryButton.OnHoverImage = null;
            this.retryButton.OnPressedColor = System.Drawing.Color.Black;
            this.retryButton.Radius = 12;
            this.retryButton.Size = new System.Drawing.Size(94, 38);
            this.retryButton.TabIndex = 19;
            this.retryButton.Text = "Изменить";
            this.retryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.retryButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(10, 4);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(479, 56);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Вопрос";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // QuestionButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.gunaCircleButton1);
            this.Name = "QuestionButtonControl";
            this.Size = new System.Drawing.Size(656, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaButton retryButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
