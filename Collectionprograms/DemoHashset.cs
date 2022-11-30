using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Myfirstproject2.Collectionprograms
{
    class DemoHashset
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("pratik");
            hs.Add("pranav");
            hs.Add("pranesh");
            hs.Add("priyashree");
            hs.Add("pradnya");
            hs.Add("priyashree");
            hs.Add("pradnya");

            foreach(string data in hs)
            {
                Console.WriteLine(data);
            }
            HashSet<string> hs1 = new HashSet<string>();
            hs1.Add("avinash");
            hs1.Add("ganesh");
            hs1.Add("pranesh");
            hs1.Add("pratik");

            Console.WriteLine("after intersection");

            hs.IntersectWith(hs1);

           // HashSet<string> h2 = hs.Intersect(hs1).ToHashset();

        }
    }
}
