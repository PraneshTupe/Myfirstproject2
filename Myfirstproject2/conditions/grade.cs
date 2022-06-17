using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class grade
    {
        static void Main(string[] args)
        {
            double percentage;
            Console.WriteLine("enter the marks");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("percentage of subjects");
            percentage = (a + b + c + d + e) / 500.0 * 100;
            Console.WriteLine("percentage of subjects=" + percentage);
            if (percentage > 70)
            {
                Console.WriteLine("Distinction");
            }
            else if(percentage>=60&& percentage <= 70)
            {
                Console.WriteLine("First class");
            }
            else if(percentage>=50 && percentage <= 59)
            {
                Console.WriteLine("Second Class");
            }
            else if (percentage>=35 && percentage <= 49)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
