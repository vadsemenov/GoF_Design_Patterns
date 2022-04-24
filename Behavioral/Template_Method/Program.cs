namespace Template_method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExportRarFile exportRarFile = new ExportRarFile("Rar file");
            ExportZipFile exportZipFile = new ExportZipFile("Zip file");
        }
    }

}

