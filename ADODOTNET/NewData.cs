using System;
using System.Data.SqlClient;
using System.Text;

namespace Myfirstproject2.ADODOTNET
{
    class NewData
    { 
        static void Main(string[] args)
        {
            string str = "server=LAPTOP-17SB5VMM\\SQLEXPRESS;Database=hr;Integrated Security=True";
            SqlConnection c = new SqlConnection(str);
            c.Open();
            SqlCommand cmd = new SqlCommand("select first_name,salary,department_name from employees e inner join departments d on e.department_id=d.department_id", c);
                SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) ;
            {
                Console.WriteLine(reader[0] + " " + reader[1] + "" + reader[2]);
            }
            c.Close();

        }
    }
        

}
