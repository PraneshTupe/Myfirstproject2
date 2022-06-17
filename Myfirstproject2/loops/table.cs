using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class table
    {
        static void Main(string[] args)
        {
            int table1 = 1;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                table1 = num * i;
                Console.WriteLine(table1);
            }
        }
    }
}
