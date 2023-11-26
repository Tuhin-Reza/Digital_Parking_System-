using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Updated
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.age = 6;
            c1.name = "Perrry";
            c1.color = "Black";
            Console.WriteLine("Cat is "+c1.color+" and it's name is "+c1.name+" and age is "+c1.age);
            Console.WriteLine("Cat is {0} and it's name is {1} and age is {2}", c1.color, c1.name,c1.age);
            c1.run();
            c1.sleep();
            c1.eat();
            c1.getInfo();

            Cat c2 = new Cat();
            c2.getInfo();

            Cat c3 = new Cat(9,"Wooly","White");
            c3.getInfo();
            ///Ctrl+F5
            GC.Collect();
        }
    }
}
