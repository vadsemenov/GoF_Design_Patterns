namespace Visitor.Item;

public abstract class Item
{
    public int Data { get; }

    protected Item(int data)
    {
        Data = data;
    }

    public abstract void Display(ConsoleVisitor visitor);
}