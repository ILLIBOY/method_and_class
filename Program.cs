using System;

namespace method_and_class
{
	class MainClass
	{

		static int sum(params int[] args)
		{
			Console.Write ("Summing...");

			int sum = 0;

			for (int i = 0; i < args.Length; i++) 
			{
				if (i > 0)
					Console.Write (", ");
				Console.Write (args[i]);

				sum += args [i];
			}
			Console.WriteLine ();
			return sum;
		}

		static void Main (string[] args)
		{
			Console.WriteLine ("{0}", sum(3, 4, 5, 6, 7, 8, 9, 10));
		}
	}
}
