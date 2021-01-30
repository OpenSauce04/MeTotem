using System.Net;
using System.IO;
using System.Drawing;

namespace MeTotem
{
	public partial class Program
    {
		public static void GetBody() {
        using (var client = new WebClient())
			{
				using (MemoryStream memstr = new MemoryStream(client.DownloadData("https://minotar.net/armor/body/" + userName + "/16.png")))
				{
					bodyTexture = Image.FromStream(memstr);
				}
			}
		}
    }
}
