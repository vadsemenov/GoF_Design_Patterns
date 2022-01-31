namespace FactoryMethod
{
    public class CarFactory: ITransportFactory
    {
        public ITransport Create()
        {
            return new Car();
        }
    }
}