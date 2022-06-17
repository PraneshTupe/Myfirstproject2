using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
    //fibonacci series.
    class Class13
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1 + " " + n2);
            int temp;
            for(int i = 2; i <= 20; i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                temp = n1;
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
