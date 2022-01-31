using System;

namespace AbstractFactory
{
    public class ClassicChair: IChair
    {
        public void ChairType()
        {
            Console.WriteLine("Classic Chair");
        }
    }
}