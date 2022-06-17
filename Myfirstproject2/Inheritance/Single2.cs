using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Bird
    {
        public int legs = 2;
        public void display()
        {
            Console.WriteLine("Bird");
        }
    }
      class Parrot : Bird
    {
        public void show()
        {
            int legs = 2;
            Console.WriteLine(legs);
        }
    }
    class Single2
    {
        static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.show();
            p.display();
        }
    }
}
