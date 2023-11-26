using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Class
{

    //class demo
    //{
    //    int valu;
    //    public demo(int v)
    //    {
    //        this.valu = v;
    //    }
    //    public int getValue()
    //    {
    //        return this.valu;
    //    }
    //}

    class demo<T>
    {
        T valu;
        public demo()
        {
        }
        public demo(T v)
        {
            this.valu = v;
        }
        public T getValue()
        {
            return this.valu;
        }

        public T VALUE
        {
            get 
            {
                return this.valu;
            }
            set
            {
                this.valu = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // demo d = new demo(); Error as parameterized constructor

            //demo d = new demo(50);
            //demo dd = new demo("Cecilia");//Error as string 

            demo<int> d = new demo<int>(50);
            demo<string> dd = new demo<string>("Cecilia");
            demo<char> ddd = new demo<char>('N');

            Console.WriteLine(d.getValue());
            Console.WriteLine(dd.getValue());
            Console.WriteLine(ddd.getValue());

            demo<double> dddd = new demo<double>();
            dddd.VALUE = 50.5;
            Console.WriteLine(dddd.VALUE);
            demo<string> ddddd = new demo<string>();
            ddddd.VALUE = "Hansen";
            Console.WriteLine(ddddd.VALUE);


        }
    }
}
