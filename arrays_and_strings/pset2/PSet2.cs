using System;
using System.Collections.Generic;

namespace pset2
{
    static public class PSet2
    {
        static public void Main()
        {
            List<string> tests = new();
            tests.Add("abcde");
            tests.Add("edc");
            tests.Add("gftr");

            Console.WriteLine("Testing Hash: ");
            TestHashExample(tests);

            Console.WriteLine("Testing BST: ");
            TestBSTExample();
        }

        static public void TestHashExample(List<string> Strs)
        {
            Console.WriteLine(Hash.IsPermutation(Strs[0], Strs[1]));
            Console.WriteLine(Hash.IsPermutation(Strs[0], Strs[2]));
        }

        static public void TestBSTExample()
        {
            BinaryTree binaryTree = new();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("Root: {0}", binaryTree.Root.Data);
            Console.WriteLine("Node 5: {0}", node.Data);
            Console.WriteLine("depth: {0}", depth);

            Console.WriteLine("PreOrder Traversal: ");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal: ");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal: ");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation: ");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
