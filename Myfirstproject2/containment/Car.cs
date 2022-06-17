using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject2.containment
{
    class Engine
    {
        public string type;

        public Engine(string type)
        {
            this.type = type;
        }
        public void show()
        {
            Console.WriteLine(type);
        }
    }


    class Car
    {
        int modelno;
        string name;
        int price;
        Engine en;
        public Car(int modelno,string name,int price,Engine en)
        {
            this.modelno = modelno;
            this.name = name;
            this.price = price;
            this.en = en;
        }
        void display()
        {
            Console.WriteLine(modelno + " " + name + " " + price + " ");
            en.show();
        }
  

        static void Main(string[] args)
        {
            Engine e = new Engine("petrol");
            Car c = new Car(1234, "bmw", 76999, e);
            c.display();


        }
    }
}
