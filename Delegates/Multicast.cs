using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Delegates
{
    class Multicast
    {
//public static void mydele3(int a);
        public static void m1(int a)
        {

            Console.WriteLine("in m1 " + a);
        }
        public static void square(int n)
        {
            Console.WriteLine("square" + n * n);
        }
        static void Main(string[] args)
        {
            //single cast
           /// mydele3 d1 = square();
            //multicast
            //mydele3 d2 = square();
            //d2 = d2 + m1();
            //d2(9);
        }
    }
}
