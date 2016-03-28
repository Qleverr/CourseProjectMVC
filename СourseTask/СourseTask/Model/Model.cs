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
    class Model
    {
        private List<Record> _dialog;

        public Model()
        {
            this._dialog = new List<Record>();
        }

        public void AddRecord(Record record)
        {
            this._dialog.Add(record);
        }

        public Record GetRecordByNumber(string num)
        {
            foreach (Record rec in this._dialog)
            {
                if (rec.Question.Num == num)
                    return rec;
            }
            return new Record(new Question("Не найдено.", "-1"), new Answer[0]);
        }     
    }
}
