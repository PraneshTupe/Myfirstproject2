using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{
    class DemoStack
    {
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("pranesh");
            stk.Push("pratik");
            stk.Push("ganesh");

            foreach(string data in stk)
            {
                Console.WriteLine(data);
            }
           // string v = stk.Peek();
            //Console.WriteLine("**" + v);
            string d = stk.Pop();//remove and returns the object or data present at the top of the stack.
            
            
                Console.WriteLine("remove "   + d);
            
            foreach(string data in stk)
            {
                Console.WriteLine(data);
            }
        }
    }
}
