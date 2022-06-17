using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
    //series.
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the range");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int r = (i * i) + (i * i * i);
                Console.WriteLine(r);
            }
        }
    }
}
