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
using СourseTask._De_Serializer;

namespace СourseTask.MyModel
{
    class Model
    {
        private List<Record> _elements;

        public List<Record> Elements { get { return this._elements; } }

        public Model()
        {
            this._elements = new List<Record>();
        }

        public void Add(Record element)
        {
            this._elements.Add(element);
        }

        public void OpenDialog(OpenFileDialog openFileDialog, ListBox answersList, ListBox dialogList, ListBox errorsList, TextBox questionTextBox)
        {
            {
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        XML xWork = new XML(openFileDialog.FileName);

                        questionTextBox.Clear();
                        errorsList.Items.Clear();
                        answersList.Items.Clear();
                        dialogList.Items.Clear();

                        int currNumber = 1;
                        xWork.GetQuestion(currNumber);
                        questionTextBox.Text = xWork.GetQuestion(currNumber);


                        List<string> res = xWork.GetAns(currNumber);
                        foreach (string attr in res)
                        {
                            answersList.Items.Add(attr);
                        }

                        dialogList.Items.Add(DateTime.Now + " Начало диалога...");
                    }
                    else
                        MessageBox.Show("Вы не выбрали файл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void OpenFile(OpenFileDialog openFileDialog, TabControl tabControl, ListBox listBox)
        {
            Deserializer des = new Deserializer();

            des.OpenFile(openFileDialog, tabControl, listBox);
        }

        public void CreateFile(SaveFileDialog saveFileDialog, TabControl tabControl)
        {
            Serializer ser = new Serializer();

            ser.CreateFile(saveFileDialog, tabControl);
        }
    }
}
