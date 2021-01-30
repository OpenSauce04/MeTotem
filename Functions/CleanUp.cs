using System.IO;

namespace MeTotem
{
    public partial class Program
    {
        public static void CleanUp()
        {
            Directory.Delete("./PackBE", true);
            Directory.Delete("./PackJava", true);
            File.Delete("PackData.zip");
        }
    }
}
