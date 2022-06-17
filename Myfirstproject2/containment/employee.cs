using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class Department
    {
        public int did;
        public string dname;
         
        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void show()
        {
            Console.WriteLine(did + " " + dname);
        }

    }




    class employee
    {


        int eid;
        string ename;
        Department dept;

        employee (int eid, string ename, Department dept)
        {
            this.eid = eid; ;
            this.ename = ename;
            this.dept = dept;

        }
        void display()
        {
            Console.WriteLine(eid + " " + ename);
            dept.show();
        }
            

        static void Main(string[] args)
        {
            Department d = new Department(123,"HR");
            employee e = new employee(345, "pranesh", d);
            Console.WriteLine(e);
            e.display();
            
       
        }
    }
}
