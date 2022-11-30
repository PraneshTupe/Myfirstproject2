using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Myfirstproject2.Collectionprograms
{
    class DemoLinkedlist
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(89);
            ll.AddLast(82);
            ll.AddFirst(32);
            ll.AddFirst(52);
            LinkedListNode<int> node = ll.Find(89);
            if (node != null)
                ll.AddBefore(node, 100);

            foreach (int data in ll)
            {
                Console.WriteLine(data);
            }
            for (int i = 0;i< ll.Count; i++)
            {
                Console.WriteLine(ll.ElementAt(i));
            }
        }
    }
}
