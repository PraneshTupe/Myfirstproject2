using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Myfirstproject2.Threads
{
    class Join
    {
        //static Thread main;
        static void m1()
        {
           // main.Join();
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("child=" + i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
           // main = Thread.CurrentThread;
            Thread t1 = new Thread(m1);
            t1.Start();
            t1.Join();
            //currently executing thread has to wait till t1 goes in dead state.
            Thread t2 = new Thread(m1);
            t2.Start();
            t2.Join();
            

            for(int i = 1; i <= 20; i = i + 2)
            {
                Console.WriteLine("main thread=" + i);
                
            }
        }
    }
}
