using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Person
    {
        public string name = "rajesh";
    }
    class Teacher : Person
    {
        public string classname = "DivB";

    }
     class Principal : Teacher
    {
        public int salary = 75000;

        public void show()
        {
            Console.WriteLine(name + " " + classname + " " + salary);
        }
    }
    class Multilevel2
    {
        static void Main(string[] args)
        {
            Principal p = new Principal();
            p.show();
        }
    }
}
