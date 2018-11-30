using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeGame.Models
{
    public class PalindromeClass
    {
        private string _word;
        private bool _isTrue;
        private int _id;
        public static List<PalindromeClass> _instances = new List<PalindromeClass> {};

        public PalindromeClass(string word, bool isTrue)
        {
            _word = word;
            _isTrue = isTrue;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public void SetWord(string word)
        {
            _word = word;
        }

        public void SetTrue(bool isTrue)
        {
            _isTrue = isTrue;
        }

        public string GetWord()
        {
            return _word;
        }

        public bool GetTrue()
        {
            return _isTrue;
        }

        public static bool PalindromeChecker(string userInput)
        {
            char[] cArray = userInput.ToCharArray();
            string arrayReverse = String.Empty;
            
            for(int i = cArray.Length - 1; i > -1; i--)
            {
                arrayReverse += cArray[i];
            }
            string outputString = arrayReverse.ToString();

            if(userInput == outputString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}