using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class UserAnswer
    {
        public string Answer { get; }
        public QuestionAndAnswers QuestionAndAnswers { get; }
        public int QuizId { get; }
        public int UserId { get; }

        public bool IsCorrectAnswer()
        {
            throw new NotImplementedException();
        }
    }
}
