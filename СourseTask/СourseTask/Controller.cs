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
using СourseTask.MyModel;

namespace СourseTask
{
    class Controller
    {
        private Model _model;
        private mainForm _view;
        private XML _xWork;

        public Controller(mainForm view)
        {
            this._view = view;
            this._view.OpenDialog += OpenDialog;
            this._view.ToAnswer += NextQuestion;
            //this._view.AddQuestion += AddQuestionFromTextBoxToList;
            //this._view.OpenFile += OnOpenFile;
            //this._view.CreateFile += CreateFile;
            this._model = new Model();
        }

        private void NextQuestion()
        {
            int currentNum = 1;
            _view.GetDialogListBox().Items.Add("Вопрос: " + _view.GetQuestionTextBox().Text);
            _view.GetDialogListBox().Items.Add("Ответ: " + _view.GetAnsListBox().SelectedItem.ToString());
            currentNum = _xWork.CheckAnswer(currentNum, _view.GetAnsListBox().SelectedItem.ToString());
            _view.GetQuestionTextBox().Text = _xWork.GetQuestion(currentNum);
            _view.GetAnsListBox().Items.Clear();

            UpdateAnsList(currentNum);
        }

        private void UpdateAnsList(int number)
        {
            List<string> res = _xWork.GetAns(number);
            _view.GetAnsListBox().Items.Clear();
            foreach (string attr in res)
            {
                _view.GetAnsListBox().Items.Add(attr.Trim());
            }
        }

        private void OpenDialog()
        {
            this._model.OpenDialog(_view.GetOpenFileDialog(), _view.GetAnsListBox(), _view.GetDialogListBox(),
                                    _view.GetErrorsListBox(), _view.GetQuestionTextBox());
        }

        //private void CreateFile()
        //{
        //    _model.CreateFile(_view.GetSaveFileDialog(), _view.GetTabConstrol());
        //}

        //private void OnOpenFile()
        //{
        //    _model.OpenFile(_view.GetOpenFileDialog(), _view.GetTabConstrol(), _view.GetListBox());
        //}

        public Record GetRecordByNumber(string num)
        {
            foreach (Record rec in this._model.Elements)
            {
                if (rec.Question.Num == num)
                    return rec;
            }
            MessageBox.Show("Такого вопроса не существует.", "Ошибка!");
            return new Record(new Question("Не найдено.", "-1"), new Answer[0]);
        }

        //private void AddQuestionFromTextBoxToList()
        //{
        //    this._view.AddQuestionToList(this._view.GetInnerQuestion());
        //}
    }
}
