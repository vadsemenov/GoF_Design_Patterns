namespace Composite;

public class Leaf : Component
{

    public Leaf(string name) : base(name)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Component name is " + _name);
    }
    public override void Add(Component c)
    {
    }

    public override void Remove(Component c)
    {
    }
}