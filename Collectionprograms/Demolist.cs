using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collection_programs
{
    class Demolist
    {
        static void Main(string[] args)
        {
            //In list duplicates allowed.
            List<string> lst = new List<string>();
            Console.WriteLine(lst.Count);//0
            Console.WriteLine(lst.Capacity);//4
            lst.Add("viraj");
            lst.Add("om");
            lst.Add("priya");
            lst.Add("riya");
            lst.Add("pratik");
            lst.Add("amey");
            lst.Add("viraj");
            lst.Insert(1, "pranav");
            lst[0] = "komal";
            lst.RemoveAt(1);
            lst.Remove("viraj");
            //lst.clear();
            //clear,indexof,Lastindexof,Addrange,Removerange,sort,reverse.
            int idx = lst.IndexOf("pratik");
            int lastidx = lst.LastIndexOf("viraj");
            lst.Reverse();
            List<string> l2 = new List<string>()
            { "a","b","c"};
            l2.AddRange(lst);
            l2.Add("pranesh");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst + " ");
            }
            Console.WriteLine();
            for (int i = lst.Count - 1; i >= 0; i--) ;
            {
                Console.Write(lst + " ");

            }
            Console.WriteLine();
            foreach (string s in lst)
            {
                Console.Write(s);
            }
        }
    }
}

  //  class Demolist2
   // {
     //
     //static void main(string[] args)
       // {
          //  List<string> lst = new List<string>();
           // lst.Add("viraj");
           // lst.Add("om");
            //lst.Add("priya");
           // lst.Add("riya");
            //lst.Add("pratik");
            //lst.Add("amey");
            //st.RemoveRange(1, 3);
           // lst.Sort();
           // foreach(string s in lst)
          //  {
           //     Console.Write(lst + "");
           // }
       // }
   // }

