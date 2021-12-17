using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftExam2
{
    class NotContains
    {
        public static int notContains(int[] array)
        {
            int A = 1;

            array = array.OrderBy(x => x).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                    continue;
                else if (array[i] == A)
                {
                    A++;
                }

            }
            return A;
        }
    }
}
