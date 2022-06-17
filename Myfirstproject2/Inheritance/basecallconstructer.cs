using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Mobile3
    {
        public string ram = "6GB";

        public Mobile3(string colour)
        {
            Console.WriteLine("Mobile ram=" + ram + " " + colour);
        }
    }
      
        class Samsung3 : Mobile3
        {
            public Samsung3() : base("red")
            {
                Console.WriteLine("Samsung3");
            }
        }

    class basecallconstructer
    {
        static void Main(string[] args)
        {
            Samsung3 s3 = new Samsung3();
        }
    }
}
