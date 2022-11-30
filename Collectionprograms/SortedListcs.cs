using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{
    class SortedListcs
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("pranesh", 90);
            ss.Add("avinash", 97);
            ss.Add("pranav", 78);
            ss.Add("akshay", 87);
            ss["pranav"] = 89;
            ss.Remove("akshay"); 
            foreach(KeyValuePair<string,int> kv in ss)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            foreach(string k in ss.Keys)
            {
                Console.WriteLine(k + "---->" + ss[k]);
            }
    }   }
    

}
