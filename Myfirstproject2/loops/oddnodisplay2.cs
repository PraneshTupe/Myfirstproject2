using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class oddnodisplay2
    {
        static void Main(string[] args)
        {
            int num = 0, i;
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    num++;
                }
            }
            Console.WriteLine(num);
        }
    }
}
