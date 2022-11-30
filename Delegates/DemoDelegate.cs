using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Myfirstproject2.Delegates
{
    public delegate int mydel1(int a);
    public delegate void mydel2();
    public delegate int mydel3(int c, string a);
    class DemoDelegate
    {
        public static int square(int a)
        {
            Console.WriteLine("In square method");
            return a * a;
        }
        public static int Cube(int c, string a)
        {
            Console.WriteLine("In Cube Method");
            return c * c * c;
        }
        public  void Greet()
        {
            Console.WriteLine("Welcome");

        }
    }
    class Delegates
    {

        static void Main(string[] args)
        {
             DemoDelegate ob=new DemoDelegate();
            mydel2 d2 = ob.Greet;
            d2();
            mydel1 d1 = DemoDelegate.square;
           int ans= d1(12);
            mydel3 d3 = DemoDelegate.Cube;
           int c= d3(3, "pranesh");
            








        }

    }
    
    //Multicast Delagate.
    class Calculator
    {
        public delegate void mydel5(int a, int b);
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition" + (a + b));

        }
        public void Subtract(int a,int b)
        {
            Console.WriteLine("Subtraction" + (a - b));

        }
        public void Multiplication(int x,int y)
        {
            Console.WriteLine("Product" + (x + y));
        }
        static void Main(string[] args)
        {
            Calculator ob = new Calculator();
            mydel5 d5 = ob.Add;
            d5 = d5 + ob.Subtract;
            d5 = d5 + ob.Multiplication;
            
            d5(11, 5);
            

            
        }
    }

    //Anonymous Function
    class Anonymous
    {
        public delegate int mydel6(int a, int b);
        static void Main(string[] args)
        {
            /*  mydel6 d6 = delegate (int a, int b)
                {
                    Console.WriteLine("In Anonymous Function");
                    return a * b;

                };
              int ans = d6(9, 8);
              Console.WriteLine(ans);*/

            //Lambda
            mydel6 dd = (a, b) =>
              {
                  Console.WriteLine("In Lambda");
                  return a * b;
              };
            int result = dd(11, 5);
            Console.WriteLine(result);
        }
    }


}
