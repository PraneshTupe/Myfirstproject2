using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Array
{
    class Merge
    {
        public void merge(int[] arr1, int[] arr2)
        {
            int a1 = arr1.Length;
            int b1 = arr2.Length;
            int c1 = a1 + b1;
            int[] c = new int[c1];
            for(int i = 0; i < a1; i++)
            {
                c[i] = arr1[i];
            }
            for(int i = 0; i < b1; i++)
            {
                c[a1 + i] = arr2[i];
            }
            Console.WriteLine("merged array is");
            for(int i = 0; i < c1; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[7];
            Console.WriteLine("enter elements for first array");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("enter elements for second array");
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Merge m1 = new Merge();
            m1.merge(a, b);
        }
    }
}
