using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSovlingProblemsTerbium
{
    class Palindrome
    {

        public string ReverseString(string StrToReverse)
        {
            string newStr = "";
            for (int i = StrToReverse.Length - 1; i >= 0; i--)
            {
                newStr += StrToReverse[i].ToString();
            }

            //string newStr = string.Join("", StrToReverse.ToCharArray().Reverse());
            return newStr;
        }

        public void IsPalindrome(string StrToCheck)
        {
            if(StrToCheck == ReverseString(StrToCheck))
            {
                Console.WriteLine("Yee");
            }
            else
            {
                Console.WriteLine("Naw");
            }
        }
    }
}
