using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.Delivery(new CarFactory());
            deliveryService.Delivery(new ShipFactory());
        }
    }
}
