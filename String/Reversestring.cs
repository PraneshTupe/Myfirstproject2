using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.String
{
    class Reversestring
    {
        public static void reverse(string str)
        {
            string[] s2 = str.Split(" ");
            string revers = " ";
            for(int i = 0; i < s2.Length; i++)
            {
                if(i==0 || i == s2.Length - 1)
                {
                    revers = revers + "" + s2[i];
                }
                else
                {
                    string word = s2[i];
                    string revs = " ";
                    for(int j = word.Length - 1; j >= 0; j--)
                    {
                        revs = revs + " " + word[j];
                    }
                    revers = revers + " " + revs;
                }
            }
            Console.WriteLine(revers);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            reverse(str);
        }
    }
}
