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

        public void PreorderTraversal()
        {
            if (Root == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(Root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                Console.Write(current.Data + " ");

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        public void PostorderTraversal()
        {
            if (Root == null)
            {
                return;
            }

            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();

            stack1.Push(Root);

            while (stack1.Count > 0)
            {
                Node current = stack1.Pop();
                stack2.Push(current);

                if (current.Left != null)
                {
                    stack1.Push(current.Left);
                }

                if (current.Right != null)
                {
                    stack1.Push(current.Right);
                }
            }

            while (stack2.Count > 0)
            {
                Node current = stack2.Pop();
                Console.Write(current.Data + " ");
            }
        }
    }
}
