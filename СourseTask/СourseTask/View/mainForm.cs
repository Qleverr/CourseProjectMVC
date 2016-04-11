using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СourseTask.HelpfulTools;

namespace СourseTask
{
    public partial class mainForm : Form
    {
        public delegate void UserEventHandler();

        public event UserEventHandler OpenDialog;
        public event UserEventHandler ToAnswer;
        

        public mainForm()
        {
            InitializeComponent();
        }

        private void answersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToAnswer();
        }

        private void toDialogForm_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogForm dialogForm = new dialogForm();
            dialogForm.ShowDialog();
        }

        private void openDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        public SaveFileDialog GetSaveFileDialog()
        {
            return this.saveFileDialog1;
        }

        public OpenFileDialog GetOpenFileDialog()
        {
            return this.openFileDialog1;
        }

        public ListBox GetDialogListBox()
        {
            return this.dialogList;
        }

        public ListBox GetAnsListBox()
        {
            return this.answersList;
        }

        public ListBox GetErrorsListBox()
        {
            return this.errorsList;
        }

        public TextBox GetQuestionTextBox()
        {
            return this.questionTextBox;
        }

    }
}
