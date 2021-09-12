using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMillionare.Repositories
{
    interface IRepositoryAnswers<Answer>
    {
        IEnumerable<Answer> GetAnswerList(); // получение всех объектов
        Answer GetAnswer(int QId); // получение одного объекта по id
    }
}