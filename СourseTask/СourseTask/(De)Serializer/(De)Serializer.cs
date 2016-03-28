using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СourseTask.HelpfulTools;

namespace СourseTask._De_Serializer
{
    class _De_Serializer
    {
        private void SaveFile(SaveFileDialog saveFileDialog, TabControl tabControl)
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
