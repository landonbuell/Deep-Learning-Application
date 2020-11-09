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
                // Constructor for Computational Graph (Empty)
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
            }
            
            public ComputationalGraph(BaseLayer existingLayer)
            {
                // Constructor for Computational Graph (One Node)
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
                AddTailNode(existingLayer);
            }

            public ComputationalGraph(List<BaseLayer> existingLayers)
            {
                // Constructor for Computational Graph (List of Nodes)
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
                for (int i = 0; i < existingLayers.Count; i++)
                    AddTailNode(existingLayers[i]);
            }

            public ComputationalGraph(ComputationalGraph exisitngGraph)
            {
                // Constructor for Computational Graph (Wxisitng Graph)
                _headNode.NextLayer = _tailNode;
                _tailNode.PrevLayer = _headNode;
                // Convert to layer list, add in order
                List<BaseLayer> existingLayers = exisitngGraph.GetGraphList;
                for (int i = 0; i < existingLayers.Count; i++)
                    AddTailNode(existingLayers[i]);
            }

            public BaseLayer GetHead { get { return _headNode; } }

            public BaseLayer GetTail { get { return _tailNode; } }

            public void AddTailNode (BaseLayer newLayer)
            {
                // Add newNode to end of Compuational Graph
                BaseLayer oldTail = _tailNode.PrevLayer;
                oldTail.NextLayer = newLayer;
                _tailNode.PrevLayer = newLayer;
                newLayer.PrevLayer = oldTail;
                newLayer.NextLayer = _tailNode;

                // Format the Layer to match other layers
                SetLayerCounter(newLayer);
            }

            public void AddHeadNode (BaseLayer newLayer)
            {
                // Add newNode to top of Computational Graph
                BaseLayer oldHead = _headNode.NextLayer;
                oldHead.PrevLayer = newLayer;
                _headNode.NextLayer = newLayer;
                newLayer.NextLayer = oldHead;
                newLayer.PrevLayer = _headNode;

                // Format the Layer to Match other Layers
                SetLayerCounter(newLayer);
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
