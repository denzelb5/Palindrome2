using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome2
{
    public class PalindromeChecker
    {
        public bool CheckPalindrome(string palindrome)
        {
            var palindromeLetters = Regex.Replace(palindrome, "[^a-zA-Z]", "").ToLower();
            string first = palindromeLetters.Substring(0, palindromeLetters.Length / 2);
            char[] arr = palindromeLetters.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
