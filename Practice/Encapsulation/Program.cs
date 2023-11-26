using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume;
            Box b1 = new Box();
            Box b2 = new Box();
            Box b3 = new Box();
            /*
                        b1.height =5;
                        b1.length =5;
                        b1.breadth =5;

                        b2.height =6;
                        b2.length =6;
                        b2.breadth =6;

                        b3.height =7;
                        b3.length =7;
                        b3.breadth =7;

                        volume = b1.height * b1.length * b1.breadth;
                        Console.WriteLine("Box 1 Volume is : "+volume);
                        volume = b2.height * b2.length * b2.breadth;
                        Console.WriteLine("Box 1 Volume is : " + volume);
                        volume = b3.height * b3.length * b3.breadth;
                        Console.WriteLine("Box 1 Volume is : " + volume);
            */
            b1.setLength(5);
            b1.setHeight(5);
            b1.setBreadth(5);

            b2.setLength(6);
            b2.setHeight(6);
            b2.setBreadth(6);

            b3.setLength(7);
            b3.setHeight(7);
            b3.setBreadth(7);

            volume = b1.getVolume();
            Console.WriteLine("Box 1 Volume is : " + volume);

            volume = b2.getVolume();
            Console.WriteLine("Box 2 Volume is : " + volume);

            volume = b3.getVolume();
            Console.WriteLine("Box 3 Volume is : " + volume);
        }
    }
}
