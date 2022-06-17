using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class Engine2
    {
        string type2;
        public string Type2
        {
            get { return type2; }
            set { type2 = value; }
        }


    }



    class Carp
    {
        int modelno;
        string name;
        int price;
        Engine2 en;

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Engine2 En
        {
            get { return en; }
            set { en = value; }
        }


        static void Main(string[] args)
        {
            Engine2 e = new Engine2();
            e.Type2 = "petrol";
            Carp c = new Carp();
            c.Modelno = 3455;
            c.Name = "bmw";
            c.Price = 670000;
            c.en = e;
            Console.WriteLine(e.Type2 + " " + c.Modelno + " " + c.Name + " " + c.Price + " ");


        }
    }
}
