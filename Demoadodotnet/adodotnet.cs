using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Myfirstproject2.Demoadodotnet
{
    class adodotnet
    {
        static void Main(string[] args)
        {
            string str = "server=LAPTOP-17SB5VMM\\SQLEXPRESS;Database=Thinkqportal;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlcommand = new SqlCommand("select ename,edept from Employee", con);
                SqlDataReader dr = sqlcommand.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("name=" + dr + "department=" + dr);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
