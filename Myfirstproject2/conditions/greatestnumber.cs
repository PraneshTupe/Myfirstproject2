using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class greatestnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int num3 = int.Parse(Console.ReadLine());
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("greater number is num1");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("greater number is num2");
            }
            else
            {
                Console.WriteLine("greater number is num3");
            }
        }
    }
}
