using System;

namespace AbstractFactory
{
    public class Client
    {
        private string _clientName;
        private IChair _chair;
        private ISofa _sofa;
        private ITable _table;

        public Client(IFurnitureFactory factory, string clientName )
        {
            _clientName = clientName;
            _chair = factory.CreateChair();
            _sofa = factory.CreateSofa();
            _table = factory.CreateTable();
        }

    
        public void Info()
        {
            Console.WriteLine($"Набор {_clientName}:");
            _chair.ChairType();
            _sofa.SofaType();
            _table.TableType();
        }
    }
}