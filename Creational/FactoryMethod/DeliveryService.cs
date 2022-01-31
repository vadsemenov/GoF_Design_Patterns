namespace FactoryMethod
{
    public class DeliveryService
    {
        public void Delivery(ITransportFactory transportFactory)
        {
            ITransport transport = transportFactory.Create();
            transport.Move();
        }
    }
}