
namespace TestingComplex.Controls
{
    partial class AnswerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerControl));
            this.answerLabel = new Guna.UI.WinForms.GunaLabel();
            this.answerCheckBox = new Guna.UI.WinForms.GunaImageCheckBox();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.answerLabel.ForeColor = System.Drawing.Color.DimGray;
            this.answerLabel.Location = new System.Drawing.Point(37, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(763, 69);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = resources.GetString("answerLabel.Text");
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.answerLabel.Click += new System.EventHandler(this.gunaImageCheckBox1_Click);
            this.answerLabel.MouseEnter += new System.EventHandler(this.answerLabel_MouseEnter);
            this.answerLabel.MouseLeave += new System.EventHandler(this.answerLabel_MouseLeave);
            // 
            // answerCheckBox
            // 
            this.answerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerCheckBox.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("answerCheckBox.ImageCheckedOff")));
            this.answerCheckBox.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("answerCheckBox.ImageCheckedOn")));
            this.answerCheckBox.ImageSize = new System.Drawing.Size(20, 20);
            this.answerCheckBox.Location = new System.Drawing.Point(7, 0);
            this.answerCheckBox.Name = "answerCheckBox";
            this.answerCheckBox.Size = new System.Drawing.Size(24, 69);
            this.answerCheckBox.TabIndex = 28;
            this.answerCheckBox.CheckedChanged += new System.EventHandler(this.answerCheckBox_CheckedChanged);
            this.answerCheckBox.MouseEnter += new System.EventHandler(this.answerCheckBox_MouseEnter);
            this.answerCheckBox.MouseLeave += new System.EventHandler(this.answerCheckBox_MouseLeave);
            // 
            // AnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answerCheckBox);
            this.Controls.Add(this.answerLabel);
            this.Name = "AnswerControl";
            this.Size = new System.Drawing.Size(800, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel answerLabel;
        private Guna.UI.WinForms.GunaImageCheckBox answerCheckBox;
    }
}
