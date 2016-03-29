namespace СourseTask
{
    partial class dialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage tabPage2;
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTextBox2 = new System.Windows.Forms.TextBox();
            this.answerLabel2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.dialogListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.answerText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auestionsLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.createButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.workWithFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.workWithFilesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(this.buttonAddQuestion);
            tabPage2.Controls.Add(this.label5);
            tabPage2.Controls.Add(this.dataGridView2);
            tabPage2.Controls.Add(this.questionTextBox2);
            tabPage2.Controls.Add(this.answerLabel2);
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(446, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(137, 306);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(143, 28);
            this.buttonAddQuestion.TabIndex = 10;
            this.buttonAddQuestion.TabStop = false;
            this.buttonAddQuestion.Text = "Добавить вопрос";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ответы";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(10, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(421, 226);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Варианты ответов";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер следующего вопроса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // questionTextBox2
            // 
            this.questionTextBox2.Location = new System.Drawing.Point(10, 35);
            this.questionTextBox2.Name = "questionTextBox2";
            this.questionTextBox2.Size = new System.Drawing.Size(421, 20);
            this.questionTextBox2.TabIndex = 1;
            // 
            // answerLabel2
            // 
            this.answerLabel2.AutoSize = true;
            this.answerLabel2.Location = new System.Drawing.Point(21, 19);
            this.answerLabel2.Name = "answerLabel2";
            this.answerLabel2.Size = new System.Drawing.Size(44, 13);
            this.answerLabel2.TabIndex = 0;
            this.answerLabel2.Text = "Вопрос";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.delButton);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.changeButton);
            this.tabPage1.Controls.Add(this.dialogListBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.auestionsLabel);
            this.tabPage1.Controls.Add(this.answerLabel);
            this.tabPage1.Controls.Add(this.questionTextBox);
            this.tabPage1.Controls.Add(this.applyButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Enabled = false;
            this.delButton.Location = new System.Drawing.Point(222, 298);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 30);
            this.delButton.TabIndex = 11;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(328, 298);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 30);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(10, 298);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 30);
            this.changeButton.TabIndex = 9;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // dialogListBox
            // 
            this.dialogListBox.Location = new System.Drawing.Point(10, 6);
            this.dialogListBox.Name = "dialogListBox";
            this.dialogListBox.Size = new System.Drawing.Size(422, 82);
            this.dialogListBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answerText,
            this.nextQuestion});
            this.dataGridView1.Location = new System.Drawing.Point(10, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(422, 146);
            this.dataGridView1.TabIndex = 7;
            // 
            // answerText
            // 
            this.answerText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.answerText.HeaderText = "Варианты ответов";
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            // 
            // nextQuestion
            // 
            this.nextQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nextQuestion.HeaderText = "Номер следующего вопроса";
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.ReadOnly = true;
            // 
            // auestionsLabel
            // 
            this.auestionsLabel.AutoSize = true;
            this.auestionsLabel.Location = new System.Drawing.Point(18, 130);
            this.auestionsLabel.Name = "auestionsLabel";
            this.auestionsLabel.Size = new System.Drawing.Size(45, 13);
            this.auestionsLabel.TabIndex = 6;
            this.auestionsLabel.Text = "Ответы";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(18, 91);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(44, 13);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.Text = "Вопрос";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(10, 107);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(422, 20);
            this.questionTextBox.TabIndex = 4;
            // 
            // applyButton
            // 
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.applyButton.Location = new System.Drawing.Point(116, 298);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 30);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(tabPage2);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(12, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(454, 363);
            this.tabControl.TabIndex = 10;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(111, 26);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Создать файл";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(123, 19);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(111, 26);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Открыть файл";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // workWithFilesGroupBox
            // 
            this.workWithFilesGroupBox.Controls.Add(this.openButton);
            this.workWithFilesGroupBox.Controls.Add(this.createButton);
            this.workWithFilesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.workWithFilesGroupBox.Name = "workWithFilesGroupBox";
            this.workWithFilesGroupBox.Size = new System.Drawing.Size(240, 53);
            this.workWithFilesGroupBox.TabIndex = 11;
            this.workWithFilesGroupBox.TabStop = false;
            this.workWithFilesGroupBox.Text = "Работа с файлами";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 459);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.workWithFilesGroupBox);
            this.Controls.Add(this.tabControl);
            this.Name = "dialogForm";
            this.Text = "dialogForm";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.workWithFilesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox questionTextBox2;
        private System.Windows.Forms.Label answerLabel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ListBox dialogListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerText;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextQuestion;
        private System.Windows.Forms.Label auestionsLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox workWithFilesGroupBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}