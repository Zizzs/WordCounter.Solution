using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PalindromeGame.Models;
 
namespace Scrabble.Tests
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void PalindromeChecker_UserStringReturnsTrue_Bool()
        {
            string word = "AAA";
            bool isTrue = false;
            PalindromeClass palindrome = new PalindromeClass(word, isTrue);
            
            isTrue = PalindromeClass.PalindromeChecker(palindrome.GetWord());
            Assert.AreEqual(true, isTrue);
        }
    }
}