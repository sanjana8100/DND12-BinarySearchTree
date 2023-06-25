using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND12_BinarySearchTree
{
    internal class BinarySearchTree
    {
        private Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node current = Root;

            while (true)
            {
                if (data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public void Search(int data)
        {
            Node temp = Root;
            int counter = 0;
            while (temp != null)
            {
                if(data == temp.Data)
                {
                    Console.WriteLine($"{data} is present in BST. Data was found in {counter} interactions");
                    return;
                }
                else if(data < temp.Data)
                {
                    temp = temp.Left;
                    counter++;
                }
                else
                {
                    temp = temp.Right;
                    counter++;
                }
            }
            Console.WriteLine($"{data} is not present in BST");
            return;
        }

        public void InorderTraversal()
        {
            if (Root == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();
            Node current = Root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                current = stack.Pop();
                Console.Write(current.Data + " ");

                current = current.Right;
            }
        }

    }
}
