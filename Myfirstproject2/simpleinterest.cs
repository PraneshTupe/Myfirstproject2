using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2
{
    class simpleinterest
    {
        static void Main(string[] args)
        {
            double p, r, t, simpleinterest;
            p = 7000;
            r = 4.5;
            t = 3;
            simpleinterest = p * r * t/100;
            Console.WriteLine("simpleinterest=" + simpleinterest);


        }
    }
}
