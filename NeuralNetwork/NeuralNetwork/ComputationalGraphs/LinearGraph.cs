using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Layers;
using NeuralNetwork.Layers.Utilities;

namespace NeuralNetwork.ComputationalGraphs
{
    public class LinearGraph : BaseGraph
    {
        // Linear Graph is a Double Linked List w/ Sentinel Nodes
        // Each node has exactly 1 previous and 1 next node
        private PointerLayer _headNode = new PointerLayer("HeadNode");
        private PointerLayer _tailNode = new PointerLayer("TailNode");

        #region LinearGraphConstructors

        public LinearGraph() : base()
        {
            // Constructor for Computational Graph (Empty)
            _headNode.NextLayer = _tailNode;
            _tailNode.PrevLayer = _headNode;
        }
            
        public LinearGraph(NetworkLayer existingLayer)
        {
            // Constructor for Computational Graph (One Node)
            _headNode.NextLayer = _tailNode;
            _tailNode.PrevLayer = _headNode;
            // Add Single node in the middle
            AddTailNode(existingLayer);
        }

        public LinearGraph(List<NetworkLayer> existingLayers)
        {
            // Constructor for Computational Graph (List of Nodes)
            _headNode.NextLayer = _tailNode;
            _tailNode.PrevLayer = _headNode;
            // Add Each node (in order) to the tail
            for (int i = 0; i < existingLayers.Count; i++)
                AddTailNode(existingLayers[i]);
        }

        public LinearGraph(LinearGraph exisitngGraph)
        {
            // Constructor for Computational Graph (Exisitng Graph)
            _headNode.NextLayer = exisitngGraph._headNode.NextLayer;
            _headNode.NextLayer.PrevLayer = _headNode;

            _tailNode.PrevLayer = exisitngGraph._tailNode.PrevLayer;
            _tailNode.PrevLayer.NextLayer = _tailNode;
        }

        #endregion

        #region LinearGraphProperties

        public NetworkLayer GetHead
        {
            get { return _headNode; }
            private set { _headNode = (PointerLayer)value; }
        }

        public NetworkLayer GetTail
        {
            get { return _tailNode; }
            private set { _tailNode = (PointerLayer)value; }
        }

        #endregion

        public void AddTailNode (NetworkLayer newLayer)
        {
            // Add newNode to end of Compuational Graph
            NetworkLayer oldTail = _tailNode.PrevLayer;
            oldTail.NextLayer = newLayer;
            _tailNode.PrevLayer = newLayer;
            newLayer.PrevLayer = oldTail;
            newLayer.NextLayer = _tailNode;

            // Format the Layer to match other layers
            SetLayerCounter(newLayer);
        }

        public void AddHeadNode (NetworkLayer newLayer)
        {
            // Add newNode to top of Computational Graph
            NetworkLayer oldHead = _headNode.NextLayer;
            oldHead.PrevLayer = newLayer;
            _headNode.NextLayer = newLayer;
            newLayer.NextLayer = oldHead;
            newLayer.PrevLayer = _headNode;

            // Format the Layer to Match other Layers
            SetLayerCounter(newLayer);
        }

        public NetworkLayer RemoveAtIndex (int index = -1)
        {
            // Remove node at Graph Index
            NetworkLayer currentLayer = _headNode.NextLayer;
            for (int i = 0; i < index; i++)
                currentLayer = currentLayer.NextLayer;
            NetworkLayer oldPrev = currentLayer.PrevLayer;
            NetworkLayer oldNext = currentLayer.NextLayer;
            oldPrev.NextLayer = oldNext;
            oldNext.PrevLayer = oldPrev;
            return currentLayer;                
        }

        private void SetLayerCounter(NetworkLayer currentLayer)
        {
            // Set Index on current Layer   
            try
            {
                int prevLayerIndex = currentLayer.PrevLayer.LayerIndex;
                currentLayer.LayerIndex = prevLayerIndex + 1;
            }
            catch
            {
                currentLayer.LayerIndex = 0;
            }
        }

        public List<NetworkLayer> GetGraphList
        {
            get
            {
                // Get This Graph as a List of Layers
                List<NetworkLayer> graphList = new List<NetworkLayer>();
                NetworkLayer currentLayer = _headNode.NextLayer;
                while (currentLayer != _tailNode)
                {
                    graphList.Add(currentLayer);
                    currentLayer = currentLayer.NextLayer;
                }
                return graphList;
            }
        }
    }
}
