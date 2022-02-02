using System;

namespace Decorator
{
    public class LightDecorator : BaseDecorator
    {
        public LightDecorator(IComponent component) : base(component)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Light off");
            base.Execute();
            Console.WriteLine("Light on!");
        }
    }
}