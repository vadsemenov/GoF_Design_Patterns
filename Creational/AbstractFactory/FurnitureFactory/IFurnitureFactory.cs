namespace AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }
}