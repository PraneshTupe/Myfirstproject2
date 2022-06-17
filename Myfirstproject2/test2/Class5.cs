using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2
{
    //trimorphic.
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            while (num > 0)
            {
                if (num % 10 != cube % 10)
                {
                    Console.WriteLine("not trimorphic");
                    break;
                }
                num = num / 10;
                cube = cube / 10;
            }
            if (num == 0)
            {
                Console.WriteLine("trimorphic");
            }
        }
    }
}

