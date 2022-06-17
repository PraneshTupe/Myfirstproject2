using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Mobile2
    {
        public string ram = "2GB";
        
        public void get(string colour)
        {
            Console.WriteLine("Mobile" + colour);
        }
    }
    class Samsung2:Mobile2
    {
        public string ram = "3GB";

        public void show()
        {
            Console.WriteLine(ram + " " + base.ram);
        }
        public void get()
        {
            base.get("White");
            Console.WriteLine("Samsung2");
        }
    }
    class Basecallmethod
    {
        static void Main(string[] args)
        {
            Samsung2 s2 = new Samsung2();
            s2.show();
            s2.get(); 
        }
    }
}
