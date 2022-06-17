using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.test2 
{ 

    //write a program to print all numbers between 1 and 100 except the numbers which are divisible bye 5 or 10.
    class Class1
    {
       static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%5!=0 || i % 10 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
