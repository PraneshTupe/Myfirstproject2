using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
             int num = int.Parse(Console.ReadLine());
            int a=0;
            int num1 = num;
            while (num > 0)
            {
                int r = num % 10;
                a = a + (r * r * r);
                num = num / 10;
                num++;
            }
            if (num1 == a)
            {
                Console.WriteLine("armstrong number");
            }
            else
            {
                Console.WriteLine("not armstrong number");
            }

        }
    }
}
