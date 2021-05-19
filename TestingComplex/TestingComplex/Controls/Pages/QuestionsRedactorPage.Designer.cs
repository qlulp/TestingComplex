
namespace TestingComplex.Controls.Pages
{
    partial class QuestionsRedactorPage
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
            this.pageTitleLabel = new Guna.UI.WinForms.GunaLabel();
            this.counterLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.questionsPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.selectedBlockPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.clearFieldsButton = new Guna.UI.WinForms.GunaButton();
            this.questionTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.questionIDTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.updateButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.answer4TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.answer3TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.answer2TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.answer1TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectedBlockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.pageTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pageTitleLabel.Location = new System.Drawing.Point(168, 0);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(343, 30);
            this.pageTitleLabel.TabIndex = 20;
            this.pageTitleLabel.Text = "Все вопросы";
            this.pageTitleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.pageTitleLabel.Click += new System.EventHandler(this.pageTitleLabel_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.BackColor = System.Drawing.Color.Transparent;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.counterLabel.Location = new System.Drawing.Point(507, 11);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(87, 23);
            this.counterLabel.TabIndex = 19;
            this.counterLabel.Text = "0 из 0";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.counterLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(594, 34);
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
            // questionsPanel
            // 
            this.questionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.questionsPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.questionsPanel.Location = new System.Drawing.Point(0, 34);
            this.questionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Radius = 12;
            this.questionsPanel.Size = new System.Drawing.Size(594, 530);
            this.questionsPanel.TabIndex = 17;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel5.Location = new System.Drawing.Point(612, 0);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(88, 30);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "Вопрос";
            this.gunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // selectedBlockPanel
            // 
            this.selectedBlockPanel.BackColor = System.Drawing.Color.Transparent;
            this.selectedBlockPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.selectedBlockPanel.Controls.Add(this.clearFieldsButton);
            this.selectedBlockPanel.Controls.Add(this.questionTextBox);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel8);
            this.selectedBlockPanel.Controls.Add(this.questionIDTextBox);
            this.selectedBlockPanel.Controls.Add(this.updateButton);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel7);
            this.selectedBlockPanel.Controls.Add(this.answer4TextBox);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel6);
            this.selectedBlockPanel.Controls.Add(this.answer3TextBox);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel2);
            this.selectedBlockPanel.Controls.Add(this.answer2TextBox);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel1);
            this.selectedBlockPanel.Controls.Add(this.answer1TextBox);
            this.selectedBlockPanel.Controls.Add(this.gunaLabel4);
            this.selectedBlockPanel.Controls.Add(this.deleteButton);
            this.selectedBlockPanel.Controls.Add(this.AddButton);
            this.selectedBlockPanel.Location = new System.Drawing.Point(617, 34);
            this.selectedBlockPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectedBlockPanel.Name = "selectedBlockPanel";
            this.selectedBlockPanel.Padding = new System.Windows.Forms.Padding(20);
            this.selectedBlockPanel.Radius = 16;
            this.selectedBlockPanel.Size = new System.Drawing.Size(393, 530);
            this.selectedBlockPanel.TabIndex = 21;
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Animated = true;
            this.clearFieldsButton.AnimationHoverSpeed = 0.01F;
            this.clearFieldsButton.AnimationSpeed = 0.001F;
            this.clearFieldsButton.BackColor = System.Drawing.Color.Transparent;
            this.clearFieldsButton.BaseColor = System.Drawing.Color.White;
            this.clearFieldsButton.BorderColor = System.Drawing.Color.Black;
            this.clearFieldsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearFieldsButton.FocusedColor = System.Drawing.Color.Empty;
            this.clearFieldsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFieldsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.clearFieldsButton.Image = null;
            this.clearFieldsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.clearFieldsButton.Location = new System.Drawing.Point(35, 467);
            this.clearFieldsButton.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.clearFieldsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clearFieldsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.clearFieldsButton.OnHoverImage = null;
            this.clearFieldsButton.OnPressedColor = System.Drawing.Color.Black;
            this.clearFieldsButton.Radius = 18;
            this.clearFieldsButton.Size = new System.Drawing.Size(172, 40);
            this.clearFieldsButton.TabIndex = 34;
            this.clearFieldsButton.Text = "Очистить поля";
            this.clearFieldsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearFieldsButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.questionTextBox.BaseColor = System.Drawing.Color.White;
            this.questionTextBox.BorderColor = System.Drawing.Color.Silver;
            this.questionTextBox.BorderSize = 0;
            this.questionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.questionTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.questionTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.questionTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.questionTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.questionTextBox.Location = new System.Drawing.Point(23, 89);
            this.questionTextBox.MaxLength = 255;
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.PasswordChar = '\0';
            this.questionTextBox.Radius = 12;
            this.questionTextBox.SelectedText = "";
            this.questionTextBox.Size = new System.Drawing.Size(345, 75);
            this.questionTextBox.TabIndex = 33;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(19, 27);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(116, 21);
            this.gunaLabel8.TabIndex = 32;
            this.gunaLabel8.Text = "Код вопроса:";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // questionIDTextBox
            // 
            this.questionIDTextBox.BackColor = System.Drawing.Color.Transparent;
            this.questionIDTextBox.BaseColor = System.Drawing.Color.Gainsboro;
            this.questionIDTextBox.BorderColor = System.Drawing.Color.Silver;
            this.questionIDTextBox.BorderSize = 0;
            this.questionIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.questionIDTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.questionIDTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.questionIDTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.questionIDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionIDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.questionIDTextBox.Location = new System.Drawing.Point(146, 23);
            this.questionIDTextBox.Name = "questionIDTextBox";
            this.questionIDTextBox.PasswordChar = '\0';
            this.questionIDTextBox.Radius = 12;
            this.questionIDTextBox.ReadOnly = true;
            this.questionIDTextBox.SelectedText = "";
            this.questionIDTextBox.Size = new System.Drawing.Size(217, 30);
            this.questionIDTextBox.TabIndex = 31;
            // 
            // updateButton
            // 
            this.updateButton.Animated = true;
            this.updateButton.AnimationHoverSpeed = 0.01F;
            this.updateButton.AnimationSpeed = 0.001F;
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BaseColor = System.Drawing.Color.White;
            this.updateButton.BorderColor = System.Drawing.Color.Black;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateButton.FocusedColor = System.Drawing.Color.Empty;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.updateButton.Image = null;
            this.updateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.updateButton.Location = new System.Drawing.Point(35, 415);
            this.updateButton.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.updateButton.Name = "updateButton";
            this.updateButton.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.updateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateButton.OnHoverImage = null;
            this.updateButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateButton.Radius = 18;
            this.updateButton.Size = new System.Drawing.Size(172, 40);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Обновить данные";
            this.updateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(21, 338);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel7.TabIndex = 29;
            this.gunaLabel7.Text = "Верный ответ*:";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // answer4TextBox
            // 
            this.answer4TextBox.BackColor = System.Drawing.Color.Transparent;
            this.answer4TextBox.BaseColor = System.Drawing.Color.White;
            this.answer4TextBox.BorderColor = System.Drawing.Color.Silver;
            this.answer4TextBox.BorderSize = 0;
            this.answer4TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer4TextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.answer4TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.answer4TextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer4TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer4TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer4TextBox.Location = new System.Drawing.Point(24, 362);
            this.answer4TextBox.MaxLength = 255;
            this.answer4TextBox.Name = "answer4TextBox";
            this.answer4TextBox.PasswordChar = '\0';
            this.answer4TextBox.Radius = 12;
            this.answer4TextBox.SelectedText = "";
            this.answer4TextBox.Size = new System.Drawing.Size(344, 30);
            this.answer4TextBox.TabIndex = 28;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(21, 281);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Неверный ответ 3:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.BackColor = System.Drawing.Color.Transparent;
            this.answer3TextBox.BaseColor = System.Drawing.Color.White;
            this.answer3TextBox.BorderColor = System.Drawing.Color.Silver;
            this.answer3TextBox.BorderSize = 0;
            this.answer3TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer3TextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.answer3TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.answer3TextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer3TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer3TextBox.Location = new System.Drawing.Point(25, 305);
            this.answer3TextBox.MaxLength = 255;
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.PasswordChar = '\0';
            this.answer3TextBox.Radius = 12;
            this.answer3TextBox.SelectedText = "";
            this.answer3TextBox.Size = new System.Drawing.Size(343, 30);
            this.answer3TextBox.TabIndex = 26;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(19, 224);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel2.TabIndex = 25;
            this.gunaLabel2.Text = "Неверный ответ 2:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.BackColor = System.Drawing.Color.Transparent;
            this.answer2TextBox.BaseColor = System.Drawing.Color.White;
            this.answer2TextBox.BorderColor = System.Drawing.Color.Silver;
            this.answer2TextBox.BorderSize = 0;
            this.answer2TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer2TextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.answer2TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.answer2TextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer2TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer2TextBox.Location = new System.Drawing.Point(23, 248);
            this.answer2TextBox.MaxLength = 255;
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.PasswordChar = '\0';
            this.answer2TextBox.Radius = 12;
            this.answer2TextBox.SelectedText = "";
            this.answer2TextBox.Size = new System.Drawing.Size(345, 30);
            this.answer2TextBox.TabIndex = 24;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 167);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel1.TabIndex = 23;
            this.gunaLabel1.Text = "Неверный ответ 1:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.BackColor = System.Drawing.Color.Transparent;
            this.answer1TextBox.BaseColor = System.Drawing.Color.White;
            this.answer1TextBox.BorderColor = System.Drawing.Color.Silver;
            this.answer1TextBox.BorderSize = 0;
            this.answer1TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer1TextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.answer1TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.answer1TextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer1TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.answer1TextBox.Location = new System.Drawing.Point(23, 191);
            this.answer1TextBox.MaxLength = 255;
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.PasswordChar = '\0';
            this.answer1TextBox.Radius = 12;
            this.answer1TextBox.SelectedText = "";
            this.answer1TextBox.Size = new System.Drawing.Size(345, 30);
            this.answer1TextBox.TabIndex = 22;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(19, 65);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(236, 21);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Вопрос:";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.deleteButton.Location = new System.Drawing.Point(224, 467);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Radius = 18;
            this.deleteButton.Size = new System.Drawing.Size(144, 40);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.AnimationHoverSpeed = 0.01F;
            this.AddButton.AnimationSpeed = 0.001F;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BaseColor = System.Drawing.Color.White;
            this.AddButton.BorderColor = System.Drawing.Color.Black;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.AddButton.Image = null;
            this.AddButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButton.Location = new System.Drawing.Point(224, 415);
            this.AddButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(203)))), ((int)(((byte)(108)))));
            this.AddButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddButton.OnHoverImage = null;
            this.AddButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddButton.Radius = 18;
            this.AddButton.Size = new System.Drawing.Size(139, 40);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(508, 30);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Все вопросы";
            this.titleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // QuestionsRedactorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.selectedBlockPanel);
            this.Controls.Add(this.pageTitleLabel);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.questionsPanel);
            this.Name = "QuestionsRedactorPage";
            this.Size = new System.Drawing.Size(1010, 564);
            this.selectedBlockPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel pageTitleLabel;
        private Guna.UI.WinForms.GunaLabel counterLabel;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaElipsePanel selectedBlockPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaButton AddButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI.WinForms.GunaTextBox answer4TextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI.WinForms.GunaTextBox answer3TextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox answer2TextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaTextBox answer1TextBox;
        private Guna.UI.WinForms.GunaButton updateButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        public Guna.UI.WinForms.GunaTextBox questionIDTextBox;
        public Guna.UI.WinForms.GunaTextBox questionTextBox;
        public Guna.UI.WinForms.GunaElipsePanel questionsPanel;
        private Guna.UI.WinForms.GunaButton clearFieldsButton;
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
