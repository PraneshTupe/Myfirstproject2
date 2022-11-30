using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.String
{
    class Countwords
    {
        public static void cnwords(string s)
        {
            string[] s1 = s.Split(" ");
            int count = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            cnwords(str);
          
        }

    }
}
