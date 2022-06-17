using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class sumofeven
    {
        static void Main(string[] args)
        {
            int sum = 0, i;
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {

                 sum = sum + i;
                    

                }
            }
            Console.WriteLine(sum);

        }
    }
}
