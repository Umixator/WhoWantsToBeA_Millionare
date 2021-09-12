using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMillionare.Repositories;
using FinalMillionare.Models;

namespace FinalMillionare.Services
{
    public class GameRepository : IRepositoryQuestions<Question>, IRepositoryAnswers<Answer>
    {
        private QuestionsEntities qc;
        

        public GameRepository()
        {
            this.qc = new QuestionsEntities();
        }

        public Answer GetAnswer(int QId)
        {
            return qc.Answers.Find(QId);
        }

        IEnumerable<Answer> IRepositoryAnswers<Answer>.GetAnswerList()
        {
            return qc.Answers;
        }

        public Question GetQuestion(int Id)
        {
            return qc.Questions.Find(Id);
        }

        public IEnumerable<Question> GetQuestionList()
        {
            return qc.Questions;
        }
    }
}