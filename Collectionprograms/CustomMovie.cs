using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{
    class movie:IComparable<movie>
    {
        string moviename;
        int rating_id;
        string dname;
        public int CompareTo(movie m)
        {
            return this.moviename.CompareTo(m.moviename);
        }

        public movie(string moviename, int rating_id, string dname)
        {
            this.Moviename = moviename;
            this.Rating_id = rating_id;
            this.Dname = dname;
        }

        public string Moviename { get => moviename; set => moviename = value; }
        public int Rating_id { get => rating_id; set => rating_id = value; }
        public string Dname { get => dname; set => dname = value; }

        public override string ToString()
        {
            return $"Moviename:{moviename} Rating_id:{rating_id} Dname:{dname}";
        }
    }
    class CustomMovie
    {
        static void Main(string[] args)
        {
            List<movie> lst = new List<movie>();
            lst.Add(new movie("RRR", 3, "A"));
            lst.Add(new movie("Liger", 5, "D"));
            lst.Add(new movie("Bhramastra", 7, "C"));
            lst.Sort();
            foreach(movie m in lst)
            {
                Console.WriteLine(m);
            }
        }
    }
}
