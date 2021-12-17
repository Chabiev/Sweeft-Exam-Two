using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftExam2
{
    class ParenthesesCheck
    {
       public static bool isProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i <sequence.Length ; i++)
            {
                char character = sequence[i];

                if (character == '(')
                    stack.Push(character);
                else if (character==')')
                {
                    if (!stack.Any())
                        return false;
                    
                    if (character==')')
                    {
                        if (stack.Pop() != '(')
                            return false;
                    }
                }
            }

            if (!stack.Any())
                return true;
            return false;

        }
    }
}
