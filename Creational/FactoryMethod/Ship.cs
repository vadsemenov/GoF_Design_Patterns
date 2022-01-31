using System;

namespace FactoryMethod
{
    public class Ship: ITransport
    {
        public void Move()
        {
            Console.WriteLine("Delivery by ship");
        }
    }
}