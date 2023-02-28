using Core;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Memory
{
    public class MemoryQuizService : IQuizService
    {
        public Dictionary<int, QuestionAndAnswers> questions = new ();
        public Dictionary<int, Quiz> quizes = new ();
        public Dictionary<int, User> users =  new ();

        public MemoryQuizService()
        {
            questions[1] = new QuestionAndAnswers(
                questionId: 1,
                answers: new List<string>() { "1441", "1409", "1412" },
                question: "Bitwa pod grunwaldem?",
                points: 5,
                correctAnswers: "1410"
                );
            questions[2] = new QuestionAndAnswers(
                questionId: 2,
                answers: new List<string>() { "1441", "1409", "1412" },
                question: "Bitwa pod grunwaldem 2?",
                points: 5,
                correctAnswers: "1410"
                );
            quizes[1] = new Quiz(quizId: 1, questions: questions.Values.ToList(), title:"Historia");
            users[1] = new User(id: 1, name: "adam");
        }

        public int CountPointsByUserAndQuiz(int userId, int quizId)
        {
            throw new NotImplementedException();
        }

        public Quiz? FindById(int id)
        {
            if (quizes.ContainsKey(id))
            {
                return quizes[id];
            }
            else
            {
                return null;
            }
            
            
        }

        public void SaveUserAnswer(UserAnswer answer)
        {
            throw new NotImplementedException();
        }
    }
}
