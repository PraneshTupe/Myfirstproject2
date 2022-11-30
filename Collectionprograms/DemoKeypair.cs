using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{
    class DemoKeypair
    {
       static void Main(string[] args)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("pratik", 91);
            d1.Add("pranesh", 70);
            d1.Add("ganesh", 74);
            d1.Add("pranav", 98);
            d1.Add("avinash", 89);
            Console.WriteLine(d1["pratik"]);
            d1["pratik"] = 78;
            d1.Remove("avinash");
            Console.WriteLine(d1.ContainsKey("pranesh"));
            Console.WriteLine(d1.ContainsValue(98));
            foreach(KeyValuePair<string,int> kv in d1)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
                   




        }
    }
}
