using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Nodes__In_Pairs_leetCode
{
    class Program
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node(int data)
            {
                val = data;
                next = null;
            }
        }

        public class LinkedList
        {
            Node root;

            public LinkedList()
            {
                root = null;
            }

            public void insertNode(int data)
            {
                Node newNode = new Node(data);
                if(this.root !=null)
                {
                    newNode.next = root;
                }
                this.root = newNode;
            }

            public Node returnNode()
            {
                return root;
            }

            public void showList(Node root)
            {
                Node temp = root;
                while(temp !=null)
                {
                    Console.Write(temp.val + " ");
                    temp = temp.next;
                }
            }
            /////Swap Node In pairs/////////
            public Node SwapNodeInPairs(Node root)
            {
                if (root == null || root.next == null) return root;


                Node result = new Node(0);
                Node current = result;
                result.next = root;

                while (current.next != null && current.next.next != null)
                {
                    Node first = current.next;
                    Node second = current.next.next;

                    first.next = second.next;
                    current.next = second;
                    second.next = first;
                    current = first;
                }
                return result.next;
            }

            
            ////////////////////////////////
        }

        static void Main(string[] args)
        {
            LinkedList ls = new LinkedList();
            ls.insertNode(1);
            ls.insertNode(2);
            ls.insertNode(3);
            //ls.insertNode(4);
            //ls.insertNode(5);
            //ls.insertNode(6);

            Node returnNode=ls.returnNode();
            
            ls.showList(returnNode);
            Console.WriteLine("");
            Node result=ls.SwapNodeInPairs(returnNode);
            ls.showList(result);
            Console.ReadLine();
        }
    }
}
