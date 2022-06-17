using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                  if(i==1 || i==4 || j==1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }Console.WriteLine(" ");
            }
        }
    }
}
