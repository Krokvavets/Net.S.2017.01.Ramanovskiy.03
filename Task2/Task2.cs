using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Task2
    {
        static string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public static string Longest(string str1, string str2)
        {
            string concatenatedStr = "";
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (concatenatedStr.Contains(alphabet[i]))
                    continue;
                if(str1.Contains(alphabet[i]))
                {
                    concatenatedStr += alphabet[i];
                    continue;
                }
                if (str2.Contains(alphabet[i]))
                    concatenatedStr += alphabet[i];
            }

            return concatenatedStr;
        } 
    }
}
