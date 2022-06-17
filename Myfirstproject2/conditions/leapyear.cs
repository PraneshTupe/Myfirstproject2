using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
        }
    }
}
