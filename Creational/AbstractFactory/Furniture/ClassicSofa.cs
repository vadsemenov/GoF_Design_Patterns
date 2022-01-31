using System;

namespace AbstractFactory
{
    public class ClassicSofa: ISofa
    {
        public void SofaType()
        {
            Console.WriteLine("Classic Sofa");
        }
    }
}