namespace DND12_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Add(33);
            binarySearchTree.Add(47);
            binarySearchTree.Add(29);
            binarySearchTree.Add(12);
            binarySearchTree.Add(29);

            binarySearchTree.Search(12);
            binarySearchTree.Search(25);
        }
    }
}