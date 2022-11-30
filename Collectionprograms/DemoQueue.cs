using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{
    class DemoQueue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);

            int d = q.Dequeue();
            Console.WriteLine(d);
            int p = q.Peek();
            Console.WriteLine(p);
            foreach(int element in q)
            {
                Console.WriteLine(element);
            }
        }
    }
}
