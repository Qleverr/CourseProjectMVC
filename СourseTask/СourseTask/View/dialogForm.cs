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
        private Model _model;

        public dialogForm()
        {
            this._model = new Model();
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Dialog.ReadFromFile();
        }
    }
}
