using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/wordcounter/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/wordcounter/show")]
        public ActionResult Create(string userWord, string userSentence)
        {
            string word = userWord.ToLower();
            string sentence = userSentence.ToLower();
            int total = 0;
            WordCounterClass userMatch = new WordCounterClass(total, word, sentence);
            userMatch.SetWord(word);
            userMatch.SetSentence(sentence);
            userMatch.StringSplitWord(word, sentence);
            total = RepeatCounter.totalMatch;
            userMatch.SetTotal(total);
            return View("Show", userMatch);
        }
    }
}