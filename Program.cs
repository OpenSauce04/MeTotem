using System;
using System.Net;
using System.IO;
using System.IO.Compression;

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
			string text = File.ReadAllText("Pack/manifest.json");
			text = text.Replace("NAME", userName);
			using (var client = new WebClient())
			{
				text = text.Replace("uuid1", client.DownloadString("https://www.uuidtools.com/api/generate/v4")
					                                                                                           .Replace("[\"", String.Empty)
																											   .Replace("\"]", String.Empty));
				text = text.Replace("uuid2", client.DownloadString("https://www.uuidtools.com/api/generate/v4")
																											   .Replace("[\"", String.Empty)
																											   .Replace("\"]", String.Empty));
			}
			File.WriteAllText("Pack/manifest.json", text);
			Console.WriteLine("done");

			Console.Write("Building pack...");
			string packFileName = "MeTotem - " + userName + ".mcpack";
			File.Delete(packFileName);
			ZipFile.CreateFromDirectory("Pack", packFileName);
			Console.WriteLine("done");

			Console.WriteLine("Finished!");
		}
	}
}
