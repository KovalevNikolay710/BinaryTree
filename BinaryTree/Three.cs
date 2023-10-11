using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Three<T> where T: IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }
        public void Add(T data)
        {          
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        
        }
        public List<T> Preorder() 
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return Preorde(Root);
        }
        private List<T> Preorde(Node<T> node)
        {
            var list = new List<T>();
            if (node!=null)
            {
                list.Add(node.Data);
                if (node.Left!=null)
                {
                    list.AddRange(Preorde(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Preorde(node.Right));
                }
            }
            return list;
        }
        public List<T> Postorder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return Postorder(Root);
        }
        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }
                list.Add(node.Data);
            }
            return list;
        }
        public List<T> Inorder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return Inorder(Root);
        }
        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }
                list.Add(node.Data);
                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
                
            }
            return list;
        }
        public List<T> InWidth()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return InWidth(Root);
        }
        private List<T> InWidth(Node<T> node)
        {
            var list = new List<T>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                list.Add(node.Data);
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

            }
            return list;
        }
        public bool SearchInWidth(T target)
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty");
                return false;
            }
            if (target is int) return SearcInWidth(Root, target);
            else
            {
                Console.WriteLine("x must be int"); 
                return false;
            }
        }
        private bool SearcInWidth(Node<T> node, T tar)
        {
            var list = new List<T>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (node.Data.Equals(tar))
                {
                    return true;
                }
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

            }
            return false;
        }
    }
}
