using System;

namespace Inheitance
{
	class Sports
	{
		//The original Play() method with no arguments
		public void Play()
		{
			Console.WriteLine("Play any sport");
		}
	}


	//Defining a Tennis class, which is subclass of Sports class.
	class Tennis : Sports
	{
		//An overloaded Play() method of Tennis class, with String arguments
		public void Play(String name)
		{
			Console.WriteLine("Play ");
		}
	}

	class Overload
	{
		public static void Main(String[] ar)
		{
			//Creating an object of Tennis class.
			Tennis ob = new Tennis();

			//Calling a version of the Play() method of Tennis class
			//Which was inherited by Sports class
			//And, takes no arguments.
			ob.Play();

			//Calling a version of the Play() method of Tennis class
			//Which takes a String argument.
			ob.Play("Tennis");
		}
	}

}
