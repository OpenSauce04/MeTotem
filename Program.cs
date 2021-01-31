using System;
using System.Drawing;

namespace MeTotem
{
	public partial class Program
	{
		public static string userName;
		public static Image bodyTexture;
		public static void Main(string[] args)
		{
			Console.WriteLine("MeTotem v1.0.0");
			Console.WriteLine("---------------------\n");

			Console.Write("Enter the desired username: ");
			userName = Console.ReadLine();

			Console.Write("Extracting Data...");
			try
			{
				CleanUp();
			} catch(System.IO.DirectoryNotFoundException) {} // If the directory isn't already there, move on
			ExtractData();
			Console.WriteLine("done");

			Console.Write("Getting body texture...");
			GetBody();
			Console.WriteLine("done");

			Console.Write("Processing body texture...");
			ProcessBody();
			Console.WriteLine("done");

			Console.Write("Getting head texture...");
			GetHead();
			Console.WriteLine("done");

			Console.Write("Personalising manifest.json...");
			Personalise();
			Console.WriteLine("done");

			Console.Write("Building pack...");
			Build();
			Console.WriteLine("done");

			Console.Write("Cleaning up...");
			CleanUp();
			Console.WriteLine("done");

			Console.WriteLine("Finished!");
		}
	}
}
