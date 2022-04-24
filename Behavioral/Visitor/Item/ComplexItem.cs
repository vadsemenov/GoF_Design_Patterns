namespace Visitor.Item;

public class ComplexItem : Item
{
    public int Data2 { get;}
    public ComplexItem(int data,int data2) : base(data)
    {
        Data2 = data2;
    }

    public override void Display(ConsoleVisitor visitor)
    {
        visitor.Process(this);
    }
}