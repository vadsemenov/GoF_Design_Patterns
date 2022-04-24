namespace Template_method;

public class ExportRarFile : ExportTemplateMethod
{
    public ExportRarFile(string name) : base(name)
    {
    }

    protected override void PackFile()
    {
        Console.WriteLine("Pack file in Rar");
    }

    protected override void SendFile()
    {
        Console.WriteLine("Send file by email");
    }
}