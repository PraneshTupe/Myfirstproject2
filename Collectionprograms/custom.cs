using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.Collectionprograms
{
    
    
        class book:IComparable<book>
        {
            string bookname;
            int price;
            string authorname;
       
             public int CompareTo(book b2)
        {
            if (this.price == b2.price)
            {
                return this.authorname.CompareTo(b2.authorname);
            }
            return this.price.CompareTo(b2.price);
            /*if(this.price<b2.price)
            return -1;
            if(this.price>b2.price)
            return 1;
            else
           return 0;*/
                
            
        }

            public book(string bookname, int price, string authorname)
            {
                this.Bookname = bookname;
                this.Price = price;
                this.Authorname = authorname;
            }

            public string Bookname { get => bookname; set => bookname = value; }
            public int Price { get => price; set => price = value; }
            public string Authorname { get => authorname; set => authorname = value; }

            public override string ToString()
            {
                return $"Bookname:{bookname}Authorname{authorname}Price{price}";
            }
        }
    
    class custom
    {
        static void Main(string[] args)
        {
            List<book> lst = new List<book>();
            lst.Add(new book("java", 900 , "kanetkar"));
            lst.Add(new book("csharp", 300 , "kathy"));
            lst.Add(new book("angular", 1000 , "balguruswamy"));
            lst.Add(new book("c++", 300, "aniket"));
            lst.Sort();
            
            foreach(book b in lst)
            {
                Console.WriteLine(b);
            }

        }
    }
   
}

