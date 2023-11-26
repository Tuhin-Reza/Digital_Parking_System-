using System;
using System.Collections.Generic;
namespace GenericListCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>();//Createing an interger list
           // integerList.Add(5);
            Console.WriteLine("Initial Capacity : " + integerList.Capacity);
            integerList.Add(10);
            Console.WriteLine("Capacity after adding first item: " + integerList.Capacity);

            integerList.Add(20);
            integerList.Add(30);
            integerList.Add(40);

            Console.WriteLine("Capacity after adding fourth item: " + integerList.Capacity);

            integerList.Add(60);

            Console.WriteLine("Capacity after adding 5th element: " + integerList.Capacity);

            //Printing the List items using for loop 
            Console.WriteLine("Printing the List items using for loop:");
            for (int i = 0; i < integerList.Count; i++)
            {
                Console.Write(integerList[i] + "  ");
            }
            Console.WriteLine();
            
            integerList.Remove(30);

            //You can also remove element by using index position
            //integerList.RemoveAt(2);
            //Printing the list items using foreach loop after
            //removing an element from the collection


            Console.WriteLine("List items after removing the value 30 :");
            foreach (int item in integerList)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            //inserting values into the middle of the list collection
            integerList.Insert(2, 25);
          
            Console.WriteLine("List items after inserting the value 25 in the index 2");
            foreach (int item in integerList)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            // creating new ArrayList collection by passing the old 
            // array list as parameter

            List<int> newIntegerList = new List<int>(integerList);
            Console.WriteLine("Initial capacity of new list collection:" + newIntegerList.Capacity);
           

            Console.WriteLine("Printing the new List items which is created from the old list");
            foreach (int item in newIntegerList)
            {
                Console.Write(item + "  ");
            }
            Console.ReadKey();
        }
    }
}