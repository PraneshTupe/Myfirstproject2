using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            
        }
    }
}
