using System;
using System.Data.SqlClient;
using System.Text; 

namespace Myfirstproject2.ADODOTNET
{
  
    
       class DBConnect
       { 
            const string connectionstring = "server=LAPTOP-17SB5VMM\\SQLEXPRESS;Database=librarymanagemant;Integrated Security=True";
        public static SqlConnection GetConnection()
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionstring);
                    return con;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            return null;
            }
           
       }
    class Demoinsert
    {
        static void Main(string[] args)
        {
            SqlConnection c = DBConnect.GetConnection();
            c.Open();
            while (true)
            {

                SqlCommand cmd = new SqlCommand("insert into book values(@id,@bknm,@anm,@price,@no)", c);
               
                Console.WriteLine("enter bookid");
                int bid =int.Parse( Console.ReadLine());
                Console.WriteLine("enter bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter aname");
                string aname = Console.ReadLine();
                Console.WriteLine("enter price");
                int pr = int.Parse(Console.ReadLine());
                Console.WriteLine("enter noofcopies");
                int copies =int.Parse( Console.ReadLine());
                cmd.Parameters.AddWithValue("@id", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@anm", aname);
                cmd.Parameters.AddWithValue("@price", pr);
                cmd.Parameters.AddWithValue("@no", copies);
                int count = cmd.ExecuteNonQuery();
                Console.WriteLine(count);
                if (count > 0)
                {
                    Console.WriteLine("record inserted successfully");
                }
                Console.WriteLine("do you want to continue");
                string choice = Console.ReadLine();
                if (choice == "no")
                {
                
                    break;
                }

            }

        }
    }
    class DemoMenu
    {
        static void ViewAllBooks()
        {
            SqlConnection c = null;
            try
            {
                c = DBConnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("select * from book", c);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("*********viewallbooks**********");
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                c.Close();
            }
        }
        static void AddBook()
        {
            SqlConnection c = null;
            try
            {
                Console.WriteLine("***********AddBook**********");
                c = DBConnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("insert into book values(@i,@bknm,@anm,@price,@no)", c);
                Console.WriteLine("enter bookid");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter aname");
                string aname = Console.ReadLine();
                Console.WriteLine("enter price");
                int pr = int.Parse(Console.ReadLine());
                Console.WriteLine("enter noofcopies");
                int copies = int.Parse(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void DeleteBook()
        {
            Console.WriteLine("enter bookid u want to delete");
            int bid = int.Parse(Console.ReadLine());
            SqlConnection c = null;
            try
            {
                Console.WriteLine("***********AddNewBook*********");
                c = DBConnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("delete from book where bookid=@id", c);
                cmd.Parameters.AddWithValue("@id", bid);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Deleted Successfully:" + count);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                c.Close();

            }
        }
        static void UpdateBook()
        {
            SqlConnection c = null;
            try
            {
                Console.WriteLine("************editbook**********");
                c = DBConnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("update book set bookname=@bknm,authorname=@anm,price=@price where bookid=@id", c);
                Console.WriteLine("enter bookid you want to update");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter new bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter authorname");
                string authorname = Console.ReadLine();
                Console.WriteLine("enter new price");
                int pr = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@id", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@anm", authorname);

              
                cmd.Parameters.AddWithValue("price", pr);
                int count = cmd.ExecuteNonQuery();




            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("**************");
                Console.WriteLine("1-View all books");
                Console.WriteLine("2-Add books");

                Console.WriteLine("3-Delte book");
                Console.WriteLine("4-Update book");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: ViewAllBooks();
                        break;
                    case 2: AddBook();
                        break;
                    case 3: DeleteBook();
                        break;
                    case 4: UpdateBook();
                        break;
                    default: Console.WriteLine("wrong choice");
                        break;


                }
                Console.WriteLine("do you want continue yes/no");
                string ch = Console.ReadLine();
                if (ch == "no")
                    break;


            } while (true);
        }

    }
    
}
