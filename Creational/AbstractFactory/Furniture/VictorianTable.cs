using System;

namespace AbstractFactory
{
    public class VictorianTable: ITable
    {
        public void TableType()
        {
            Console.WriteLine("Victorian Table");
        }
    }
}