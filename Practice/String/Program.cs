using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string using its constructor
            char[] chars = { 'C', 'e', 'c', 'i', 'l', 'i', 'a' };
            string name = new string(chars);
            Console.WriteLine(name);
            //Create a string from a literal
            string firstName = "Cecilia";
            string lastName = "Hansen";
            string age = "25";
            string numberString = "42.22";
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Number: {0}", numberString);
            //Create a string using concatenation
            string nowDateTime = "Date: " + DateTime.Now.ToString("D");
            //string nowDateTime = "Date: " + DateTime.Now.ToString("MM-dd-yy");
            //string nowDateTime = "Date: " + DateTime.Now.ToString("hh:mm:ss.f");
            //string nowDateTime = "Date: " + DateTime.Now.ToString();
            ///The first string adds a text Date and current date value from the DateTime object. 
            string authorDetails = firstName + " " + lastName + " is " + age + " years old.";
            Console.WriteLine(nowDateTime);
            Console.WriteLine(authorDetails);
            ///Create a string using a property or a method
            string authorInfo = "Cecilia Hansen is 25 years old.";
            int startPosition = authorInfo.IndexOf("is ") + 1;
            Console.WriteLine(startPosition);
            string ages= authorInfo.Substring(startPosition + 2, 2);
            Console.WriteLine("Age: " + ages);
            //Get all characters of a string using C#
            string nameString = "Cecilia Hansen";
            for (int counter = 0; counter <= nameString.Length - 1; counter++)
             Console.WriteLine(nameString[counter]);
            //Get size of string
            Console.WriteLine("Size of string {0}", nameString.Length);
 
            Console.ReadKey();
        }
    }
}
