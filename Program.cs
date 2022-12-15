using System;

namespace DataStructureUsingBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in binary search tree");
            /*BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
            */

            BinarySearchTree<int> binarySearchTree1 = new BinarySearchTree<int>(56);
            binarySearchTree1.Insert(30);
            binarySearchTree1.Insert(70);
            binarySearchTree1.Insert(22);
            binarySearchTree1.Insert(40);
            binarySearchTree1.Insert(60);
            binarySearchTree1.Insert(95);
            binarySearchTree1.Insert(11);
            binarySearchTree1.Insert(65);
            binarySearchTree1.Insert(3);
            binarySearchTree1.Insert(16);
            binarySearchTree1.Insert(63);
            binarySearchTree1.Insert(67);
            binarySearchTree1.Display();
            binarySearchTree1.getSize();

        }
    }
}
