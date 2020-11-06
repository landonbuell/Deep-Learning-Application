using System;

namespace LinkedTree
{
    class LinkedTreeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computational Graph Test");

            DoubleTree GraphA = new DoubleTree("GraphA");

            GraphA.AddTail(new TreeNode("A1"));

            Console.WriteLine("Finished Graph A");

        }
    }
}
