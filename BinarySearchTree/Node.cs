using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        // if value is less then Node, value is stored on the rightChildNode
        // if value is greater then Node, value is stored on the LeftChildNode
        public int nodeValue;
        public Node rightChildNode;
        public Node leftChildNode;

        public Node(int value)
        {
            nodeValue = value;
        }
    }
}
