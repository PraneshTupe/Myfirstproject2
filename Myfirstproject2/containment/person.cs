using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class Address
    {
         int pincode;
         string city;
         
        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }


    class person
    {
        private int id;
        private string name;
        Address adr;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        static void Main(string[] args)
        {
            Address a = new Address();
            a.Pincode = 411028;
            a.City = "Pune";

            person p = new person();
            p.id = 123;
            p.name = "pranesh";
            p.adr = a;
            Console.WriteLine(p.id + " " + p.name + " " + a.Pincode + " " +a.City + " ");
        }
    }
}
