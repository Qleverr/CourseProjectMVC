using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Data.Sql;

namespace СourseTask
{
    class Controller
    {
        private Model _model;

        public Controller()
        {
            this._model = new Model();
        }

        public void OpenFile()
        {
            this._model.OpenFile()
        }
    }
}
