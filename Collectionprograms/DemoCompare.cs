using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{


    class Mystringbuilder : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder sb1, StringBuilder sb2)
        {
            string s1 = sb1.ToString();
            string s2 = sb2.ToString();
            return s1.CompareTo(s2);
        }
    }
    class DemoCompare

    {
        static void Main(string[] args)
        {
            List<StringBuilder> lst = new List<StringBuilder>();
            lst.Add(new StringBuilder("Pranesh"));
            lst.Add(new StringBuilder("Avinash"));
            lst.Add(new StringBuilder("Pratik"));
            lst.Add(new StringBuilder("Ganesh"));
            lst.Sort(new Mystringbuilder());
            foreach (StringBuilder ob in lst)
                Console.WriteLine(ob);


        }
    }
}

