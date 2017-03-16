using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3.CUI
{
    class CUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task3.Insertion(0, 15, 0, 3));
            Console.WriteLine(Task3.Insertion(10, 15, 2, 7));
            Console.WriteLine(Task3.Insertion(0, 0, 0, 1));
            Console.ReadKey();
        }
    }
}
