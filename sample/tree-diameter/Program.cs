using System;
using System.Collections.Generic;

namespace tree_diameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);
            root.right.right = newNode(6);

            Console.WriteLine("Diameter is " + diameter(root));
        }
        static int diameter(Node root)
        {
            var map = new Dictionary<Node, int>();
            return calcDiameter(root, map);
        }
        static int calcDiameter(Node node, Dictionary<Node,int> map)
        {
            if(node == null)
            {
                return 0;
            }
         
            var include = depth(node.left, map) + depth(node.right,map) + 1;
            var exclude = Math.Max(calcDiameter(node.left, map), calcDiameter(node.right, map));
            return Math.Max(include, exclude);
        }
        static int depth(Node node, Dictionary<Node, int> map)
        {
            if(node == null)
            {
                return 0;
            }
            if (map.ContainsKey(node)){
                return map[node];
            }
            var d = Math.Max(depth(node.left, map), depth(node.right, map)) + 1;
            map[node] = d;
            return d;
        }
        static Node newNode(int data)
        {
            Node node = new Node();
            node.data = data;
            node.left = null;
            node.right = null;

            return (node);
        }
    }
    class Node
    {
        public int data;
        public Node left, right;
    }

}
