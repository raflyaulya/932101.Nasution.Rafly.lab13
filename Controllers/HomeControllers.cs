using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _932101.Nasution.Rafly.lab13.Models;
using _932003.Tanumikhardzha.Rafael.lab13.Models;

namespace _932101.Nasution.Rafly.lab13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        static readonly Model quiz = new Model();

        public IActionResult Quiz()
        {
            quiz.SetRandomValues();
            ViewBag.Question = quiz.question;
            return View();
        }

        public IActionResult QuizResult()
        {
            ViewBag.RightAnswersCount = quiz.rightAnswersCount;
            ViewBag.AnswersCount = quiz.answersCount;
            ViewBag.Results = quiz.Results;
            return View();
        }

        [HttpPost]
        public IActionResult NextQuestion(int answer)
        {
            quiz.UpdateResults(answer);
            quiz.SetRandomValues();
            ViewBag.Question = quiz.question;
            return View("Quiz");
        }

        public IActionResult Finish(int answer)
        {
            quiz.UpdateResults(answer);
            ViewBag.RightAnswersCount = quiz.rightAnswersCount;
            ViewBag.AnswersCount = quiz.answersCount;
            ViewBag.Results = quiz.Results;
            return View("QuizResult");
        }
    }
}
