using System.IO;
using System.IO.Compression;

namespace MeTotem
{
    public partial class Program
    {
        public static void Build()
        {
            string bPackFileName = "MeTotem-" + userName + "-Bedrock.mcpack";
            string jPackFileName = "MeTotem-" + userName + "-Java.zip";
            File.Delete(bPackFileName);
            File.Delete(jPackFileName);
            ZipFile.CreateFromDirectory("PackBE", bPackFileName);
            ZipFile.CreateFromDirectory("PackJava", jPackFileName);
        }
    }
}
