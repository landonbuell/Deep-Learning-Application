using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedGraph
{
    public class GraphNode
    {
        public string Name { get; protected set; }

        public int Index { get; protected set; }

        protected List<GraphNode> NextNodes { get; set; }

        protected List<GraphNode> PrevNodes { get; set; }

        public GraphNode(string name, int index,
            List<GraphNode> nextNodes, List<GraphNode> prevNodes)
        {
            // Constructor for Graph Node
            Name = name;
            Index = index;

            NextNodes = nextNodes;
            PrevNodes = prevNodes;
        }


    }

}
