using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            // Add new Node to the Head of this Graph
            List<TreeNode> prevHeads = _head.NextNodesList; 
            for (int i = 0; i < prevHeads.Count; i++)
            {
                // De-couple from Head Node
                prevHeads[i].RemovePrev(_head);
                prevHeads[i].AddPrev(newNode);
            }
            // Connect New Node to _head
            newNode.SetPrevNode(_head);
            _head.SetNextNode(newNode);
            return this;
        }

        public DoubleTree AddTailNode (TreeNode newNode)
        {
            // Add New Node to Tail of this graph
            List<TreeNode> prevTails = _tail.PrevNodesList;
            for (int i = 0; i < prevTails.Count; i++)
            {
                // De-couple from Tail Node
                prevTails[i].RemoveNext(_tail);
                prevTails[i].AddNext(newNode);
            }
            // Connect new node to _tail
            newNode.SetNextNode(_tail);
            _tail.SetPrevNode(newNode);      
            return this;
        }


    }
}
