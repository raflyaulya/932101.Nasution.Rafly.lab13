using _932101.Nasution.Rafly.lab13.Models;

namespace _932101.Nasution.Rafly.lab13.Services
{
    public interface IQuizService
    {
        public Quiz getCurrentQuiz();
        public QuizQuestion addNewQuestion(Quiz quiz);
        public QuizQuestion getCurrentQuestion(Quiz quiz);
        public void answerLastQuestion(QuizQuestionAnswer answer, Quiz quiz);
        public void finish(Quiz quiz);
    }
}