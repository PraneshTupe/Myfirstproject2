using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class spynumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 1;
            int r;
            while (num > 0)
            {
                r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
               

            }
            if (sum == product)
            {
                Console.WriteLine("spy number");
            }
            else
            {
                Console.WriteLine("not spy number");
            }
        }
    }
}
