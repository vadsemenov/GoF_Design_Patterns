using System;

namespace FactoryMethod
{
    public class Car: ITransport
    {
        public void Move()
        {
            Console.WriteLine("Delivery by car");
        }
    }
}