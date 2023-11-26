using System;

namespace Access_Modifier
{
	class Rabbit
	{
		//A version of Eat() method of Rabbit class
		//with protected access modifier
		protected void Eat()         //eat method with protected access modifier
		{
			Console.WriteLine("Rabbit eats carrots");
		}


		//An overloaded version of Eat() method of Rabbit class
		//with public access modifier
		public void Eat(String st)
		{
			Console.WriteLine("Rabbit eats " + st);
		}

		//Another overloaded version of Eat() method of Rabbit class
		//with private access modifier
		public void Eat(String st1, String st2)
		{
			Console.WriteLine("Rabbit eats " + st1 + " and " + st2);
		}

		//Defining Main method of Rabbit class
		public static void Main(String[] ar)
		{
			//Creating an object of Rabbit class
			Rabbit ob = new Rabbit();

			//Calling an overloaded version of Eat() method
			//Which doesn't take any value
			ob.Eat();

			//Calling an overloaded version of Eat() method
			//Which takes a String value
			ob.Eat("grass");


			//Calling an overloaded version of Eat() method
			//Which takes a String value
			ob.Eat("fruits", "vegetables");
		}
	}
}
