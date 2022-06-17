using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class tarnaryop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int num = int.Parse(Console.ReadLine());
            string result = num % 2 == 0 ? "even" : "odd";
            Console.WriteLine(result);

        }
    }
}
