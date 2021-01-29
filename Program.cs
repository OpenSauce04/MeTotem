using System;

namespace MeTotem
{
	class Program
	{
		public static string userName;
		static void Main(string[] args)
		{
			Console.WriteLine("MeTotem v0");
			Console.WriteLine("---------------------\n");

			Console.Write("Enter the desired username: ");
			userName = Console.ReadLine();

			Console.Write("Getting body texture...");

			Console.WriteLine("done");

			Console.Write("Getting head texture...");

			Console.WriteLine("done");

			Console.Write("Personalising manifest.json...");

			Console.WriteLine("done");

			Console.Write("Building pack...");

			Console.WriteLine("done");

			Console.WriteLine("Finished!");
		}
	}
}
