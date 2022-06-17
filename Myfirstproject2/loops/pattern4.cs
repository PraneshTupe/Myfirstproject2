using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class pattern4
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(i==3 && j == 2 || (i==3 && j==3))
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.WriteLine(" ");
            }
        }
    }
}
