using System.Drawing;
using System.Drawing.Imaging;

namespace MeTotem
{
	public partial class Program
	{
		public static void ProcessBody()
		{
			Bitmap bitmap = new Bitmap(32, 32);
			using (Graphics grfx = Graphics.FromImage(bitmap))
			{
				grfx.DrawImage(bodyTexture, 8, 0);
				bitmap.Save("./PackBE/textures/items/totem.png", ImageFormat.Png);
			}
		}
	}
}
