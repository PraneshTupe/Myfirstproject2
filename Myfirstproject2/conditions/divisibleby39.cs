using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class divisibleby39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num%3==0 && num % 9 == 0)
            {
                Console.WriteLine("number is divisible");
            }
            else
            {
                Console.WriteLine("not divisible");
            }
        }
    }
}
