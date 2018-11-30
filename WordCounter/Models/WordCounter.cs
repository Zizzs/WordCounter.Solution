using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WordCounter;

namespace WordCounter.Models
{
    public class WordCounterClass
    {
        private int _total;
        private string _word;
        private string _sentence;
        private int _id;
        private static List<WordCounterClass> _instances = new List<WordCounterClass> {};

        public WordCounterClass(int total, string word, string sentence)
        {
            _total = total;
            _word = word;
            _sentence = sentence;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public int GetTotal()
        {
            return _total;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetSentence()
        {
            return _sentence;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetTotal(int total)
        {
            _total = total;
        }

        public void SetWord(string word)
        {
            _word = word;
        }

        public void SetSentence(string sentence)
        {
            _sentence = sentence;
        }

        public static WordCounterClass Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public int StringSplitWord(string inputWord, string inputString)
        {
            string[] userArr = inputString.Replace(",","").Replace(".","").Split(' ');
            foreach (string word in userArr)
            {
                FindMatch(inputWord , word);
            }
            return RepeatCounter.totalMatch;
        }
        public void FindMatch(string userWordInput, string stringWordInput)
        {
                if (userWordInput == stringWordInput)
                {
                    AddToCounter();
                    return;
                }
                else
                {
                    return;
                }
        }

        public void AddToCounter()
        {
            RepeatCounter.totalMatch++;
        }

        public static void ClearAll()
        {
            RepeatCounter.totalMatch = 0;
        }
    }

    class RepeatCounter
    {
        public static int totalMatch = 0;
    }
    
}
