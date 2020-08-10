using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSovlingProblemsTerbium
{
    class StringComress
    {
        // wordToCompress = "aaabbcccc"
        //"3a2b4c"
        //a = '97 a'
        public void Compress(string wordToCompress)
        {
            string finalString = "";
            int counter = 1;
            for (int i = 0; i < wordToCompress.Length; i++)
            {
                if (i == wordToCompress.Length - 1)
                {
                    finalString += counter + wordToCompress[i].ToString();
                }
                else if (wordToCompress[i] != wordToCompress[i + 1])
                {
                    finalString += counter + wordToCompress[i].ToString();
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }

            Console.WriteLine(finalString);
            Console.ReadLine();
            
        }
    }
}
