using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMillionare.Repositories
{
    interface IRepositoryQuestions<Question> : IRepositoryAnswers<Answer>
    {
        IEnumerable<Question> GetQuestionList(); // получение всех объектов
        Question GetQuestion(int Id); // получение одного объекта по id
    }
}