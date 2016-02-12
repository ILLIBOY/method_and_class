using System;

namespace method_and_class
{
	class MainClass
	{

		static void swap(ref int a, ref int b)
		{
			int temp = b;
			b = a;
			a = temp;
		}

		public static void Main (string[] args)
		{
			int x = 3;
			int y = 4;

			Console.WriteLine ("x:{0}, y:{1}", x, y);

			swap (ref x, ref y);

			Console.WriteLine ("x:{0}, y:{1}", x, y);
		}
	}
}
