using System;

namespace Mobiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile mob = new Mobile("Tom","017-xxxxxx-x",20,"iut");


            mob.ShowInfo();
            mob.CallSomeone(5);
            mob.Recharge(20);


            Console.ReadKey();
           
        }
    }
}
