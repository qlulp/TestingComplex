
namespace TestingComplex.Controls.Pages
{
    partial class BlocksRedactorPage
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
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.testBlocksPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.blockNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.CreateButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.counterLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.selectedBlockPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.countLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBlockButton = new Guna.UI.WinForms.GunaButton();
            this.renameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.updateNameButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            this.selectedBlockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsePage
            // 
            this.elipsePage.TargetControl = this;
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
            this.gunaVScrollBar1.TabIndex = 4;
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
            this.testBlocksPanel.TabIndex = 3;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.blockNameTextBox);
            this.gunaElipsePanel1.Controls.Add(this.CreateButton);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(729, 34);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(20);
            this.gunaElipsePanel1.Radius = 16;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(281, 155);
            this.gunaElipsePanel1.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(22, 20);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Название тестового блока";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // blockNameTextBox
            // 
            this.blockNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.blockNameTextBox.BaseColor = System.Drawing.Color.White;
            this.blockNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.blockNameTextBox.BorderSize = 0;
            this.blockNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.blockNameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.blockNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.blockNameTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.blockNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.blockNameTextBox.Location = new System.Drawing.Point(23, 44);
            this.blockNameTextBox.MaxLength = 255;
            this.blockNameTextBox.Name = "blockNameTextBox";
            this.blockNameTextBox.PasswordChar = '\0';
            this.blockNameTextBox.Radius = 12;
            this.blockNameTextBox.SelectedText = "";
            this.blockNameTextBox.Size = new System.Drawing.Size(235, 30);
            this.blockNameTextBox.TabIndex = 14;
            // 
            // CreateButton
            // 
            this.CreateButton.Animated = true;
            this.CreateButton.AnimationHoverSpeed = 0.01F;
            this.CreateButton.AnimationSpeed = 0.001F;
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.BaseColor = System.Drawing.Color.White;
            this.CreateButton.BorderColor = System.Drawing.Color.Black;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateButton.FocusedColor = System.Drawing.Color.Empty;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.CreateButton.Image = null;
            this.CreateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CreateButton.Location = new System.Drawing.Point(60, 92);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.CreateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateButton.OnHoverImage = null;
            this.CreateButton.OnPressedColor = System.Drawing.Color.Black;
            this.CreateButton.Radius = 20;
            this.CreateButton.Size = new System.Drawing.Size(171, 40);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "Создать";
            this.CreateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(724, 1);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 30);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Новый блок";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // counterLabel
            // 
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.counterLabel.Location = new System.Drawing.Point(539, 8);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(157, 23);
            this.counterLabel.TabIndex = 15;
            this.counterLabel.Text = "0 из 0";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.counterLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(3, 1);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(217, 30);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Все тестовые блоки";
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // selectedBlockPanel
            // 
            this.selectedBlockPanel.BackColor = System.Drawing.Color.Transparent;
            this.selectedBlockPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.selectedBlockPanel.Controls.Add(this.gunaLabel4);
            this.selectedBlockPanel.Controls.Add(this.deleteButton);
            this.selectedBlockPanel.Controls.Add(this.countLabel);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel6);
            this.selectedBlockPanel.Controls.Add(this.panel1);
            this.selectedBlockPanel.Controls.Add(this.editBlockButton);
            this.selectedBlockPanel.Controls.Add(this.renameTextBox);
            this.selectedBlockPanel.Controls.Add(this.updateNameButton);
            this.selectedBlockPanel.Location = new System.Drawing.Point(729, 231);
            this.selectedBlockPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectedBlockPanel.Name = "selectedBlockPanel";
            this.selectedBlockPanel.Padding = new System.Windows.Forms.Padding(20);
            this.selectedBlockPanel.Radius = 16;
            this.selectedBlockPanel.Size = new System.Drawing.Size(281, 330);
            this.selectedBlockPanel.TabIndex = 16;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(22, 20);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Название тестового блока";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.AnimationHoverSpeed = 0.01F;
            this.deleteButton.AnimationSpeed = 0.001F;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BaseColor = System.Drawing.Color.White;
            this.deleteButton.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.deleteButton.Image = null;
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.Location = new System.Drawing.Point(50, 135);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Radius = 18;
            this.deleteButton.Size = new System.Drawing.Size(181, 40);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить блок";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.countLabel.ForeColor = System.Drawing.Color.White;
            this.countLabel.Location = new System.Drawing.Point(32, 226);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(85, 19);
            this.countLabel.TabIndex = 19;
            this.countLabel.Text = "Нет данных";
            this.countLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.LightGray;
            this.gunaLabel6.Location = new System.Drawing.Point(19, 204);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(115, 19);
            this.gunaLabel6.TabIndex = 18;
            this.gunaLabel6.Text = "Всего вопросов:";
            this.gunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Location = new System.Drawing.Point(23, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 19);
            this.panel1.TabIndex = 17;
            // 
            // editBlockButton
            // 
            this.editBlockButton.Animated = true;
            this.editBlockButton.AnimationHoverSpeed = 0.01F;
            this.editBlockButton.AnimationSpeed = 0.001F;
            this.editBlockButton.BackColor = System.Drawing.Color.Transparent;
            this.editBlockButton.BaseColor = System.Drawing.Color.White;
            this.editBlockButton.BorderColor = System.Drawing.Color.Black;
            this.editBlockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBlockButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editBlockButton.FocusedColor = System.Drawing.Color.Empty;
            this.editBlockButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBlockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.editBlockButton.Image = null;
            this.editBlockButton.ImageSize = new System.Drawing.Size(20, 20);
            this.editBlockButton.Location = new System.Drawing.Point(23, 267);
            this.editBlockButton.Name = "editBlockButton";
            this.editBlockButton.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.editBlockButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editBlockButton.OnHoverForeColor = System.Drawing.Color.White;
            this.editBlockButton.OnHoverImage = null;
            this.editBlockButton.OnPressedColor = System.Drawing.Color.Black;
            this.editBlockButton.Radius = 18;
            this.editBlockButton.Size = new System.Drawing.Size(235, 40);
            this.editBlockButton.TabIndex = 16;
            this.editBlockButton.Text = "Редактор вопросов";
            this.editBlockButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBlockButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.editBlockButton.Click += new System.EventHandler(this.editBlockButton_Click);
            // 
            // renameTextBox
            // 
            this.renameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.renameTextBox.BaseColor = System.Drawing.Color.White;
            this.renameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.renameTextBox.BorderSize = 0;
            this.renameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.renameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.renameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.renameTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.renameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.renameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.renameTextBox.Location = new System.Drawing.Point(26, 44);
            this.renameTextBox.MaxLength = 255;
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.PasswordChar = '\0';
            this.renameTextBox.Radius = 12;
            this.renameTextBox.SelectedText = "";
            this.renameTextBox.Size = new System.Drawing.Size(232, 30);
            this.renameTextBox.TabIndex = 14;
            // 
            // updateNameButton
            // 
            this.updateNameButton.Animated = true;
            this.updateNameButton.AnimationHoverSpeed = 0.01F;
            this.updateNameButton.AnimationSpeed = 0.001F;
            this.updateNameButton.BackColor = System.Drawing.Color.Transparent;
            this.updateNameButton.BaseColor = System.Drawing.Color.White;
            this.updateNameButton.BorderColor = System.Drawing.Color.Black;
            this.updateNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateNameButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateNameButton.FocusedColor = System.Drawing.Color.Empty;
            this.updateNameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateNameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.updateNameButton.Image = null;
            this.updateNameButton.ImageSize = new System.Drawing.Size(20, 20);
            this.updateNameButton.Location = new System.Drawing.Point(40, 89);
            this.updateNameButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.updateNameButton.Name = "updateNameButton";
            this.updateNameButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.updateNameButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateNameButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateNameButton.OnHoverImage = null;
            this.updateNameButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateNameButton.Radius = 18;
            this.updateNameButton.Size = new System.Drawing.Size(197, 40);
            this.updateNameButton.TabIndex = 13;
            this.updateNameButton.Text = "Переименовать";
            this.updateNameButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateNameButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.updateNameButton.Click += new System.EventHandler(this.updateNameButton_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel5.Location = new System.Drawing.Point(724, 198);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(192, 30);
            this.gunaLabel5.TabIndex = 17;
            this.gunaLabel5.Text = "Выбранный блок";
            this.gunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // RedactorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.selectedBlockPanel);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.testBlocksPanel);
            this.Name = "RedactorPage";
            this.Size = new System.Drawing.Size(1010, 564);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.selectedBlockPanel.ResumeLayout(false);
            this.selectedBlockPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipsePage;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaElipsePanel testBlocksPanel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton CreateButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox blockNameTextBox;
        private Guna.UI.WinForms.GunaLabel counterLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaElipsePanel selectedBlockPanel;
        private Guna.UI.WinForms.GunaButton updateNameButton;
        private Guna.UI.WinForms.GunaButton editBlockButton;
        public Guna.UI.WinForms.GunaLabel countLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaTextBox renameTextBox;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}
