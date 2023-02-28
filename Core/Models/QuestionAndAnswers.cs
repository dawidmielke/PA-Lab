using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class QuestionAndAnswers
    {
        public int QuestionId { get; }
        public string Question { get; }
        public List<string> Answers { get; }
        public string CorrectAnswer { get; }
        public int Points { get; }

        public QuestionAndAnswers(int questionId, string question, List<string> answers, string correctAnswers, int points)
        {
            this.QuestionId = questionId;
            this.Question = question;
            this.Answers = answers;
            this.CorrectAnswer = correctAnswers;
            this.Points = points;
        }

    }
}
