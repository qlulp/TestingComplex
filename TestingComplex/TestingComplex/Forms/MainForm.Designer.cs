
namespace TestingComplex
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.elipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.mainSideMenu = new TestingComplex.Controls.SideMenuControl();
            this.mainHeader = new TestingComplex.Controls.HeaderControl();
            this.dragHeader = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.Radius = 14;
            this.elipseForm.TargetControl = this;
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this;
            // 
            // mainSideMenu
            // 
            this.mainSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.mainSideMenu.Location = new System.Drawing.Point(0, 0);
            this.mainSideMenu.Name = "mainSideMenu";
            this.mainSideMenu.Size = new System.Drawing.Size(64, 660);
            this.mainSideMenu.TabIndex = 22;
            // 
            // mainHeader
            // 
            this.mainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.mainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainHeader.Location = new System.Drawing.Point(78, 12);
            this.mainHeader.Margin = new System.Windows.Forms.Padding(0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(1002, 50);
            this.mainHeader.TabIndex = 21;
            // 
            // dragHeader
            // 
            this.dragHeader.TargetControl = this.mainHeader;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.mainSideMenu);
            this.Controls.Add(this.mainHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipseForm;
        private Guna.UI.WinForms.GunaDragControl dragForm;
        private System.Windows.Forms.ToolTip toolTips;
        private Controls.HeaderControl mainHeader;
        private Guna.UI.WinForms.GunaDragControl dragHeader;
        private Controls.SideMenuControl mainSideMenu;
    }
}

