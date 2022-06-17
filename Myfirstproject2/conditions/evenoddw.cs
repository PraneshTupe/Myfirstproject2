using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class evenoddw
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (num % 2==0 &&( 2>= num&&num <=5))
            {
                Console.WriteLine("NotWeird");
            }
            else if (num % 2 == 0 &&  (6>=num && num <=20))
            {
                Console.WriteLine("Weird");
            }
            else if (num % 2 == 0 && num > 20)
            {
                Console.WriteLine("NotWeird");

            }
        }
    }
}
