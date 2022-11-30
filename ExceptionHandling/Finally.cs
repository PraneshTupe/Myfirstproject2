using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.ExceptionHandling
{
    class Finally
    {
        static void Mian(string[] args)
        {
           //treamReader sr = null;
            try
            {
                Console.WriteLine("enter number");
                int a = int.Parse(Console.ReadLine());
               //r = new StreamReader("D://a.txt");
                //nsole.WriteLine(sr.Read());
                //nsole.WriteLine(sr.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally");
              //if (sr != null)
                //  sr.Close();
            }
        }
    }
}
