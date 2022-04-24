using Visitor.Item;

namespace Visitor;

public class ConsoleVisitor
{
    public void Process(SimpleItem simpleItem)
    {
        Console.WriteLine("Simple Item:" + simpleItem.Data);
    }

    public void Process(ComplexItem complexItem)
    {
        Console.WriteLine("Complex Item:" + complexItem.Data + " " + complexItem.Data2);
    }
}