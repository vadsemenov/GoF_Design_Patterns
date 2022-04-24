namespace Template_method;

public abstract class ExportTemplateMethod
{
    private string _name;

    protected ExportTemplateMethod(string name)
    {
        _name = name;
        Console.WriteLine(_name);
        CreateFile();
        PackFile();
        SendFile();
        DeleteFile();
    }

    private void CreateFile()
    {
        Console.WriteLine("Create file");
    }

    protected abstract void PackFile();
    protected abstract void SendFile();

    private void DeleteFile()
    {
        Console.WriteLine("Delete File");
    }
}