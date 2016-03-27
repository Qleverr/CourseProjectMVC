using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace СourseTask.HelpfulTools
{
    class XML
    {
        private string pathToFile;

        public XML(string filePath)
        {
            pathToFile = filePath;
        }

        public string GetQuestion(int number)
        {
            XDocument xDoc = XDocument.Load(pathToFile);

            var result = xDoc.Root.Elements("question").Single(t => Int32.Parse(t.Attribute("number").Value) == number);

            return result.Element("text").Value;
        }


        public List<string> GetAns(int number)
        {
            XDocument xDoc = XDocument.Load(pathToFile);

            var result = xDoc.Root.Elements("question").Single(t => Int32.Parse(t.Attribute("number").Value) == number);

            var answers = result.Element("answers");

            List<string> resultedList = new List<string>();

            foreach (var answer in answers.Elements())
            {
                resultedList.Add(answer.Value);
            }

            return resultedList;
        }

        public int CheckAnswer(int number, string userAnswer)
        {
            XDocument xDoc = XDocument.Load(pathToFile);

            try
            {
                var result = xDoc.Root.Elements("question").Single(t => Int32.Parse(t.Attribute("number").Value) == number).Element("answers").Elements("answer").Single(t => t.Value.ToLower() == userAnswer.ToLower());
                return Int32.Parse(result.Attribute("nextquestion").Value);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
