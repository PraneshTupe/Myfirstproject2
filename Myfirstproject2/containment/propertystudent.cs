using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class propertystudent
    {

        private int id;
        private string name;
        private float percentage;

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
        public float Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        static void Main(string[] args)
        {
            propertystudent s = new propertystudent();
            s.id = 675;
            s.name = "prasad";
            s.percentage = 67.4f;
            Console.WriteLine(s.id + " " + s.name + " " + s.percentage + " ");
        }
    }
}
