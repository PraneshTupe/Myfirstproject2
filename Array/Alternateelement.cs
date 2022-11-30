using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Array
{
    class Alternateelement
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
