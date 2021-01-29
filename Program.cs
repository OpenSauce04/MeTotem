using System;
using System.Net;
using System.IO;

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
			using (var client = new WebClient())
			{
				client.DownloadFile("https://minotar.net/armor/body/" + userName + "/16.png", "Pack/textures/items/totem.png");
			}
			Console.WriteLine("done");

			Console.Write("Getting head texture...");
			using (var client = new WebClient())
			{
				client.DownloadFile("https://minotar.net/helm/" + userName + "/256.png", "Pack/pack_icon.png");
			}
			Console.WriteLine("done");

			Console.Write("Personalising manifest.json...");

			Console.WriteLine("done");

			Console.Write("Building pack...");

			Console.WriteLine("done");

			Console.WriteLine("Finished!");
		}
	}
}
