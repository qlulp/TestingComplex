
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
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "00";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.titleLabel.Click += new System.EventHandler(this.backPanel_Click);
            this.titleLabel.MouseEnter += new System.EventHandler(this.titleLabel_MouseEnter);
            this.titleLabel.MouseLeave += new System.EventHandler(this.titleLabel_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.UseAnimation = false;
            // 
            // backPanel
            // 
            this.backPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backPanel.Controls.Add(this.titleLabel);
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Radius = 8;
            this.backPanel.Size = new System.Drawing.Size(36, 36);
            this.backPanel.TabIndex = 1;
            this.backPanel.Click += new System.EventHandler(this.backPanel_Click);
            this.backPanel.MouseEnter += new System.EventHandler(this.titleLabel_MouseEnter);
            this.backPanel.MouseLeave += new System.EventHandler(this.titleLabel_MouseLeave);
            // 
            // QuestionButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.backPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "QuestionButtonControl";
            this.Size = new System.Drawing.Size(36, 36);
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        public Guna.UI.WinForms.GunaElipsePanel backPanel;
    }
}
