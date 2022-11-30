using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Delegates
{
    public delegate int mydele1(int x);
    class LambdaFactorial
    {
        
        static void Main(string[] args)
        {
            mydele1 d = (n) =>
              {
                  int i, f = 1;
                  for (i = 1; i < n; i++)
                  {
                      f = f * i;
                  }
                  return f;
              };
           int x = d(7);
            Console.WriteLine("Fcatorial" + x);
        }
    }
}
