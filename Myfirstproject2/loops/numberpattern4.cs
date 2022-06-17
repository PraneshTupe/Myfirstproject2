using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class numberpattern4
    {
        static void Main(string[] args)
        {
            int k = 1;
            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
