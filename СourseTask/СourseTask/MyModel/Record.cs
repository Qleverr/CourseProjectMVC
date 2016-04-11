using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseTask.MyModel
{
    class Record
    {
        private Question _question;
        private Answer[] _answers;

        public Question Question
        {
            get
            {
                return this._question;
            }
            set
            {
                this._question = value;
            }
        }
        public Answer[] Answers
        {
            get
            {
                return this._answers;
            }
            set
            {
                this._answers = value;
            }
        }

        public Record(Question q, Answer[] ans)
        {
            this.Question = q;
            this.Answers = ans;
        }
    }
}
