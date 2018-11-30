using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;
 
namespace WordCounter.Tests
{
    namespace WordCounter.Tests
    {
        [TestClass]
        public class WordCounterTest : IDisposable
        {
            public void Dispose()
            {
                WordCounterClass.ClearAll();
            }

            [TestMethod]
            public void StringSplitWord_UserwordMatchesWord_Int()
            {
                int total = 0;
                string word = "dog";
                string sentence = "dog dog";
                WordCounterClass testString = new WordCounterClass(total, word, sentence);
                WordCounterClass.ClearAll();
                Assert.AreEqual(1, testString.StringSplitWord("a", "a"));
            }

            [TestMethod]
            public void StringSplitWord_UserwordMatchesString_int()
            {
                int total = 0;
                string word = "dog";
                string sentence = "dog dog";
                WordCounterClass testString = new WordCounterClass(total, word, sentence);
                Assert.AreEqual(2, testString.StringSplitWord(word, sentence));
            }

            [TestMethod]
            public void StringSplitWord_UserwordMatchesLongString_int()
            {
                int total = 0;
                string word = "dog";
                string sentence = "dog dog dog";
                WordCounterClass testString = new WordCounterClass(total, word, sentence);
                Assert.AreEqual(3, testString.StringSplitWord(word, sentence));
            }
        }
    }
}
