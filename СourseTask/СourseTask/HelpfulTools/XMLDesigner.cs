using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace СourseTask.HelpfulTools
{
    class XMLDesigner
    {
        private string filePathContainer;


        public XMLDesigner(string pathToFile)
        {
            if (!File.Exists(pathToFile))
            {
                XDocument xDoc = new XDocument(new XElement("body"));
                xDoc.Save(pathToFile);
            }
            filePathContainer = pathToFile;
        }

        public List<string[]> GetAllQuestions()
        {
            XDocument xDoc = XDocument.Load(filePathContainer);

            List<string[]> queryResult = new List<string[]>();

            string[] temp = new string[2];
            foreach (XElement el in xDoc.Root.Elements())
            {
                temp[0] = el.Element("text").Value;
                temp[1] = el.Attribute("number").Value;

                queryResult.Add(new string[2] { temp[0], temp[1] });
            }

            return queryResult;
        }

        public void AddQuestionByNumber(string questText, List<string[]> answers, int number)
        {
            XDocument xDoc = XDocument.Load(filePathContainer);
            XElement question = new XElement("question", new XElement("text", questText), new XAttribute("number", number));
            XElement answersContainer = new XElement("answers");

            foreach (string[] attr in answers)
            {
                answersContainer.Add(new XElement("answer", attr[1], new XAttribute("nextquestion", Int32.Parse(attr[0]))));
            }

            question.Add(answersContainer);
            xDoc.Root.Add(question);
            xDoc.Save(filePathContainer);
        }

        public void AddQuestion(string questText, List<string[]> answers)
        {
            XDocument xDoc = XDocument.Load(filePathContainer);
            int maxNum;
            try
            {
                maxNum = xDoc.Root.Elements("question").Max(t => Int32.Parse(t.Attribute("number").Value));
            }
            catch (Exception)
            {
                maxNum = 0;
            }
            AddQuestionByNumber(questText, answers, maxNum + 1);
        }

        public string GetTextByQuestionNumber(int number)
        {
            XDocument xDoc = XDocument.Load(filePathContainer);

            var result = xDoc.Root.Elements("question").Single(t => Int32.Parse(t.Attribute("number").Value) == number);

            return result.Element("text").Value;
        }

        public List<string[]> GetAnswersInformationByQuestionNumber(int number)
        {
            XDocument xDoc = XDocument.Load(filePathContainer);

            var result = xDoc.Root.Elements("question").Single(t => Int32.Parse(t.Attribute("number").Value) == number);

            var answers = result.Element("answers");

            List<string[]> resultedList = new List<string[]>();

            string[] temp = new string[2];

            foreach (var answer in answers.Elements())
            {
                temp[0] = answer.Attribute("nextquestion").Value;
                temp[1] = answer.Value;
                resultedList.Add(new string[2] { temp[1], temp[0] });
            }

            return resultedList;
        }

        public void DeleteNodesByNumber(int number)
        {
            XDocument xDoc = XDocument.Load(filePathContainer);

            var result = xDoc.Root.Elements("question").Single(t => Int32.Parse(t.Attribute("number").Value) == number);
            result.Remove();

            xDoc.Save(filePathContainer);
        }
    }
}
