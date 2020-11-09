using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Layers;
using NeuralNetwork.LayerUtilities;

namespace NeuralNetwork
{

    namespace DoubleLinkedGraphs
    {

        public class ComputationalGraph
        {
            private PointerLayer _headNode = new PointerLayer("HeadNode");
            private PointerLayer _tailNode = new PointerLayer("TailNode");

            public ComputationalGraph()
            {
                // Constructor for Computational Graph with no Args
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
            }
            
            public BaseLayer GetHead { get { return _headNode; } }

            public BaseLayer GetTail { get { return _tailNode; } }

            public ComputationalGraph(BaseLayer newLayer)
            {
                // Constructor for Computational Graph with Exisitng Layer
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
                AddTailNode(newLayer);
            }

            public ComputationalGraph(ComputationalGraph newGraph)
            {
                // Constructor for Computational Graph with Exisitng Graph
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
            }

            public void AddTailNode (BaseLayer newNode)
            {
                // Add newNode to end of Compuational Graph
                BaseLayer oldTail = _tailNode.PrevLayer;
                oldTail.NextLayer = newNode;
                _tailNode.PrevLayer = newNode;
                newNode.PrevLayer = oldTail;
                newNode.NextLayer = _tailNode;
                SetLayerCounter(newNode);
            }

            public void AddHeadNode (BaseLayer newNode)
            {
                // Add newNode to top of Computational Graph
                BaseLayer oldHead = _headNode.NextLayer;
                oldHead.PrevLayer = newNode;
                _headNode.NextLayer = newNode;
                newNode.NextLayer = oldHead;
                newNode.PrevLayer = _headNode;
                SetLayerCounter(newNode);
            }

            public BaseLayer RemoveAtIndex (int index = -1)
            {
                // Remove node at Graph Index
                BaseLayer currentLayer = _headNode.NextLayer;
                for (int i = 0; i < index; i++)
                    currentLayer = currentLayer.NextLayer;
                BaseLayer oldPrev = currentLayer.PrevLayer;
                BaseLayer oldNext = currentLayer.NextLayer;
                oldPrev.NextLayer = oldNext;
                oldNext.PrevLayer = oldPrev;
                return currentLayer;                
            }

            private void SetLayerCounter(BaseLayer currentLayer)
            {
                // Set Index on current Layer   
                try
                {
                    int prevLayerIndex = currentLayer.PrevLayer._layerIndex;
                    currentLayer._layerIndex = prevLayerIndex + 1;
                }
                catch
                {
                    currentLayer._layerIndex = 0;
                }
            }

            public List<BaseLayer> GetGraphList
            {
                get
                {
                    // Get This Graph as a List
                    List<BaseLayer> graphList = new List<BaseLayer>();
                    BaseLayer currentLayer = _headNode.NextLayer;
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
}
