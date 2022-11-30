using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{


    sealed class Trainer : IComparable<Trainer>
    {
        int trinerid;
        string trainername;


        public int CompareTo(Trainer t2)
        {
            return this.trainername.CompareTo(t2.trainername);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        class SortedList2
        {
            static void Main(string[] args)
            {
                SortedList<Trainer, string> ss = new SortedList<Trainer, string>();
               // ss.Add(new Trainer(101, "medha"), "java");
               // ss.Add(new Trainer(102, "kirti"), "java");
               // ss.Add(new Trainer(103, "deepa"), "C#");

                foreach (KeyValuePair<Trainer, string> kv in ss)
                {
                    Console.WriteLine(kv.Key + " " + kv.Value);
                }
            }
        }
    }
}
