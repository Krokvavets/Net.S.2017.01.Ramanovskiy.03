using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Task1
    {
        /// <summary>
        /// The method find index of input array for which sum elements to the left of it is equal to the sum of the elements on the right
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>index of input array</returns>
        public static int Calculation(this int[] array)
        {
            if (array.Length == 0 )throw new ArgumentException("Invalid array length");
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Take(i).Sum() == array.Skip(i + 1).Sum())
                    return i;
            }
            return -1;
        }
    }
}
