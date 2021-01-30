using System.Net;

namespace MeTotem
{
    public partial class Program
    {
        public static void GetHead()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://minotar.net/helm/" + userName + "/256.png", "PackBE/pack_icon.png");
            }
        }
    }
}