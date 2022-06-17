using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int temp = num;
            while (temp > 0)
            {
                count++;
                temp = temp / 10;

            }
            temp = num;
            while (temp > 0)
            {
                int r = temp % 10;
                sum = sum + (int)(Math.Pow(r, count));
                temp = temp / 10;
                count--;

            }
            if (num == sum)
            {
                Console.WriteLine("disarium number");

            }
            else
            {
                Console.WriteLine("no disarium number");
            }
        }
    }
}
