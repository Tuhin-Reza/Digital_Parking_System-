using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Updated
{
    class Cat
    {
        public int age;
        public string name;
        public string color;

        public Cat()
        {
            age = 10;
            name = "Peu";
            color = "Brown";
        }
        //public Cat(int a, string n, string c)
        //{
        //    age = a;
        //    name = n;
        //    color = c;
        //}
        public Cat(int age, string name, string color)
        {
            this.age = age;
            this.name = name;
            this.color = color;
        }
        ~Cat()
        {
            Console.WriteLine("Destructor................");
        }
        public void run()
        {
            Console.WriteLine("Running................");
        }
        public void sleep()
        {
            Console.WriteLine("Sleeping................");
        }
        public void eat()
        {
            Console.WriteLine("Eating................");
        }

        public void getInfo()
        {
            Console.WriteLine("Cat is {0} and it's name is {1} and age is {2}",color,name,age);
        }
    }
}
