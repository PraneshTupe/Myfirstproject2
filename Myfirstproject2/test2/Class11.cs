using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
    //print no between 1to50.
    class Class11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }
}
