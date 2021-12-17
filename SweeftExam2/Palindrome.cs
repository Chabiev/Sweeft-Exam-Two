using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftExam2
{
    class Palindrome
    {
        public static bool isPalindrome(string text)
        {
            int num;

            num = int.Parse(text);

            int temp;
            int revNum = 0;
            int rem;

            temp = num;

            while (num > 0)
            {
                rem = num % 10;

                revNum = revNum * 10 + rem;

                num /= 10;
            }

            if (revNum == temp)
                return true;

            else
                return false;

            Console.ReadLine();
        }
    }
}
