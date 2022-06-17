using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.loops
{
    class magicnumber
    {
        static void Main(string[] args)
        {
         
            int magic = 58;
            while (true)
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num>magic)
                {
                    Console.WriteLine("number is greater than magic..plz try again");
                    continue;
                }
                else if (num<magic)
                {
                    Console.WriteLine("number is less than magic..plz try again");
                    continue;


                }
                else
                {
                    Console.WriteLine("congratulations");
                    break;
                }
            }


        }
    }
}
