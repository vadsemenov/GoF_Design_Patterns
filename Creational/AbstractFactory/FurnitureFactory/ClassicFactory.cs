namespace AbstractFactory
{
    public class ClassicFactory: IFurnitureFactory
    {
        public IChair CreateChair()
        {
           return new ClassicChair();
        }

        public ISofa CreateSofa()
        {
            return new ClassicSofa();
        }

        public ITable CreateTable()
        {
            return new ClassicTable();
        }
    }
}