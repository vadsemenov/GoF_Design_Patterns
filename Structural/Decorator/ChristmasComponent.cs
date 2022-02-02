using System;

namespace Decorator
{
    public class ChristmasComponent :IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Happy new Year");
        }
    }
}