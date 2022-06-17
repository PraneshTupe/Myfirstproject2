using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.conditions
{
    class owelconsonants
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Console.ReadLine()[0];
            if (ch == 'a' && ch == 'a')
            {
                Console.WriteLine("char is owel");
            }
            else if (ch == 'e' && ch == 'e')
            {
                Console.WriteLine("char is owel");
            }
            else if (ch == 'i' && ch == 'i')
            {
                Console.WriteLine("char is owel");
            }
            else if (ch == 'o' && ch == 'o')
            {
                Console.WriteLine("char is owel");
            }
            else if (ch == 'u' && ch == 'u')
            {
                Console.WriteLine("char is owel");
            }
            else
            {
                Console.WriteLine("char is consonant");
            }
        }
    }
}
