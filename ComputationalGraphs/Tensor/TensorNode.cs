using System;
using System.Collections.Generic;
using System.Text;

namespace Tensor
{
    class TensorNode
    {
        internal TensorNode (object data, string name = "node")
        {
            // Constructor given data (if leaf)
            Data = data;
            IsLeaf = true;

            Next = null;
            Name = name;
        }
        internal TensorNode(TensorNode[] next, string name = "node")
        {
            // Constructor given set of children (not leaf)
            Data = null;
            IsLeaf = false;

            Next = next;
            Name = name;
        }

        public string Name { get; private set; }

        internal bool IsLeaf { get; set; }

        public TensorNode[] Next { get; set; }
    
        public object Data { get; set; }
    }
}