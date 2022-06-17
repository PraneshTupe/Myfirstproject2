using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Inheritance
{
    class Soceity
    {
        public string name = "Galaxy";
    }
    class Flats : Soceity
    {
        public int noofflats = 40;
    }
    class Chairman : Soceity
    {
        public string chname = "amit";
    }
    class Floors : Soceity
    {
        public int nooffloors = 6;
    }
    class Heirarchical2
    {
        static void Main(string[] args)
        {
            Flats f = new Flats();
            Console.WriteLine(f.noofflats + " " + f.name);
            Chairman c = new Chairman();
            Console.WriteLine(c.chname + " " + c.name);
            Floors ft = new Floors();
            Console.WriteLine(ft.nooffloors + " " + ft.name);
        }
    }
}
