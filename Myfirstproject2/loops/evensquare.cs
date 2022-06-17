using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class evensquare
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    sum = i * i;
                    Console.WriteLine(sum);
                }
                i++;
            }

        }
    }
}
