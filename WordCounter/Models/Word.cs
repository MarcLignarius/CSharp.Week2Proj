using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

    public class RepeatCounter
    {
        private string _userInputSentence;
        private string _userInputWord;

        public RepeatCounter(string userInputSentence, string userInputWord)
        {
            _userInputSentence = userInputSentence.ToLower();
            _userInputWord = userInputWord.ToLower();
        }

        public string GetSentence()
        {
            return _userInputSentence;
        }

        public string GetWord()
        {
            return _userInputWord;
        }

        public void GetNewSentence(string userInputSentence)
        {
            _userInputSentence = userInputSentence;
        }

        public void GetNewWord(string userInputWord)
        {
            _userInputWord = userInputWord;
        }

        public int AddWordMatches()
        {
            int matches = 0;
            string[] userInputSentenceArray = _userInputSentence.Split();
            foreach (string word in userInputSentenceArray)
            {
                if (word == _userInputWord)
                {
                    matches += 1;
                }
            }
            return matches;
        }

    }

}

//
