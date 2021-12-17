using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftExam2
{
    class Coins
    {
        public static int minSplit(int value)
        {

            int[] coins = { 1, 5, 10, 20, 50 };

            coins = coins.OrderByDescending(x => x).ToArray();

            int result = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                if (value > 0 && value >= coins[i])
                {
                    result += value / coins[i];
                    value %= coins[i];
                }
                continue;
            }
            return result;
        }
    }
}
