using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent tree = new ChristmasComponent();
            tree = new LightDecorator(tree);
            tree = new MusicDecorator(tree);

            Celebrate(tree);

            Console.ReadKey();
        }

        static void Celebrate(IComponent component)
        {
            component.Execute();
        }
    }
}
