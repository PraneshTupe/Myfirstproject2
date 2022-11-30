using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Myfirstproject2.Delegates
{
    class Practise
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine("In Add Method"+(a+b));
            
        }
        public static int Multiply(int a,int b)
        {
            Console.WriteLine("In Multiply method");
            return a * b;
        }
        public static bool Isleapyear(int yy)
        {
            if (yy % 4 == 0)
                return true;
            else
                return false;
            



        }
        static void Main(string[] args)
        {
            

            Action<int, int> a = Add;
             a(11, 5);
            Func<int, int, int> f = Multiply;
            int ans=f(3, 5);

           
          
           
              

        }
    }
}
