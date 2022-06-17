using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class greatesttarnary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            string result = (num1 > num2) ? num1 > num3 ? "num1 is greater" : "num3 is greater" :( num2 > num3) ? "num2 is greater" : "num3 is greater";
            Console.WriteLine(result);


        }
    }
}
