using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using PalindromeGame.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class PalindromeControllerTests
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
            PalindromeController controller = new PalindromeController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show__ReturnsCorrectView_True()
        {
             //Arrange
            PalindromeController controller = new PalindromeController();
            int id = 1;
            string word = "dog";
            bool isTrue = false;
            PalindromeClass palindrome = new PalindromeClass(word, isTrue);

            //Act
            ActionResult newView = controller.Show(id);

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_PalindromeClass()
        {
            //Arrange
            int id = 1;
            string word = "dog";
            bool isTrue = true;
            PalindromeClass scrabble = new PalindromeClass(word, isTrue);
            ViewResult showView = new PalindromeController().Show(id) as ViewResult;

            //Act
            var result = showView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(PalindromeClass));
        }
    }
}
