using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WordCounter;

namespace WordCounter.Models
{
    public class WordCounterClass
    {
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
