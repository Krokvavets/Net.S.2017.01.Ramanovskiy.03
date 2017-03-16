using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1.CUI
{
    class CUI
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            int[] arr2 = new int[] { 1, 100, 50, -51, 1, 1 };
            Console.WriteLine(arr1.Calculation());
            Console.WriteLine(arr2.Calculation());
            Console.ReadKey();
            int[] arr3 = new int[1000];
            arr3.Calculation();
        }
    }
}
