
namespace TestingComplex.Controls.Pages
{
    partial class AboutProgramPage
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
            this.elipsePage = new Guna.UI.WinForms.GunaElipse(this.components);
            this.descriptionLabel = new Guna.UI.WinForms.GunaLabel();
            this.programNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.currentVersionLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsePage
            // 
            this.elipsePage.TargetControl = this;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.descriptionLabel.Location = new System.Drawing.Point(484, 221);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(234, 124);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Программный комплекс для итоговой аттестации слушателей курсов";
            this.descriptionLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.programNameLabel.Location = new System.Drawing.Point(481, 171);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(147, 47);
            this.programNameLabel.TabIndex = 2;
            this.programNameLabel.Text = "Test Me";
            this.programNameLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentVersionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.currentVersionLabel.Location = new System.Drawing.Point(484, 348);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(233, 21);
            this.currentVersionLabel.TabIndex = 3;
            this.currentVersionLabel.Text = "Версия приложения: v1.0";
            this.currentVersionLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel.Controls.Add(this.logoPictureBox);
            this.panel.Location = new System.Drawing.Point(247, 171);
            this.panel.Name = "panel";
            this.panel.Radius = 14;
            this.panel.Size = new System.Drawing.Size(231, 210);
            this.panel.TabIndex = 4;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoPictureBox.Image = global::TestingComplex.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(228, 210);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click_1);
            // 
            // AboutProgramPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "AboutProgramPage";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1010, 564);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipsePage;
        private Guna.UI.WinForms.GunaLabel descriptionLabel;
        private Guna.UI.WinForms.GunaLabel currentVersionLabel;
        private Guna.UI.WinForms.GunaLabel programNameLabel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel panel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}
