using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace MeTotem
{
    public partial class Program
    {
        public static void ExtractData()
        {
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("MeTotem.PackData.zip"))
            {
                using (var file = new FileStream("PackData.zip", FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
            ZipFile.ExtractToDirectory("PackData.zip", "./");
        }
    }
}