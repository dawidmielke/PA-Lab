using Core.Interfaces;
using Infrastructure.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class MemoryQuizServiceTest
    {
        public IQuizService service = new MemoryQuizService();

        [Fact]
        public void GetQuizTest()
        {
            Core.Quiz quiz = service.FindById(1);
            Assert.Equal(1, quiz.QuizId);
        }

        [Fact]
        public void IsQuizNull()
        {
            var quiz2 = service.FindById(2);
            Assert.Null(quiz2);
        }
    }
}
