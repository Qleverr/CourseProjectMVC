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

namespace СourseTask
{
    class Model
    {
        private XMLDesigner workFile;

        public Model()
        {
        }

        private void CreateFile(SaveFileDialog saveFileDialog, TabControl tabControl)
        {
            string pathToFile = String.Empty;
            saveFileDialog.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = saveFileDialog.FileName;
                workFile = new XMLDesigner(pathToFile);
                tabControl.Enabled = true;
            }
            else
                MessageBox.Show("Файл не сохранен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Ok");
        }

        public void OpenFile(OpenFileDialog openFileDialog, TabControl tabControl, ListBox listBox)
        {
            string pathToFile = String.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = openFileDialog.FileName;

                workFile = new XMLDesigner(pathToFile);
                tabControl.Enabled = true;
                RefreshList(listBox);
            }
            else
                MessageBox.Show("Файл не выбран!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RefreshList(ListBox listBox)
        {
            List<string[]> resultedList;
            resultedList = workFile.GetAllQuestions();

            listBox.Items.Clear();

            foreach (string[] query in resultedList)
            {
                listBox.Items.Add("Вопрос: " + query[0] + "; " + "Номер состояния: " + query[1]);
            }
        }
    }
}
