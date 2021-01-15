using System;
namespace QuizGrader
{
    public interface IQuestionable
    {
        void AdministerQuestion();
        double GradeQuestion();
    }
}
