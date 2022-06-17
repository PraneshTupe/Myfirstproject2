using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class factorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int sum = 0;
            for(int i = 1; i <= 5; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
