using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.String
{
    class Palindromestr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
         //   string[] str = s.Split("");
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
                if (rev == s)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("not palindrome");
                }
            
            Console.ReadLine();
        }
    }
}
