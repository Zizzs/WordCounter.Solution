using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using ScrabbleGame.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class ScrabbleControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            //Arrange
            ScrabbleController controller = new ScrabbleController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show__ReturnsCorrectView_True()
        {
             //Arrange
            ScrabbleController controller = new ScrabbleController();
            int id = 1;
            int total = 2;
            string word = "dog";
            ScrabbleClass scrabble = new ScrabbleClass(word, total);

            //Act
            ActionResult newView = controller.Show(id);

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_ScrabbleObject()
        {
            //Arrange
            int id = 1;
            int total = 2;
            string word = "dog";
            ScrabbleClass scrabble = new ScrabbleClass(word, total);
            ViewResult showView = new ScrabbleController().Show(id) as ViewResult;

            //Act
            var result = showView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(ScrabbleClass));
        }
    }
}
