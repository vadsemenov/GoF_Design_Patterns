namespace Template_method;

public class ExportZipFile : ExportTemplateMethod
{
    public ExportZipFile(string name) : base(name)
    {
    }

    protected override void PackFile()
    {
        Console.WriteLine("Pack file in zip");
    }

    protected override void SendFile()
    {
        Console.WriteLine("Send file by ftp");
    }
}