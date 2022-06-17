using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
      //print pattern
    class Class6
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i=i+2)
            {
                for(int j = 4; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
