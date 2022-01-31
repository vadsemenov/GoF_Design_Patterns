using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory victorianFactory = new VictorianFactory();
            IFurnitureFactory classicFactory = new ClassicFactory();
            IFurnitureFactory customFactory = new CustomFactory();

            Client client1 = new Client(victorianFactory, "Клиент1");
            Client client2 = new Client(classicFactory, "Клиент2");
            Client client3 = new Client(customFactory, "Клиент3");

            client1.Info();
            client2.Info();
            client3.Info();
        }
    }
}