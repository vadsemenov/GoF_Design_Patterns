namespace FactoryMethod
{
    public class ShipFactory: ITransportFactory
    {
        public ITransport Create()
        {
            return new Ship();
        }
    }
}