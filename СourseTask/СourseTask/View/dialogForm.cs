using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СourseTask
{
    public partial class dialogForm : Form
    {
        public delegate void UserEventHandler();

        public event UserEventHandler AddQuestion;
        public event UserEventHandler OpenFile;
        public event UserEventHandler CreateFile;

        public bool _openFile = false;
        public bool _addQuestion = false;

        public dialogForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        public string GetInnerQuestion()
        {
            return this.questionTextBox2.Text.ToString();
        }

        public void AddQuestionToList(string question)
        {
            this.dialogListBox.Items.Add(question);
        }

        public void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }

        public SaveFileDialog GetSaveFileDialog()
        {
            return this.saveFileDialog1;
        }

        public OpenFileDialog GetOpenFileDialog()
        {
            return this.openFileDialog1;
        }

        public TabControl GetTabConstrol()
        {
            return this.tabControl;
        }

        public ListBox GetListBox()
        {
            return this.dialogListBox;
        }
    }
}
