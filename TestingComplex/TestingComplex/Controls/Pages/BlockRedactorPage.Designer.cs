
namespace TestingComplex.Controls.Pages
{
    partial class BlockRedactorPage
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
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.counterLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.testBlocksPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(145, 30);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "Все вопросы";
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // counterLabel
            // 
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.counterLabel.Location = new System.Drawing.Point(539, 8);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(157, 23);
            this.counterLabel.TabIndex = 19;
            this.counterLabel.Text = "0 из 0";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.counterLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(696, 34);
            this.gunaVScrollBar1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.Radius = 0;
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 530);
            this.gunaVScrollBar1.SmallChange = 3;
            this.gunaVScrollBar1.TabIndex = 18;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // testBlocksPanel
            // 
            this.testBlocksPanel.BackColor = System.Drawing.Color.Transparent;
            this.testBlocksPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.testBlocksPanel.Location = new System.Drawing.Point(0, 34);
            this.testBlocksPanel.Margin = new System.Windows.Forms.Padding(0);
            this.testBlocksPanel.Name = "testBlocksPanel";
            this.testBlocksPanel.Radius = 12;
            this.testBlocksPanel.Size = new System.Drawing.Size(696, 530);
            this.testBlocksPanel.TabIndex = 17;
            // 
            // BlockRedactorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.testBlocksPanel);
            this.Name = "BlockRedactorPage";
            this.Size = new System.Drawing.Size(1010, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel counterLabel;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaElipsePanel testBlocksPanel;
    }
}
