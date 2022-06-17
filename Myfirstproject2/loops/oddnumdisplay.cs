using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class oddnumdisplay
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 15; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
