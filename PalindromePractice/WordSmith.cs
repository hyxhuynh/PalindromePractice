using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PalindromePractice
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string lowerCaseWord = word.ToLower();
            int length = lowerCaseWord.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (lowerCaseWord[i] != lowerCaseWord[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
