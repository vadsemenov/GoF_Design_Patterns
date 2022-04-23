namespace Composite;

public class Composite:Component
{
    List<Component> childrens = new List<Component>();

    public Composite(string name) : base(name)
    {
    }

    public override void Add(Component c)
    {
        childrens.Add(c);
    }

    public override void Remove(Component c)
    {
        childrens.Remove(c);
    }

    public override void Display()
    {
        Console.WriteLine(_name);
        foreach (var component in childrens)
        {
            component.Display();
        }
    }
}