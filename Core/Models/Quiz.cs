namespace Core
{
    public class Quiz
    {
        public int QuizId { get; }
        public List<QuestionAndAnswers> questions { get; }
        public string Title { get; }
        public Quiz(int quizId, List<QuestionAndAnswers> questions, string title)
        {
            QuizId = quizId;
            this.questions = questions;
            Title = title;
        }
    }
}
