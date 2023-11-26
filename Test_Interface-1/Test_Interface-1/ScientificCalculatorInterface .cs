using System;
using System.Collections.Generic;
using System.Text;


namespace Test_Interface_1
{
    class ScientificCalculatorInterface: BasicCalculatorInterface
    {
		int add;
		int subt;
		int mult;
		int div;
		double pow;
		public int sum(int x,int y)
		{
			return add=x + y;
			
		}
		public int sub(int x, int y)
		{
			return subt=x - y;
		}
		public int multiplication(int x, int y)
		{
			return mult= x * y;
		}
		public int division(int x, int y)
		{
			return div=x / y;
		}

		public double  toThePow(int x,int y)
		{
			return pow=Math.Pow(x,y);
		}
		public void show()
        {
			Console.WriteLine("Summation       Result : "+add);
			Console.WriteLine("Subtract        Result : " +subt);
			Console.WriteLine("Division        Result : " + div);
			Console.WriteLine("Math.Pow()      Result : " + pow);
			Console.WriteLine("Multiplication  Result : " + mult);

		}

	}
}
