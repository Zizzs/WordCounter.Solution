using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show__ReturnsCorrectView_True()
        {
             //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_WordCounterObject()
        {
            //Arrange
            int id = 1;
            int total = 2;
            string word = "dog";
            string sentence = "dog dog";
            WordCounterClass wordcounter = new WordCounterClass(total, word, sentence);
            ViewResult showView = new WordCounterController().Show(id) as ViewResult;

            //Act
            var result = showView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(WordCounterClass));
        }

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            string word = "dog";
            string sentence = "dog dog";
            WordCounterController controller = new WordCounterController();

            //Act
            IActionResult view = controller.Create(word, sentence);

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }
    }
}
