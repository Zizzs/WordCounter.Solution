using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleGame.Models
{
    public class Scrabble
    {
        private int _total;
        private string _word;
        private int _id;
        public static List<Scrabble> _instances = new List<Scrabble> {};

        public Scrabble(string word, int total)
        {
            _word = word;
            _total = total;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public string GetWord()
        {
            return _word;
        }

        public int GetTotal()
        {
            return _total;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetWord(string word)
        {
            _word = word;
        }

        public void SetTotal(int total)
        {
            _total = total;
        }

        public static Scrabble Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public int ScrabblePoints(char letter)
        {
            if ("AEIOULNRST".Contains(letter))
            {
                return 1;
            }
            else if ("DG".Contains(letter))
            {
                return 2;
            }
            else if ("BCMP".Contains(letter))
            {
                return 3;
            }
            else if ("FHVWY".Contains(letter))
            {
                return 4;
            }
            else if ("K".Contains(letter))
            {
                return 5;
            }
            else if ("JX".Contains(letter))
            {
                return 8;
            }
            else if("QZ".Contains(letter))
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
    }
}