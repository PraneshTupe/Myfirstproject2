using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
        // spy number.
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int prod = 1;
            while(num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                prod = prod * r;
                num = num / 10;
            }
            Console.WriteLine(sum + " " + prod);
            if (sum == prod)
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
