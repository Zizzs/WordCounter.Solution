using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;
using ScrabbleGame.Models;
 
namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleTest
    {
        [TestMethod]
        public void ScrabblePoints_UserLetterGivesNumber_Int()
        {
            string letter = "A";
            int total = 0;
            ScrabbleClass scrabble = new ScrabbleClass(letter, total);
            char[] userArray = letter.ToCharArray();
            foreach (char temp in userArray)
            {
                total = total + scrabble.ScrabblePoints(temp);
            }
            Assert.AreEqual(1, total);
        }
    }
}