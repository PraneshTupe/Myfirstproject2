using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.oops
{
    class Car
    {
        public int modelno;
        public string name;
        public string colour;
        public int prize;

        static void Main(string[] args)
        {

            Car c1 = new Car();
            c1.modelno = 345;
            c1.name = "bmw";
            c1.colour = "red";
            c1.prize = 34000;

            Car c2 = new Car();
            c2.modelno = 132;
            c2.name = "toyota";
            c2.colour = "white";
            c2.prize = 67000;

            Car c3 = new Car();
            c3.modelno = 678;
            c3.name = "maruti";
            c3.colour = "silver";
            c3.prize = 21000;

            Console.WriteLine(c1.modelno + " " + c1.name + " " + c1.colour + " " + c1.prize);
            Console.WriteLine(c2.modelno + " " + c2.name + " " + c2.colour + " " + c2.prize);
            Console.WriteLine(c3.modelno + " " + c3.name + " " + c3.colour + " " + c3.prize);



        }


    }
}
