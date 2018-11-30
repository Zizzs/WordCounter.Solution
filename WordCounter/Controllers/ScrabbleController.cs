using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class ScrabbleController : Controller
    {
        [HttpGet("/scrabble")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
