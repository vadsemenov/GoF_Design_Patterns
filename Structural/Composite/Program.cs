namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Component compositTreeRoot = new Composite("-Root");
            Component leaf = new Composite("--Leaf");
            Component anotherLeaf = new Composite("--Another Leaf");
            Composite subtree1 = new Composite("--Subtree1");
            Component subtree1Leaf = new Composite("---subtree1 leaf");
            Composite subtree2 = new Composite("--Subtree2");
            Component subtree2Leaf = new Composite("---subtree2 leaf");

            compositTreeRoot.Add(leaf);
            compositTreeRoot.Add(anotherLeaf);
            compositTreeRoot.Add(subtree1);
            compositTreeRoot.Add(subtree2);
            subtree1.Add(subtree1Leaf);
            subtree2.Add(subtree2Leaf);

            compositTreeRoot.Display();

        }
    }
}