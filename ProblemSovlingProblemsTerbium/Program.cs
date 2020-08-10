using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSovlingProblemsTerbium
{
    class Program
    {
        static void Main(string[] args)
        {


            bool isNevin = true;
            bool isJosh = false;
            int a = 7;
            int b = 8;
            int c = 9;
            //true / false
            if(a == b && (a == c || c == b))
            {

            }

            if(isNevin == true  && isJosh == false)
            {
                //do something
            }   //true / false
            if (isNevin && !isJosh)
            {
                //do Something
            }
            //StringComress stringComress = new StringComress();
            //stringComress.Compress("aaabbcccc");
            //FizzBuzz fizzBuzz = new FizzBuzz();
            //fizzBuzz.RunFizzBuzz();
            Palindrome palindrome = new Palindrome();
            palindrome.IsPalindrome("racecar");
            Console.ReadLine();
        }
    }
}
