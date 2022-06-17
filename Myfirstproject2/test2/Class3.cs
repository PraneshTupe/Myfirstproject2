using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
    class Class3
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while(i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k=" + k + "i=" + i);
        }
    }
}
           //o/p:- k=720 i=7