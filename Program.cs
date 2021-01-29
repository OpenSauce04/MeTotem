using System;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;
namespace MeTotem
{
	class Program
	{
		public static string userName;
		public static Image bodyTexture;
		static void Main(string[] args)
		{
			Console.WriteLine("MeTotem v0");
			Console.WriteLine("---------------------\n");

			Console.Write("Enter the desired username: ");
			userName = Console.ReadLine();

			Console.Write("Getting body texture...");
			using (var client = new WebClient())
			{
				using (MemoryStream memstr = new MemoryStream(client.DownloadData("https://minotar.net/armor/body/" + userName + "/16.png")))
				{
					bodyTexture = Image.FromStream(memstr);
				}
			}
			Console.WriteLine("done");

			Console.Write("Processing body texture...");
			Bitmap bitmap = new Bitmap(32, 32);
			using (Graphics grfx = Graphics.FromImage(bitmap))
			{
				grfx.DrawImage(bodyTexture, 8, 0);
				bitmap.Save("./PackBE/textures/items/totem.png", ImageFormat.Png);
			}
			Console.WriteLine("done");

			Console.Write("Getting head texture...");
			using (var client = new WebClient())
			{
				client.DownloadFile("https://minotar.net/helm/" + userName + "/256.png", "PackBE/pack_icon.png");
			}
			Console.WriteLine("done");

			Console.Write("Personalising manifest.json...");
			string text = File.ReadAllText("PackBE/manifest.json");
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
			File.WriteAllText("PackBE/manifest.json", text);
			Console.WriteLine("done");

			Console.Write("Building pack...");
			string packFileName = "MeTotem - " + userName + ".mcpack";
			File.Delete(packFileName);
			ZipFile.CreateFromDirectory("PackBE", packFileName);
			Console.WriteLine("done");

			Console.WriteLine("Finished!");
		}
	}
}
