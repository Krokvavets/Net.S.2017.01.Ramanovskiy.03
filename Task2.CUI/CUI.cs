using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2.CUI
{
    class CUI
    {
        static void Main(string[] args)
        {
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";
            Console.WriteLine(Task2.Longest(a, b));
            a = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(Task2.Longest(a, a));
            Console.ReadKey();
        }
    }
}
