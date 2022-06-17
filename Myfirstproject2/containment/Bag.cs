using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class Nib
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Pen
    {
        string penname;
        string pencolour;
        Nib nb;
        public string Penname
        {
            get { return penname; }
            set { penname = value; }
        }
        public string Pencolour
        {
            get { return pencolour; }
            set { pencolour = value; }
        }
        public Nib Nb
        {
            get { return nb; }
            set { nb = value; }
        }

    }
    class Bag
    {
        string colour;
        string brandname;
        int price;
        Pen pn;
        
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Brandname
        {
            get { return brandname; }
            set { brandname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Pen Pn
        {
            get { return pn; }
            set { pn = value; }
        }


        static void Main(string[] args)
        {
            Nib n = new Nib();
            n.Type = "metal";
            Pen p = new Pen();
            p.Penname = "parkar";
            p.Pencolour = "black";
            p.Nb = n;
            Bag b = new Bag();
             b.colour = "yellow";
            b.brandname = "puma";
            b.price = 3499;
            b.pn = p;
            Console.WriteLine(n.Type + " " + p.Penname + " " + p.Pencolour + " " + b.colour + " " + b.brandname + " " + b.price);
        }
    }
}
