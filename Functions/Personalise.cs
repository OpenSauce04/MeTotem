using System;
using System.Net;
using System.IO;

namespace MeTotem
{
	public partial class Program
	{
        public static void Personalise()
        {
			string bmanifest = File.ReadAllText("PackBE/manifest.json");
			bmanifest = bmanifest.Replace("NAME", userName);
			using (var client = new WebClient())
			{
				bmanifest = bmanifest.Replace("uuid1", client.DownloadString("https://www.uuidtools.com/api/generate/v4")
																											   .Replace("[\"", String.Empty)
																											   .Replace("\"]", String.Empty));
				bmanifest = bmanifest.Replace("uuid2", client.DownloadString("https://www.uuidtools.com/api/generate/v4")
																											   .Replace("[\"", String.Empty)
																											   .Replace("\"]", String.Empty));
			}
			File.WriteAllText("PackBE/manifest.json", bmanifest);

			string jmanifest = File.ReadAllText("PackBE/manifest.json");
			jmanifest = jmanifest.Replace("NAME", userName);
			File.WriteAllText("PackJava/pack.mcmeta", bmanifest);
		}
    }
}
