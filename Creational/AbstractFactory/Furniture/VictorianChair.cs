using System;

namespace AbstractFactory
{
    public class VictorianChair: IChair
    {
        public void ChairType()
        {
            Console.WriteLine("Victorian Chair");
        }
    }
}