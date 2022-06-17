using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Cars
    {
        public int noofcars = 678;
    }
     class Marutisuzuki : Cars
    {
        public int noofemployee = 2000;
    }
     class Swift : Marutisuzuki
    {
        public string colour = "white";
        public int price = 450000;

        public void show()
        {
            Console.WriteLine(+noofcars + " " + noofemployee + " " + colour + " " + price);
        }
    }
    class Multilevel1
    {
        static void Main(string[] args)
        {
            Swift s = new Swift();
            s.show();
        }
    }
}
