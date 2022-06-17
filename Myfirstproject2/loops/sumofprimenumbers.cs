using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class sumofprimenumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("prime number");
                }
                else
                {
                    Console.WriteLine("not prime number");
                }
            }

        }
    }
}
