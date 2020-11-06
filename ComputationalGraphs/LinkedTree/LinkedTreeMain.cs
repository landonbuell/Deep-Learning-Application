using System;

namespace LinkedTree
{
    class LinkedTreeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computational Graph Test");

            DoubleTree GraphA = new DoubleTree("GraphA");

            GraphA.AddTailNode(new TreeNode("A1"));
            GraphA.AddTailNode(new TreeNode("A2"));

            GraphA.AddNodeHead(new TreeNode("A0"));

            Console.WriteLine("Finished Graph A");

        }
    }
}
