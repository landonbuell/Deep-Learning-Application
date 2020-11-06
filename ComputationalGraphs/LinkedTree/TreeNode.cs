using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LinkedTree
{
    public class TreeNode
    {
        // Tree Node Makes up elements of Linked Tree
        private List<TreeNode> _next = new List<TreeNode>();
        private List<TreeNode> _prev = new List<TreeNode>();
        private string _data;

        public TreeNode(string dataStr = " ")
        {
            // Constructor for TreeNode Given No Arguments
            this._data = dataStr;
        }

        public string Data
        { 
            get { return _data; } 
            set { _data = value; } 
        }

        public List<TreeNode> NextNodesList
        {
            get { return _next; }
            set { _next = value; }
        }

        public List<TreeNode> PrevNodesList
        {
            get { return _prev; }
            set { _prev = value; }
        }

        public void SetNextNode (TreeNode newNode)
        {
            // Set Next Node as NewNode, Erasing All other Connections
            _next = new List<TreeNode> { newNode };
        }

        public void SetPrevNode (TreeNode newNode)
        {
            // Set Prev Node as NewNode, Erasing All other Connections
            _prev = new List<TreeNode> { newNode };
        }

        public void AddNext (TreeNode newNode)
        {
            // Add Add Node After this Node
            _next.Add(newNode);
            

        }

        public void InsertNext(TreeNode newNode)
        {
            // Insert newNode after this node, 
            // Pushes all previous nodes down one level


        }

        public void ReplaceNext (TreeNode newNode)
        {

        }


       
        public TreeNode RemoveAllConnections()
        {
            // Reset this node to contain Only Data
            NextNodesList = new List<TreeNode>();
            PrevNodesList = new List<TreeNode>();
            return this;
        }

    }

    public class NodeData
    {
        // TreeData is Information Contained within Each Node;


        public NodeData(string data)
        {
            // Constructor for TreeData Given String Datatype
            this.Data = data;
        }

        public string Data { get; set; }

    }
}
