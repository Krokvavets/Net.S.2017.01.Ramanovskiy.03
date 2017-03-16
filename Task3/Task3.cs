using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Task3
    {
        public static int Insertion(int targetNumber, int insertNumber, int i, int j)
        {
            if ((i < 0 || j < 0) || (i > 31 || j > 31))
                throw new Exception("Indexes can't be negative or more then 31.");
            if (i >= j)
            throw new ArgumentException("Index i must be less then j.");
            string byteInsertNumber = Convert.ToString(insertNumber, 2);
            string byteTargetNumber = Convert.ToString(targetNumber, 2);
            int count = j - i;
            if (count < byteInsertNumber.Length)
                byteInsertNumber.Remove(byteInsertNumber.Length - count);
            else if (count > byteInsertNumber.Length)
            {
                int dif = count - byteInsertNumber.Length;
                while (dif!=0)
                    {
                         byteInsertNumber = byteInsertNumber.Insert(0, "0");
                         dif--;
                    }
            }
                
            int position = byteTargetNumber.Length - i;
            if (position < 0)
                position = 0;
            byteTargetNumber = byteTargetNumber.Insert(position, byteInsertNumber);
            return Convert.ToInt32(byteTargetNumber,2);

            
        }
    }
}
