using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Task1
    {
        public static int Calculation(this int[] array)
        {
            int left, right;
            if (array.Length == 0 || array.Length >= 1000)
                throw new Exception("Invalid array length");

            for (int sI = 0; sI < array.Length; sI++)
            {
                left = 0;
                right = 0;
                for (int i = 0; i < sI; i++)
                    left += array[i];
                for (int i = sI + 1; i < array.Length; i++)
                    right += array[i];
                if (right == left)
                    return sI;
            }
            return -1;
        }
    }
}
