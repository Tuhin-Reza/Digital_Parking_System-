using System;

namespace Object_Type
{
    /* class Program
     {
          static void Main(string[] args)
               {
                   int num = 2020;
                   // boxing 
                   object obj = num;

                   // value of num to be change 
                   num = 100;

                   Console.WriteLine("Value  - type value of num is : {0}", num);
                   Console.WriteLine("Object - type value of obj is : {0}", obj);

                   // unboxing 
                   int i = (int)obj;
                   Console.WriteLine("\nValue of ob object is : " + obj);
                   Console.WriteLine("Value of i is         : " + i);


                   Console.ReadKey();
               }
          class TutShare
          {
              public int value1 = 10;
              public string value2 = "qwertyuiop";
              public void Share()
              {
                  Console.WriteLine("Inside Share method");
              }
              public void UnBoxingExample()
              {
                  // This is Boxing as we are converting a 'value type' value into 'object type'   
                  object o = "yeepy";
                  Console.WriteLine("Object - type value of o is : {0}", o);

                  // This is Unboxing as we are converting a 'object type' value into 'value type'   
                  string text = (string)o;
                  Console.WriteLine("Value  - type value of text is : {0}", text);
              }
          }
          static void Main(string[] args)
          {
              Console.WriteLine("hello Tutpoint");

              TutShare tutShare = new TutShare();

              object obje = 1000;
              Console.WriteLine(obje);

              //This is another example of boxing  
              obje = tutShare.value1;
              Console.WriteLine(obje);
              Console.WriteLine(obje.GetType()); // GetType() is used to get the data type  

              // we are assigning value of 'value2' variable to 'obje'  
              obje = tutShare.value2;
              Console.WriteLine(obje);
              Console.WriteLine(obje.GetType()); // GetType() is used to get the data type  

              object objTutShare = new TutShare();
              // type casting 'objTutShare' to 'TutShare' type  
              tutShare = (TutShare)objTutShare;
              tutShare.Share();

              tutShare.UnBoxingExample();

              Console.ReadLine();
          }

          private static void Main()
          {
              // bool IsEqual = ClsCalculator.AreEqual(10, 20);
              //bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
              bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);
              if (IsEqual)
              {
                  Console.WriteLine("Both are Equal");
              }
              else
              {
                  Console.WriteLine("Both are Not Equal");
              }
              Console.ReadKey();
          }
          public class ClsCalculator
          {
              public static bool AreEqual(int value1, int value2)
              {
                  return value1 == value2;
              }
              //Now this method can accept any data type
              public static bool AreEqual(object value1, object value2)
              {
                  return value1 == value2;
              }
          }
     }*/
}
