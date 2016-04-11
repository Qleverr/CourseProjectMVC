using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseTask.MyModel
{
    class Answer
    {
        private string _text;
        private string _nextNumber;

        public string Text
        { 
            get 
            { 
                return this._text; 
            }
            set
            {
                if (value.Length > 0)
                    this._text = value;
            }
        }

        public string NextNum 
        { 
            get 
            { 
                return this._nextNumber; 
            }
            set
            {
                this._nextNumber = value;
            }
        }

        public Answer(string text, string nextNum)
        {
            this.Text = text;
            this.NextNum = nextNum;
        }
    }
}
