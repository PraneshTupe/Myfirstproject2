using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class zero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }
        }
    }
}
