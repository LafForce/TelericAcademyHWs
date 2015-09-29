using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TestATree
    {
        static void Main()
        {
            
            Tree<int> tree = new Tree<int>(20);

            for (int i = 0; i < 40; i++)
            {
                if (i == 20) i++;
                tree.Add(i);
            }

            Console.WriteLine(tree);
            Console.WriteLine(tree.HasValue(5));
            Console.WriteLine(tree.HasValue(15));

            tree.Add(15);
            Console.WriteLine(tree);
            Console.WriteLine(tree.HasValue(15));

        }
    }
    class Node<T>
        where T : IComparable
    {
        public T Value;
        public Node<T> Parent;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T initial)
        {
            this.Value = initial;
            this.Left = null;
            this.Right = null;
            this.Parent = null;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }

    class Tree<T>
        where T : IComparable
    {
        public Node<T> Root;

        public Tree(T initial)
        {
            this.Root = new Node<T>(initial);
        }

        public void Add(T value)
        {
            AddRecursive(ref this.Root, ref this.Root, value);
        }

        private void AddRecursive(ref Node<T> N, ref Node<T> parent, T value)
        {
            if (N == null)
            {
                Node<T> newNode = new Node<T>(value);
                newNode.Parent = parent;
                N = newNode;
                return;
            }

            if (value.CompareTo(N.Value) < 0)
            {
                AddRecursive(ref N.Left, ref N, value);
                return;
            }

            if (value.CompareTo(N.Value) >= 0)
            {
                AddRecursive(ref N.Right, ref N, value);
                return;
            }
        }

        public bool HasValue(T N)
        {
            return Find(this.Root, N);
        }

        private bool Find(Node<T> node, T N)
        {
            if (node == null) return false;
            if (node.Value.Equals(N)) return true;

            if (N.CompareTo(node.Value) < 0) return Find(node.Left, N);
            if (N.CompareTo(node.Value) >= 0) return Find(node.Right, N);

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            Print(null, ref result);

            return result.ToString().Trim().Trim(',');
        }

        private void Print(Node<T> N, ref StringBuilder result)
        {
            if (N == null)
            {
                N = this.Root;
            }

            if (N.Left != null)
            {
                Print(N.Left, ref result);
                result.Append(N + ", ");
            }
            else
            {
                result.Append(N + ", ");
            }

            if (N.Right != null)
            {
                Print(N.Right, ref result);
            }
        }
    }
}