
namespace TestingComplex.Controls
{
    partial class SideMenuControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.aboutButton = new Guna.UI.WinForms.GunaImageButton();
            this.testsButton = new Guna.UI.WinForms.GunaImageButton();
            this.editButton = new Guna.UI.WinForms.GunaImageButton();
            this.settingButton = new Guna.UI.WinForms.GunaImageButton();
            this.linePanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(4, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 2);
            this.panel2.TabIndex = 30;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BaseColor = System.Drawing.Color.White;
            this.logoPictureBox.Image = global::TestingComplex.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(58, 58);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.aboutButton.Image = global::TestingComplex.Properties.Resources.about;
            this.aboutButton.ImageSize = new System.Drawing.Size(30, 30);
            this.aboutButton.Location = new System.Drawing.Point(12, 608);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.OnHoverImage = global::TestingComplex.Properties.Resources.about_active;
            this.aboutButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.aboutButton.Size = new System.Drawing.Size(40, 40);
            this.aboutButton.TabIndex = 28;
            this.toolTip1.SetToolTip(this.aboutButton, "О приложении");
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // testsButton
            // 
            this.testsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.testsButton.Image = global::TestingComplex.Properties.Resources.tests;
            this.testsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.testsButton.Location = new System.Drawing.Point(12, 76);
            this.testsButton.Name = "testsButton";
            this.testsButton.OnHoverImage = global::TestingComplex.Properties.Resources.tests_active;
            this.testsButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.testsButton.Size = new System.Drawing.Size(40, 40);
            this.testsButton.TabIndex = 27;
            this.toolTip1.SetToolTip(this.testsButton, "Тесты");
            this.testsButton.Click += new System.EventHandler(this.testsButton_Click);
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editButton.Image = global::TestingComplex.Properties.Resources.edit;
            this.editButton.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Location = new System.Drawing.Point(12, 122);
            this.editButton.Name = "editButton";
            this.editButton.OnHoverImage = global::TestingComplex.Properties.Resources.edit_active;
            this.editButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.TabIndex = 26;
            this.toolTip1.SetToolTip(this.editButton, "Редактор тестов");
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingButton.Image = global::TestingComplex.Properties.Resources.settings;
            this.settingButton.ImageSize = new System.Drawing.Size(30, 30);
            this.settingButton.Location = new System.Drawing.Point(12, 168);
            this.settingButton.Name = "settingButton";
            this.settingButton.OnHoverImage = global::TestingComplex.Properties.Resources.settings_active;
            this.settingButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.settingButton.Size = new System.Drawing.Size(40, 40);
            this.settingButton.TabIndex = 25;
            this.toolTip1.SetToolTip(this.settingButton, "Настройки");
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.Indigo;
            this.linePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linePanel.Location = new System.Drawing.Point(62, 76);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(2, 40);
            this.linePanel.TabIndex = 31;
            // 
            // SideMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.testsButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.settingButton);
            this.Name = "SideMenuControl";
            this.Size = new System.Drawing.Size(64, 660);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox logoPictureBox;
        private Guna.UI.WinForms.GunaImageButton aboutButton;
        private Guna.UI.WinForms.GunaImageButton testsButton;
        private Guna.UI.WinForms.GunaImageButton editButton;
        private Guna.UI.WinForms.GunaImageButton settingButton;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
