using System;

namespace Abstract
{
    /*Example, the abstract class MyClass has one abstract method which has 
    got various implementations in sub-classes.*/
    /* public abstract class MyClass
     {
         public abstract void calculate(double x);
     }
     class Sub1 : MyClass
     {
         public override void calculate(double x)
         {
             Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
         }
     }
     public class Sub2 : MyClass
     {
         public override void calculate(double x)
         {
             Console.WriteLine("SQUARE is :" + (x * x));
         }
     }
     public class Sub3 : MyClass
     {
         public override void calculate(double x)
         {
             Console.WriteLine("CUBE is :" + (x * x * x));
         }
     }
     class Test
     {
         static void Main(string[] args)
         {
             Sub1 obj1 = new Sub1();
             Sub2 obj2 = new Sub2();
             Sub3 obj3 = new Sub3();
             obj1.calculate(9);
             obj2.calculate(9);
             obj3.calculate(9);
             Console.ReadKey();
         }
     }*/


    // we calculate the electricity bills for commercial and domestic plans using abstract class and abstract methods.
    /*public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void calculation(int units)
        {
            Console.Write("BILL AMOUNT FOR " + units + " UNITS is: Rs.");
            Console.WriteLine(rate * units);
        }
    }
    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
        }
    }
    class DomesticlPlan : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("COMMERCIAL CONNECTION");
            p = new CommercialPlan();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("DOMESTIC CONNECTION");
            p = new DomesticlPlan();
            p.getRate();
            p.calculation(150);
            Console.ReadKey();
        }
    }*/

    //Example to show the use of abstract methods in C#.

    /* abstract class ClsEmployee
     {
         protected int EmpId, EAge;
         protected string EName, EAddress;
         public abstract void GetEmpData();
         public virtual void DisplayEmpData()
         {
             Console.WriteLine("Employee Id Is: " + this.EmpId);
             Console.WriteLine("Employee Name Is: " + this.EName);
             Console.WriteLine("Employee Address Is: " + EAddress);
             Console.WriteLine("Employee Age is: " + this.EAge);
         }
         public ClsEmployee()
         {
             Console.WriteLine("ABSTRACT CLASS CONSTRUCTOR");
         }
     }
     class ClsManager : ClsEmployee
     {
         double Bonus, CA;
         public override void GetEmpData()
         {
             Console.WriteLine("ENTER MANAGER DETAILS");
             Console.WriteLine("Enter the Manager Id: ");
             EmpId = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the Manager name: ");
             EName = Console.ReadLine();
             Console.WriteLine("Enter the manager Bonus: ");
             Bonus = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter the Manager CA: ");
             CA = double.Parse(Console.ReadLine());
         }
         public override void DisplayEmpData()
         {
             Console.WriteLine("manager id is: " + EmpId);
             Console.WriteLine("manager name is: " + EName);
             Console.WriteLine("manager bonus is: " + Bonus);
             Console.WriteLine("Manager CA is: " + CA);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             ClsManager cm = new ClsManager();
             cm.GetEmpData();
             cm.DisplayEmpData();
             Console.ReadKey();
         }
     }*/

    abstract class BaseClass   // Abstract class
    {
        protected int _x = 100;
        protected int _y = 150;
        abstract public  void AbstractMethod();   // Abstract method
        public abstract int X { get; }
        public abstract int Y { get; }
    }

    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public override int X   // overriding property
        {
            get
            {
                return _x + 10;
            }
        }

        public override int Y   // overriding property
        {
            get
            {
                return _y + 10;
            }
        }

        static void Main()
        {
            var o = new DerivedClass();
            o.AbstractMethod();
            Console.WriteLine($"x = {o.X}, y = {o.Y}");
        }
    }
}
