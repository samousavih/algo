using System;
using System.Collections.Generic;

namespace tree_max_sum_not_connected_nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.right.left = new Node(4);
            root.right.right = new Node(5);
            root.left.left = new Node(1);
            Console.Write(getMaxSum(root));
        }
        public static int getMaxSum(Node node)
        {
            var map = new Dictionary<Node, int>();
            return getMaxSumChildren(node, map);
        }

        public static int getMaxSumChildren(Node node, Dictionary<Node, int> map)
        {
            if (node == null)
            {
                return 0;
            }
            if (map.ContainsKey(node))
            {
                return map[node];
            }
            

            var include = node.data + getSumGrandChildren(node,map);
            
            var exclude = getMaxSumChildren(node.left, map)+getMaxSumChildren(node.right,map);

            var max = Math.Max(include, exclude);
            map[node] = max;
            return max;
                    
        }

        public static int getSumGrandChildren(Node node, Dictionary<Node, int> map)
        {
            var sum = 0;
            if(node.left != null)
            {
                sum += getMaxSumChildren(node.left.left, map)+ getMaxSumChildren(node.left.right, map);
            }

            if (node.right != null)
            {
                sum += getMaxSumChildren(node.right.left, map) + getMaxSumChildren(node.right.right, map);
            }

            return sum;
        }


    }
}


public class Node
{
    public int data;
    public Node left, right;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
};