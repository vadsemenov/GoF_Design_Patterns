using System;

namespace Decorator
{
    public class MusicDecorator :BaseDecorator
    {
        public MusicDecorator(IComponent component) : base(component)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Music start");
            base.Execute();
            Console.WriteLine("Music stop");
        }
    }
}