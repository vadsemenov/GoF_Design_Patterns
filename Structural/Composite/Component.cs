namespace Composite;

public abstract class Component 
{
    protected string _name;

    public Component(string name)
    {
        _name = name;
    }

    public abstract void Add(Component c);


    public abstract void Remove(Component c);

    public abstract void Display();
}