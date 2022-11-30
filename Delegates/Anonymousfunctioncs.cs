using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Delegates
{
    public delegate void mydele2(int a, int b);
    class Anonymousfunctioncs
    {
        static void Main(string[] args)
        {
            //anonymous function
            mydele2 d = delegate (int a, int b)
              {
                  Console.WriteLine("product" + (a * b));
              };
            d(8, 7);

            //lamba
            mydele2 d2 = (a, b) => Console.WriteLine("area of rect" + (a * b));
            d(9, 7);
        }
    }
}
