using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class kaprekarno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sq = num * num;
            int temp = num;
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int div = sq / power;
            int r = sq % power;
            int sum = div + r;
            if (sum == temp)
            {
                Console.WriteLine("kaprekar");
            }
            else
            {
                Console.WriteLine("not kaprekar");
            }
        }
    }
}
