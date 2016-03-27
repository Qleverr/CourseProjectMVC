namespace СourseTask
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.answersList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorsList = new System.Windows.Forms.ListBox();
            this.dialogList = new System.Windows.Forms.ListBox();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьСистемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDialogForm_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qbox = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.qbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(267, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ход диалога";
            // 
            // answersList
            // 
            this.answersList.Location = new System.Drawing.Point(12, 102);
            this.answersList.Name = "answersList";
            this.answersList.Size = new System.Drawing.Size(246, 173);
            this.answersList.TabIndex = 17;
            this.answersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.answersList_MouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorsList
            // 
            this.errorsList.FormattingEnabled = true;
            this.errorsList.Location = new System.Drawing.Point(12, 303);
            this.errorsList.Name = "errorsList";
            this.errorsList.Size = new System.Drawing.Size(644, 69);
            this.errorsList.TabIndex = 20;
            // 
            // dialogList
            // 
            this.dialogList.FormattingEnabled = true;
            this.dialogList.Location = new System.Drawing.Point(270, 102);
            this.dialogList.Name = "dialogList";
            this.dialogList.Size = new System.Drawing.Size(386, 173);
            this.dialogList.TabIndex = 21;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // закрытьСистемуToolStripMenuItem
            // 
            this.закрытьСистемуToolStripMenuItem.Name = "закрытьСистемуToolStripMenuItem";
            this.закрытьСистемуToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            // 
            // saveDialogToolStripMenuItem
            // 
            this.saveDialogToolStripMenuItem.Name = "saveDialogToolStripMenuItem";
            this.saveDialogToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.saveDialogToolStripMenuItem.Text = "Сохранить ход диалога";
            // 
            // openDialogToolStripMenuItem
            // 
            this.openDialogToolStripMenuItem.Name = "openDialogToolStripMenuItem";
            this.openDialogToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.openDialogToolStripMenuItem.Text = "Открыть файл диалога";
            // 
            // toDialogForm_ToolStripMenuItem
            // 
            this.toDialogForm_ToolStripMenuItem.Name = "toDialogForm_ToolStripMenuItem";
            this.toDialogForm_ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.toDialogForm_ToolStripMenuItem.Text = "Работа со сценарием диалога";
            this.toDialogForm_ToolStripMenuItem.Click += new System.EventHandler(this.toDialogForm_ToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDialogForm_ToolStripMenuItem,
            this.openDialogToolStripMenuItem,
            this.saveDialogToolStripMenuItem,
            this.закрытьСистемуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qbox
            // 
            this.qbox.Controls.Add(this.questionTextBox);
            this.qbox.Location = new System.Drawing.Point(12, 27);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(644, 56);
            this.qbox.TabIndex = 18;
            this.qbox.TabStop = false;
            this.qbox.Text = "Вопрос";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(6, 19);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(623, 20);
            this.questionTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Варианты ответа";
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorsLabel.Location = new System.Drawing.Point(15, 287);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(121, 13);
            this.errorsLabel.TabIndex = 25;
            this.errorsLabel.Text = "Сообщения об ошибке";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 387);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answersList);
            this.Controls.Add(this.errorsList);
            this.Controls.Add(this.dialogList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.qbox);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Курсовой проект";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.qbox.ResumeLayout(false);
            this.qbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox answersList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox errorsList;
        private System.Windows.Forms.ListBox dialogList;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьСистемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDialogForm_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox qbox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorsLabel;

    }
}

