using System;
using System.Net;
using System.IO;

namespace MeTotem
{
	public partial class Program
	{
        public static void Personalise()
        {
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
		}
    }
}
