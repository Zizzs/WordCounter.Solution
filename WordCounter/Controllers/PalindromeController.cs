using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PalindromeGame.Models;


namespace WordCounter.Controllers
{
    public class PalindromeController : Controller
    {
        [HttpGet("/palindrome")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/palindrome/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/palindrome/show/")]
        public ActionResult Create(string userWord)
        {
            bool isTrue = false;
            PalindromeClass palindrome = new PalindromeClass(userWord, isTrue);
            isTrue = PalindromeClass.PalindromeChecker(palindrome.GetWord());
            palindrome.SetTrue(isTrue);
            return View("Show", palindrome);
        }

        [HttpGet("/palindrome/{id}")]
        public ActionResult Show(int id)
        {
            PalindromeClass scrabble = PalindromeClass.Find(id);
            return View(scrabble);
        }
    }
}
