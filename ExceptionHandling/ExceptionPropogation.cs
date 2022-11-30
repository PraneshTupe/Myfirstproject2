using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.ExceptionHandling
{
    class ExceptionPropogation
    {
        static void m1()
        {
            Console.WriteLine("m1 satrts");
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("m1 ends");
        }
        static void m2()
        {
            m1();
            Console.WriteLine("mmmmm");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            try
            {
                m2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("main ends");
        }
    }

}
