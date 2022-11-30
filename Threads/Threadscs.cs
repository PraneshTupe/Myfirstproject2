using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Myfirstproject2.Threads
{
    // thread is path of execution which is responsible for execution of program.
    class Threadscs
    {
        public static void m1()
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Child=" + i);
                Thread.Sleep(300);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            Thread t1 = new Thread(m1);
            t1.Name = "thread1";
            t1.Priority = ThreadPriority.Highest;
            t1.Start();
            t1.IsBackground = true;//helper thread 
            //if all foreground threads work is completed then CLR destroy backgound thread.
            for(int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine("main thread=" + i);
                Thread.Sleep(200);
            }
        }
    }
}
