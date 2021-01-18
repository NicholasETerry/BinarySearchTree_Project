using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newSearch = new BinarySearchTree();
            Node node1 = new Node(100);
            Node node2 = new Node(20);
            Node node3 = new Node(200);
            Node node4 = new Node(19);
            Node node5 = new Node(3);
            Node node6 = new Node(50);

            newSearch.Add(node1);
            newSearch.Add(node2);
            newSearch.Add(node3);
            newSearch.Add(node4);
            newSearch.Add(node5);
            newSearch.Add(node6);
            Console.WriteLine("All items added");
            newSearch.Search(700);
            newSearch.Search(3);

            Console.ReadLine();
        }
    }
}
