using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Delegates
{
    class Predefined
    {
        static void mm(int a,float b)
        {
            Console.WriteLine("in mm" + (a + b));

        }
        static void mm1(string msg)
        {
            Console.WriteLine("welcome" + msg);
        }
        static int cube(int x)
        {
            return x * x * x;
        }
        static float Areaofcircle(int r)
        {
            return 3.14f* r * r;

        }
        static bool isEven(int x)
        {
            return x % 2 == 0;

        }
        static void Main(string[] args)
        {
            Action<int, float> d1 = mm;
            d1(11, 2.3f);
            Action<string> d2 = mm1;
            d2("Good Morning");
            Func<int, float> d3 = Areaofcircle;
            float area = d3(5);
            Func<int, bool> dd = isEven;
            bool even = dd(4);
        }
    }
}
