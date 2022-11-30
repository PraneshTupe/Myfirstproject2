using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.ExceptionHandling
{
    class exception
    {
        static string nm;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter the number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("division" + a / b);
                try
                {
                    Console.WriteLine("enter age");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();   
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("try ends");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for(int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
