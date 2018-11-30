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

        [HttpPost("/wordcounter/show/")]
        public ActionResult Create(string userWord, string userSentence)
        {
            string word = userWord.ToLower();
            string sentence = userSentence.ToLower();
            int total = 0;
            WordCounterClass userMatch = new WordCounterClass(total, word, sentence);
            WordCounterClass.ClearAll();
            userMatch.SetWord(word);
            userMatch.SetSentence(sentence);
            userMatch.StringSplitWord(word, sentence);
            total = RepeatCounter.totalMatch;
            userMatch.SetTotal(total);
            return View("Show", userMatch);
        }

        [HttpGet("/wordcounter/{id}")]
        public ActionResult Show(int id)
        {
            WordCounterClass wordcounter = WordCounterClass.Find(id);
            return View(wordcounter);
        }
    }
}