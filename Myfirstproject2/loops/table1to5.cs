using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class table1to5
    {
        static void Main(string[] args)
        { 
            int table = 1;
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    table = i * j;
                    Console.Write(j);
                }
                Console.WriteLine(i);
            } 

        }
    }
}
