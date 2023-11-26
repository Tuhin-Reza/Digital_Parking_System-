using System;

namespace Copy_Constructor
{
    //Example 1
    /* class technicalscripter
    {

        // variables 
        private string topic_name;
        private int article_no;

        // parametrized constructor 
        public technicalscripter(string topic_name, int article_no)
        {
            this.topic_name = topic_name;
            this.article_no = article_no;
        }
        // copy constructor 
        public technicalscripter(technicalscripter tech)
        {
            topic_name = tech.topic_name;
            article_no = tech.article_no;
        }

        // getting the topic name and  
        // number of articles published 
        public string Data
        {

            get
            {
                return "The name of topic is: " + topic_name +
                       " and number of published article is: " +
                                        article_no.ToString();
            }
        }
    }

    // Driver Class 
    public class GFG
    {
        // Main Method 
        static public void Main()
        {
            // creating object t1 
            // and provide value to the object 
            technicalscripter t1 = new technicalscripter(" C# | Copy Constructor", 38);

            // Creating object t2 and 
            // copy the data of t1 object 
            // into t2 object 
            technicalscripter t2 = new technicalscripter(t1);

            Console.WriteLine(t2.Data);
            Console.ReadLine();
        }
    }*/

    //Example 2

    /* class Vehicle
     {
         // variables 
         private string name;
         private string color;
         private int quantity;
         //  Copy constructor 
         public Vehicle(Vehicle a)
         {
             name = a.name;
             color = a.color;
             quantity = a.quantity;
         }
         // Parameterized constructor 
         public Vehicle(string name, string color, int quantity)
         {
             this.name = name;
             this.color = color;
             this.quantity = quantity;
         }

         // Get deatils of Vehicles 
         public string DetailsofVehicle
         {
             get
             {
                 return "Type: " + name.ToString() +
                        "\nColor: " + color.ToString() +
                        "\nQuantity: " + quantity.ToString();//ToString() Returns a string that represents the current object.
             }
         }

         // Main Method 
         public static void Main()
         {

             // Create a new object. 
             Vehicle v1 = new Vehicle("Bike", "Black", 40);
            // Console.WriteLine(v1.DetailsofVehicle);

             // here is v1 details are copied to v2. 
             Vehicle v2 = new Vehicle(v1);

             Console.WriteLine(v2.DetailsofVehicle);
         }
     }*/

    class Employee
    {
        int eid, age;
        string address, name;
        public Employee()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS");
            Console.WriteLine("Enter the employee id");
            this.eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee age");
            this.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the employee address:");
            this.address = Console.ReadLine();
        }
        public Employee(Employee tempobj)
        {
            this.eid = tempobj.eid;
            this.age = tempobj.age;
            this.name = tempobj.name;
            this.address = tempobj.address;
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Employee id is:  " + this.eid);
            Console.WriteLine("Employee name is:  " + this.name);
            Console.WriteLine("Employee age is:  " + this.age);
            Console.WriteLine("Employee address is:  " + this.address);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee(e1);
            e1.Display();
            e2.Display();
            Console.ReadKey();
        }
    }
}
