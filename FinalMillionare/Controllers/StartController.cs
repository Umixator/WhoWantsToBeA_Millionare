using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMillionare.Models;

namespace FinalMillionare.Controllers
{
    public class StartController : Controller
    {
        public static int questionNumber = 10;
        public ActionResult IndexV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IndexV(int qNumber)
        {
            questionNumber = qNumber;
            return View();
        }
    }
}