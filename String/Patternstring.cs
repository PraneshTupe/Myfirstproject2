using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.String
{
    class Patternstring
    {
        public static void pat(string str)
        {
            string[] s1 = str.Split(" ");
            for(int i = 0; i < s1.Length; i++)
            {
                string c = " ";
                for(int j = 0; j <= i; j++)
                {
                    c = c + " " + s1[j];
                }
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            pat(str);
        }
    }
}
