using Visitor.Item;

namespace Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var itemCollection = new List<Item.Item>()
            {
                new SimpleItem(10),
                new ComplexItem(11, 12),
                new SimpleItem(20),
                new ComplexItem(21, 22),
                new SimpleItem(30)
            };

            var visitor = new ConsoleVisitor();

            foreach (var item in itemCollection)
            {
                item.Display(visitor);
            }
        }
    }
}

