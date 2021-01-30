using System;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Drawing;

namespace MeTotem
{
	public partial class Program
	{
		public static string userName;
		public static Image bodyTexture;
		public static void Main(string[] args)
		{
			Console.WriteLine("MeTotem v0");
			Console.WriteLine("---------------------\n");

			Console.Write("Enter the desired username: ");
			userName = Console.ReadLine();
			
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

			Console.WriteLine("Finished!");
		}
	}
}
