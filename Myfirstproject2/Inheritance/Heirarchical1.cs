using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Hotel
    {
        public int totalstaff = 30;
    }
    class Manager : Hotel
    {
        public int salary = 100000;
    }
    class Cashier : Hotel
    {
        public int salary = 50000;
    }
    class Chef : Hotel
    {
        public int salary = 60000;
    }
    class Heirarchical1
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Console.WriteLine(m.salary + " " + m.totalstaff);
            Cashier c = new Cashier();
            Console.WriteLine(c.salary + " "+c.totalstaff);
            Chef cf = new Chef();
            Console.WriteLine(cf.salary + " " + cf.totalstaff);
        }
    }
}
