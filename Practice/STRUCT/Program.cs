using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT
{
 
    class Program
    {
         struct Books
        {
            public  string title;
            public string author;
            public string subject;
            public int book_id;
        };
        public struct Person
        {
            // Declaring different data types 
            public string Name;
            public int Age;
            public int Weight;

        }

        static void Main(string[] args)
        {
      Books Book1;   /* Declare Book1 of type Book */
      Books Book2;   /* Declare Book2 of type Book */

      /* book 1 specification */
      Book1.title = "C# Programming";
      Book1.author = "Cecilia Hansen"; 
      Book1.subject = "C# Programming Tutorial";

      /* book 2 specification */
      Book2.title = "C# Programming";
      Book2.author = "Zara Ali";
      Book2.subject = "C# Programming Tutorial";

      /* print Book1 info */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);

      Console.WriteLine("");

      /* print Book2 info */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);

      // Declare P1 of type Person 
      Person P1;

      // P1's data 
      P1.Name = "Cecilia Hansen";
      P1.Age = 21;
      P1.Weight = 70;

      // Declare P2 of type Person 
      Person P2;

      // Copying the values of P1 into P2 
      P2 = P1;

      // Displaying the values of P1 
      Console.WriteLine();
      Console.WriteLine("Values Stored in P1");
      Console.WriteLine("Name: " + P1.Name);
      Console.WriteLine("Age: " + P1.Age);
      Console.WriteLine("Weight: " + P1.Weight);
      Console.WriteLine("");

      // Displaying the values of P2 
      Console.WriteLine("Values Stored in P2");
      Console.WriteLine("Name: " + P2.Name);
      Console.WriteLine("Age: " + P2.Age);
      Console.WriteLine("Weight: " + P2.Weight); 

      Console.ReadKey();
        }
    }
}
