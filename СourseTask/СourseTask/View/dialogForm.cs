using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СourseTask.Model;

namespace СourseTask
{
    public partial class dialogForm : Form
    {
        private Dialog _dialog;

        public dialogForm()
        {
            this._dialog = new Dialog();
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        //private void openButton_Click(object sender, EventArgs e)
        //{
        //    Dialog.ReadFromFile();
        //}

        public string GetInnerQuestion()
        {
            return this.questionTextBox2.Text.ToString();
        }

        public void AddQuestionToList(string question)
        {
            this.questionTextBox.Text = question;
        }
    }
}
