namespace AbstractFactory
{
    public class CustomFactory: IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ClassicChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new ClassicTable();
        }
    }
}