using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IQuizService
    {
        Quiz? FindById(int id);
        void SaveUserAnswer(UserAnswer answer);
        int CountPointsByUserAndQuiz(int userId, int quizId);

    }
}
