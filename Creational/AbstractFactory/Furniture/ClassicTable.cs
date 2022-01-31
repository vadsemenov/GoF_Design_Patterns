using System;

namespace AbstractFactory
{
    public class ClassicTable: ITable
    {
        public void TableType()
        {
            Console.WriteLine("Classic Table");

        }
    }
}