using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.String
{
    class Sortstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string[] str = s.Split("");
            for(int i = 0; i < str.Length; i++)
            {
                for (int j =0; j<str.Length-1; j++)
                {
                    if (s[i].CompareTo(s[j]) == 1)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", str));
        }
    }
}
