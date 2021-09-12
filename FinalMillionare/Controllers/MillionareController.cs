using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMillionare.Models;
using FinalMillionare.Services;
using FinalMillionare.Repositories;
using FinalMillionare.Controllers;

namespace FinalMillionare.Controllers
{
    public class MillionareController : Controller
    {
        IRepositoryQuestions<Question> qc;
        public static int counter = 1;
        public static int answerCounter = -1;
        public static int questionNumber = StartController.questionNumber;


        public MillionareController()
        {
            qc = new GameRepository();
        }

        public ActionResult Gaming(StoredData s)
        {
            var Answerr = new Dictionary<string, byte>() { { "", 0 } };
            s.StoredQuestions = new Dictionary<string, Dictionary<string, byte>> { { "", Answerr } };
            counter = 1;
            answerCounter = -1;

            QDict(s);
            return View(s);
        }

        [HttpPost]
        public ActionResult Gaming(string Working)
        {
            StoredData s = new StoredData();
            var Answerr = new Dictionary<string, byte>();
            s.StoredAnswers = Answerr;
            s.StoredQuestions = new Dictionary<string, Dictionary<string, byte>> { { "", Answerr } };

            QDict(s);

            counter += 1;
            answerCounter += 4;
            s.CurId = counter;
            s.Step = answerCounter;

            if (s.StoredAnswers[s.StoredAnswers.Keys.FirstOrDefault(Working.Contains)] == 0)
            {
                return View("GameOver", s);
            }

            return View(s);
        }

        public void QDict(StoredData s)
        {
            GetAnswers(s);

            foreach (Question i in qc.GetQuestionList())
            {           
                s.StoredQuestions.Add((qc.GetQuestion(i.Id).Question1), s.StoredAnswers);
            }

        }

        public void GetAnswers(StoredData s)
        {
            foreach (Answer i in qc.GetAnswerList().Where(n => n.QId == n.Question.Id))
            {
                s.StoredAnswers.Add(i.Answer1, i.Validity);
            }
              
        }
    }
}