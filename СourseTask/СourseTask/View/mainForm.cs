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
    public partial class mainForm : Form
    {
        //private Controller _controller;

        public mainForm()
        {
            InitializeComponent();
        }

        //public void SetController(Controller controller)
        //{
        //    this._controller = controller;
        //}

        private void answersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toDialogForm_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogForm dialogForm = new dialogForm();
            dialogForm.ShowDialog();
        }

        //private void openDialogToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    OpenDialog();
        //}
    }
}
