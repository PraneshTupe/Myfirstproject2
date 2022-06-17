using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class positivenegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("num is +ve");
            }
            else if(num < 0)
            {
                Console.WriteLine("num is -ve");
            }
        }
    }
}
