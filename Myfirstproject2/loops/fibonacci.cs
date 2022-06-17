using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int n1 = 0;
            int n2 = 1;
            for(int i = 1; i <= 10; i++)
            {
                sum = n1 + n2;
                Console.WriteLine(n1);
                n1 = n2;
                n2 = sum;
            }
        }
    }
}
