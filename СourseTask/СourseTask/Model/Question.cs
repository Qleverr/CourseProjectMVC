using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseTask.Model
{
    class Question
    {
        private string _text;
        private string _number;

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

        public string Num 
        { 
            get 
            { 
                return this._number; 
            }
            set
            {
                this._number = value;
            }
        }

        public Question(string text, string num)
        {
            this.Text = text;
            this.Num = num;
        }
    }
}
