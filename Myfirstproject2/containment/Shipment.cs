using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class Order
    {
        int oid;
        string custname;
        string city;

        public Order(int oid,string custname,string city)
        {
            this.oid = oid;
            this.custname = custname;
            this.city = city;
        } 
        public void show()
        {
            Console.WriteLine(oid + " " + custname + " " + city);
        }

    }
    class Orderdate
    {
   
         int mm;
        int dd;
        int yy;

        public Orderdate(int mm,int dd,int yy)
        {
            this.mm = mm;
            this.dd = dd;
            this.yy = yy;

        }
        public void show1()
        {
            Console.WriteLine(mm + " " + dd + " " + yy);
        }
    }
    class Shipment
    {
        int sid;
        Order ord;
        Orderdate od;

        public Shipment(int sid,Order ord,Orderdate od)
        {
            this.sid = sid;
            this.ord = ord;
            this.od = od;
        }
          void display()
        {
            Console.WriteLine(sid);
            ord.show();
            od.show1();

        }
        static void Main(string[] args)
        {
            Order o = new Order(123,"pranesh","pune");
            Orderdate p = new Orderdate(12, 04, 2022);
            Shipment s = new Shipment(345, o, p);
            Console.WriteLine(s);
            s.display(); 
        }
    }
}
