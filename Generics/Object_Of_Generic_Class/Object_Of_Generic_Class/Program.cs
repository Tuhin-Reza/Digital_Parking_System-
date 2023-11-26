using System;

namespace Object_Of_Generic_Class
{
    /*class GFG<T>
      {
          private T data;

          // using properties
          public T value
          {

              // using accessors
              get
              {
                  return data;
              }
              set
              {
                  data = value;
              }
          }
      }

      class Test
      {
          static void Main(string[] args)
          {

              GFG<string> name = new GFG<string>();
              name.value = "GeeksforGeeks";

              GFG<float> version = new GFG<float>();
              version.value = 5.0F;

              Console.WriteLine(name.value);

              Console.WriteLine(version.value);
          }
      }*/
    class MyGenericClass<T>
    {
        //Generic variable
        //The data type is generic
        private T genericMemberVariable;
        //Generic Constructor
        //Constructor accepts one parameter of Generic type
        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }
        //Generic Method
        //Method accepts one Generic type Parameter
        //Method return type also Generic
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable + "\n\n");
            return genericMemberVariable;
        }
        //Generic Property
        //The data type is generic
        public T genericProperty { get; set; }
    }
    class Program
    {
        static void Main()
        {
            MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
            int val = integerGenericClass.genericMethod(200);
            //Console.ReadKey();
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello Generic World");
            stringGenericClass.genericProperty = "This is a generic property example.";
            string result = stringGenericClass.genericMethod("Generic Parameter");
            Console.ReadKey();
        }
    }
}
