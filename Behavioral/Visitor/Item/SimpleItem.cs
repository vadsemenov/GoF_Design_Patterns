namespace Visitor.Item;

public class SimpleItem : Item
{
    public SimpleItem(int data) : base(data)
    {
    }

    public override void Display(ConsoleVisitor visitor)
    {
        visitor.Process(this);
    }
}