using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedTree
{
    public class DoubleTree
    {
        private string _name;
        private TreeNode _head = new TreeNode("HeadNode");
        private TreeNode _tail = new TreeNode("TailNode");

        public DoubleTree(string name)
        {
            // Constructor for Tree With Name Given
            this._name = name;

            // Connect Head & Tail
            this._head.SetNextNode(_tail);
            this._tail.SetPrevNode(_head);
        }

        public DoubleTree AddNodeHead (TreeNode newNode)
        {

            return this;
        }

        public DoubleTree AddNodeTail (TreeNode newNode)
        {
            // Add New Node to Tail of this graph


            
            return this;
        }


    }
}
