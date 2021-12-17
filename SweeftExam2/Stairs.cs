using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftExam2
{
    class Stairs
    {
        public static int CountVariants(int stearsCount)
        {
            int n = stearsCount;

            int[] variantArr = new int[n + 1];

            variantArr[0] = 1;
            variantArr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                variantArr[i] = variantArr[i - 1] + variantArr[i - 2];
            }
            return variantArr[n];
        }

    }
}
