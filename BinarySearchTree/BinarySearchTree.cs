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
                        currentNode.rightChildNode = new Node(toAdd.nodeValue);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.rightChildNode; 
                    }
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
                        currentNode = currentNode.leftChildNode;
                    }
                }
            }
        }
        public void Search(int valueToSearch)
        {
            Node currentNode = rootNode;
            while (true)
            {
                if (valueToSearch == currentNode.nodeValue)
                {
                    ItemFound();
                    break;
                }
                else if (valueToSearch > currentNode.nodeValue)
                {
                    if (currentNode.rightChildNode == null)
                    {
                        ItemNotFound();
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.rightChildNode;
                    }
                }
                else if (valueToSearch < currentNode.nodeValue)
                {
                    if (currentNode.leftChildNode == null)
                    {
                        ItemNotFound();
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.leftChildNode;
                    }
                }

            }

        }
        public void ItemFound()
        {
            Console.WriteLine("Item found");
            Console.ReadLine();
        }
        public void ItemNotFound()
        {
            Console.WriteLine("The item is not in the Tree");
            Console.ReadLine();
        }
    }
}
