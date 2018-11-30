using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using ScrabbleGame.Models;

namespace WordCounter.Controllers
{
    public class ScrabbleController : Controller
    {
        [HttpGet("/scrabble")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/scrabble/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/scrabble/show/")]
        public ActionResult Create(string userWord)
        {
            string word = userWord.ToUpper();
            int total = 0;
            Scrabble userScrabble = new Scrabble(word, total);
            char[] userArray = word.ToCharArray();
            foreach (char letter in userArray)
            {
                total = total + userScrabble.ScrabblePoints(letter);
            }
            userScrabble.SetTotal(total);
            return View("Show", userScrabble);
        }

        [HttpGet("/scrabble/{id}")]
        public ActionResult Show(int id)
        {
            Scrabble scrabble = Scrabble.Find(id);
            return View(scrabble);
        }
    }
}
