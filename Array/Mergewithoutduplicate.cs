using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Array
{
    class Mergewithoutduplicate
    {
        static void Main(string[] args)
        {

            int[] a = { 23, 24,26,27,28,55 };
            int[] b = { 22, 33, 44, 55,28,26 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for(int i = 0; i < a.Length; i++)
            {
                bool ispresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == a[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    c[j] = a[i];
                    j++;
                }

            }
            for(int i = 0; i < b.Length; i++)
            {
                bool ispresent = false;
                for(int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            for(int i = 0; i <j; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
