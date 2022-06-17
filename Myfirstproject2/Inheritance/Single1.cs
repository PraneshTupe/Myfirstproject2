using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Mobile
    {
        public string ram = "2GB";
        public void display()
        {
            Console.WriteLine("Mobile");
        }
    }
    class Samsung:Mobile
    {
        public void show()
        {
            string ram = "4GB";
            Console.WriteLine(ram);
        }
    }
    class Single1
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            s.show();
            s.display();

        }
    }
}
