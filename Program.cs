using System;

namespace method_and_class
{
	class MainClass
	{

		static void divide(int a, int b, out int quotient, out int remainder)
		{
			quotient = a / b;
			remainder = a % b;
		}

		public static void Main (string[] args)
		{
			int a = 20;
			int b = 3;
			int c;
			int d;
			divide (a, b, out c, out d);
			Console.WriteLine ("a:{0}, b:{1}, a/b:{2}, a%b:{3}", a, b, c, d);
		}
	}
}
