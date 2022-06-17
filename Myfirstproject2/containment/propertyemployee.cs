using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class propertyemployee
    {
       private int eid;
        private string ename;
         private double salary;

        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }                      
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        static void Main(string[] args)
        {
            propertyemployee e = new propertyemployee();
            e.eid = 2344;
            e.ename = "pranesh";
            e.salary = 23.44;
            Console.WriteLine(e.eid + " " + e.ename + " " + e.salary + " ");
        }
    }
}
