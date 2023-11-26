using System;
using System.Collections;

namespace Array_List
{
    /*class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Initial Capacity: " + al.Capacity);

            al.Add(10);

            Console.WriteLine("Capacity after adding first item: " + al.Capacity);

            al.Add("hello");
            al.Add(true);
            al.Add(3.14f);

            Console.WriteLine("Capacity after adding fourth item: " + al.Capacity);

            al.Add('A');
            al.Add(DateTime.Now);

            Console.WriteLine("Capacity after adding 5th element: " + al.Capacity);

            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i] + "  ");
            }
            Console.WriteLine();
            
            al.Remove(true);

            // al.RemoveAt(2);//You can also remove element by using index position
          
            foreach (object obj in al)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
           
            al.Insert(2, false);
         
            foreach (object obj in al)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
            // creating new ArrayList collection by passing the old 
            // array list as parameter
            ArrayList coll = new ArrayList(al);
            Console.WriteLine("Initial capacity of new array list collection:" + coll.Capacity);
          
            foreach (object obj in coll)
            {
                Console.Write(obj + "  ");
            }
            Console.ReadKey();
        }
    }*/
    class Program
    {
        static void Main()
        {
            //
            // Create an ArrayList and add two ints.
            //
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add(7);
            //
            // Use ArrayList with method.
            //
            Example(list);
        }

        static void Example(ArrayList list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
