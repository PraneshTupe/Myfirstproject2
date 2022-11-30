using System;
using System.Collections.Generic;
using System.Text;
//namespace Myfirstproject2.Collectionprograms
//
  /*  class Sortedbyprice : IComparer<Book> 
    { 
        public int Compare(Book x,Book y)
        {
            return x.price.CompareTo(y.price);
        }
    }*/
  /* internal class Book : IComparable<Book>
    {
        string Bookname;
        int Price;
        string Authorname;

        public Book(string bookname, int price, string authorname)
        {
            Bookname1 = bookname;
            Price1 = price;
            Authorname1 = authorname;
        }
        public Book()
        {

        }

        public string Bookname1 { get => Bookname; set => Bookname = value; }
        public int Price1{ get => Price; set => Price = value; }
        public string Authorname1 { get => Authorname; set => Authorname = value; }

        public int CompareTo(Book b2)
        {
            return this.Bookname.CompareTo(b2.Bookname);
        }
        public override string ToString()
        {
            return "bookname:" + Bookname + "price:" + Price + "Authorname:" + Authorname;
        }
    }*/

   /* class Booksortedlist
    {
        static void Main(string[] args)
        {
            SortedList<Book, int> ss = new SortedList<Book, int>(new //Sortedbyprice());
           // ss.Add(new Book("java", 800, "ABC"),111));
            //ss.Add(new Book("csharp", 700, "AAA"),222);
           // ss.Add(new Book("angular", 600, "BBB"), 333);

            foreach(KeyValuePair<Book,int> kv in ss)
            {
                Console.WriteLine(kv.Key+">>>>"+kv.Value);
            }

        }
    }
}*/
//}