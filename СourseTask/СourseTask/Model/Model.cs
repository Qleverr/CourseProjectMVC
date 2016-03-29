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
using СourseTask.HelpfulTools;

namespace СourseTask.Model
{
    class Dialog
    {
        private List<Record> _elements;

        public List<Record> Elements { get { return this._elements; } }

        public Dialog()
        {
            this._elements = new List<Record>();
        }     
    }
}
