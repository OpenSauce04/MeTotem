using System.IO;
using System.IO.Compression;

namespace MeTotem
{
    public partial class Program
    {
        public static void Build()
        {
            string packFileName = "MeTotem - " + userName + ".mcpack";
            File.Delete(packFileName);
            ZipFile.CreateFromDirectory("PackBE", packFileName);
        }
    }
}
