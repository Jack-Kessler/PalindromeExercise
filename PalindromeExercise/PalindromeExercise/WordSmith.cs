using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            if (str == null || str.Length <= 1)
            {
                return false;
            }
            else
            {
                str = str.ToLower();
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                string rev = new string(charArray);
                return rev == str ? true : false;
            }
        }
    }
}
