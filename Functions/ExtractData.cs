using System.IO.Compression;

namespace MeTotem
{
    public partial class Program
    {
        public static void ExtractData()
        {
            ZipFile.ExtractToDirectory("./PackData.zip", "./");
        }
    }
}
