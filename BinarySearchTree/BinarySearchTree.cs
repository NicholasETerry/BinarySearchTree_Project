using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node rootNode;
        public void Add(Node nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                AddToChild(nodeToAdd);
            }
        }
        public void AddToChild(Node toAdd)
        {
            Node currentNode = rootNode;
            while (true)
            {
                if (toAdd.nodeValue > currentNode.nodeValue)
                {
                    if (currentNode.rightChildNode == null)
                    {
                        currentNode.rightChildNode = toAdd;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.rightChildNode; //= new Node(toAdd.nodeValue);
                    }

                    break;
                }
                else if (toAdd.nodeValue < currentNode.nodeValue)
                {
                    if (currentNode.leftChildNode == null)
                    {
                        currentNode.leftChildNode = toAdd;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.leftChildNode; // = new Node(toAdd.nodeValue);
                    }

                    break;
                }
            }
        }
        public void Search(int valueToSearch)
        {

        }
    }
}
