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
using СourseTask.Model;
using СourseTask.HelpfulTools;

namespace СourseTask
{
    class Controller
    {
        private Dialog _dialog;
        private dialogForm _view;

        public Controller(dialogForm view)
        {
            this._view = view;
            this._dialog = new Dialog();
            //this._view.OpenDialog += new EventHandler<EventArgs> OnOpenDialog();
        }

        public void AddRecord(Record record)
        {
            this._dialog.Elements.Add(record);
        }

        public Record GetRecordByNumber(string num)
        {
            foreach (Record rec in this._dialog.Elements)
            {
                if (rec.Question.Num == num)
                    return rec;
            }
            MessageBox.Show("Такого вопроса не существует.", "Ошибка!");
            return new Record(new Question("Не найдено.", "-1"), new Answer[0]);
        }

        private void AddQuestionFromTextBoxToList()
        {
            this._view.AddQuestionToList(this._view.GetInnerQuestion());
        }
    }
}
