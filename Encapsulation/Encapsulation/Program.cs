using System;

namespace Encapsulation
{
    public class Department
    {
        private string departname;
        // Accessor.  
        public string GetDepartname()
        {
            return departname;
        }
        // Mutator.  
        public void SetDepartname(string a)
        {
            departname = a;
        }


        // use property
        public string Departname
        {
            get
            {
                return departname;
            }
            set
            {
                departname = value;
            }
        }

        //  Raed Only property

        /*public Department(string avalue)
         {
             this.departname = avalue;
         }*/
        private string departname2 = "......Raed Only Property......";

        public string get_Department
        {
            get
            {
                return departname2;
            }
        }
        //Write Only Property
        public string set_Department
        {
            set
            {
                departname = value;
                Console.WriteLine(departname);
            }
        }
        //Static Property
        private static string departName;
         public static string Name
       {
          get { return departName; }
          set { departName= value; }
       }
    }

        public class Departmentmain
        {
            public static void Main(string[] args)
            {
                Department dep= new Department();
                dep.SetDepartname("........Accessor+Mutator........");
                Console.WriteLine(dep.GetDepartname());

                Department dep2= new Department();
                dep2.Departname = "........Use Property.........";
                Console.WriteLine(dep2.Departname);

                // Department read = new Department(".........Read Only Property........");
                Department read = new Department();
                Console.WriteLine(read.get_Department);
                //read.get_Department("CSE");//This is not possible

                Department write = new Department();
                write.set_Department="......Write Only Property......";
            //Console.WriteLine("The Department is :{0}", write.set_Department; //This is not possible

             Department.Name = "........Static Method.........";
             Console.WriteLine(Department.Name);  


            Console.ReadKey();

            }
        }
}
