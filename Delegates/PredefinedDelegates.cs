using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Delegates
{
    class PredefinedDelegates
    {
        static double mm(int r,char c)
        {
            return r * 3.4;
        }
        static void mm1(byte a,string e)
        {
            Console.WriteLine("in mm1" + e + a);
        }
        static bool mm2(long m,string s)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, char, double> d = mm;
            double x = d(43, 'd');

            Action<byte, string> d1 = mm1;
            d1(133, "pranesh");

            Func<long, string, bool> d2 = mm2;
            bool b = d2(10, "ppp");




        }
       

        
    }
}
