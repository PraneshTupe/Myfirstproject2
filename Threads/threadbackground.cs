using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; 

namespace Myfirstproject2.Threads
{
    class threadbackground
    {
        public static void m1()
        {
            for(int i = 1; i <= 30; i = i + 2)
            {
                Console.WriteLine("odd" + i);
            }
        }
        static void Main(string[] args)
        { 

            Thread t1 = new Thread(m1);
            t1.IsBackground = true;
            t1.Start();
            for(int i = 0; i <= 30; i++)
            {
                Console.WriteLine("happy");
            }


        }
    }
}
