using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class palindromenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int r;
            while (num > 0)
            {
                r = num % 10;
                result = result * 10 + r;
                num = num / 10;
                num++;

            }
            if (num == result)
            {
                Console.WriteLine("number is palindrome");

            }
            else
            {
                Console.WriteLine("number is not palindrome");

            }
        }
    }
}

