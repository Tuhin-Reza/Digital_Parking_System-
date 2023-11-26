using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Actual
{
    /*  class Student
      {
          //public int[] array = new int[4];
          // public int[] array = { 1, 2, 3, 4, 5 };
          private int[] array = { 1, 2, 3, 4, 5 }; 
          public int this[int index] 
          {
              get
              {

                  if (index >= 0 && index < array.Length)
                  {
                      return array[index];
                  }
                  else
                  {
                      Console.WriteLine("Wrong Index");
                  }
                  return 0;
              }
              set
              {
                  if (index >= 0 && index < array.Length)
                  {
                      if (value > 0)
                      {
                          array[index] = value;
                      }
                      else
                      {
                          Console.WriteLine("Invalid Data");
                      }
                  }
                  else
                  {
                      Console.WriteLine("Wrong Index");
                  }
              }
          }
      }

      class Program
      {
          static void Main(string[] args)
          {
              //Student s = new Student();
              //// s.array[5] = 10; will create exception
              ////s.array = null; will create exception as invalid way
              //foreach (var item in s.array)
              //{
              //    Console.WriteLine(item);
              //}

              Student std = new Student();
             // std.this // invalid for searching indexer
              std[0] = 10;//Valid
              std[0] = -10;//In Valid
              std[6] = 100;
              std[7] = -100;
          }
      }*/

    class IndexerCreation
    {

        // class members
        private string[] val = new string[3];

        // Indexer declaration
        // public - access modifier
        // string - the return type of the Indexer
        // this - is the keyword having a parameters list
        public string this[int index]
        {

            // get Accessor
            // retrieving the values 
            // stored in val[] array
            // of strings
            get
            {

                return val[index];
            }

            // set Accessor
            // setting the value at 
            // passed index of val
            set
            {

                // value keyword is used
                // to define the value 
                // being assigned by the
                // set indexer. 
                val[index] = value;
            }
        }
    }

    // Driver Class
    class main
    {

        // Main Method
        public static void Main()
        {

            // creating an object of parent class which
            // acts as primary address for using Indexer
            IndexerCreation ic = new IndexerCreation();

            // Inserting values in ic[]
            // Here we are using the object
            // of class as an array
            ic[0] = "C";
            ic[0] = "d";
            ic[1] = "CPP";
            ic[2] = "CSHARP";

            Console.Write("Printing values stored in objects used as arrays\n");

            // printing values 
            Console.WriteLine("First value = {0}", ic[0]);
            Console.WriteLine("First value = {0}", ic[0]);
            Console.WriteLine("Second value = {0}", ic[1]);
            Console.WriteLine("Third value = {0}", ic[2]);

        }
    }
}
