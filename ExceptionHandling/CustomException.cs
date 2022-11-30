using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.ExceptionHandling
{
    class InvalidExperienceException : Exception
    {

    }
    class Emp : Object 
    {
        string name;
        int experience;
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public override string ToString()
        {
            return "Name"+name +"Experience"+experience;
        }
        public int Experience
        {
            set
            {
                if (value < 0)
                    throw new InvalidExperienceException();
                else
                    this.experience = value;
            }
            get { return experience; }
        }

    }

    class CustomException
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            e1.Name = Console.ReadLine();
            try
            {
                e1.Experience = int.Parse(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("experience cant be negative");
            }
            Console.WriteLine(e1);
        }
    }
}
