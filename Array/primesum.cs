using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Array
{
    class primesum
    {
        public void sumprime(int[] arr)
        {
            int sum = 0;
            Console.WriteLine("prime numbers are");
            for(int i = 0; i < arr.Length; i++)
            {
                bool isprime = true;
                int n = arr[i];
                for(int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(arr[i]);
                    sum = sum + n;
                }
            }
            Console.WriteLine("sum of prime numbers are" + sum);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            primesum s1 = new primesum();
            s1.sumprime(a);
        }
    }
}
