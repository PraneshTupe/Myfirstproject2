using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class series3
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i * (i * i - 1));
                i++;
            }
        }
    }
}
