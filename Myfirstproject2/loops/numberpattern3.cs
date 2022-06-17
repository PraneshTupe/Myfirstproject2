using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class numberpattern3
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<=4 ; i++)
            {
                for(int j = i; j <= 4; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
