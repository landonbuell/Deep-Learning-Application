using System;
using System.Collections.Generic;
using System.Text;

namespace Tensor
{
    class Tensor
    {

        public string Name { get; protected set; }

        protected readonly TensorNode _head;

        public Tensor (float[] array1D)
        {
            // Construct Tensor from 1D array
            TensorNode[] headNode = new TensorNode[array1D.Length];
            for (int i = 0; i < array1D.Length; i++)
            {
                headNode[i] = new TensorNode(array1D[i]);
            }
            _head = new TensorNode(headNode,"HeadNode");
        }

        public Tensor(float scaler)
        {
            // Construct Tensor from 1D array           
            _head = new TensorNode(scaler, "HeadNode");
        }


        public int Rank
        {
            // Get Rank of this Tensor (assumed NON-jagged)
            get 
            {
                if (_head.IsLeaf == true)
                    return 0;
                else
                    return GetMaxDepth(_head, -1); 
            }
        }

        private int GetMaxDepth (TensorNode node, int depth)
        {
            // Get Rank of this Tensor (assumed NON-jagged)
            if (node.IsLeaf)
            {
                // Node is lead, only goes 1 deeper
                return depth + 1;
            }
            else
            {
                return GetMaxDepth(node.Next[0], depth + 1);
            }
        }

    }
}
