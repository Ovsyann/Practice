using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class IterativeTree<TData> : BinarySearchTree<TData> where TData : IComparable<TData>
    {
        public IterativeTree()
        {

        }

        public IterativeTree(IComparer<TData> comparer) : base(comparer)
        {

        }

        public IterativeTree(IEnumerable<TData> collection) : base(collection)
        {

        }

        public IterativeTree(IEnumerable<TData> collection, IComparer<TData> comparer) : base(collection, comparer)
        {

        }

        public IterativeTree(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            
        }

        public override void Add(TData data)
        {
            if (IsEmpty)
            {
                Root = new Node<TData>(data);
                return;
            }

            Add(data, Root);
        }

        private void Add(TData data, Node<TData> node)
        {
            Node<TData> current = node;
            while (current != null)
            {
                if (Compare(data, current) > 0)
                {
                    if (current.rightChild != null)
                    {
                        current = current.rightChild;
                        continue;
                    }

                    current.rightChild = new Node<TData>(data);
                    return;
                }

                if (Compare(data, current) <= 0)
                {
                    if (current.leftChild != null)
                    {
                        current = current.leftChild;
                        continue;
                    }

                    current.leftChild = new Node<TData>(data);
                    return;
                }
            }
        }

        public override Node<TData> Find(TData data)
        {
            return Find(data, Root);
        }

        private Node<TData> Find(TData data, Node<TData> node)
        {
            if (IsEmpty)
            {
                return null;
            }

            Node<TData> tmp = node;
            while (tmp != null)
            {
                if (Compare(data, tmp) == 0)
                {
                    return tmp;
                }

                if (Compare(data, tmp) > 0)
                {
                    if (tmp.rightChild != null)
                    {
                        tmp = tmp.rightChild;
                        continue;
                    }

                    return null;
                }

                if (Compare(data, tmp) < 0)
                {
                    if (tmp.leftChild != null)
                    {
                        tmp = tmp.leftChild;
                        continue;
                    }

                    return null;
                }
            }

            return tmp;
        }

        public override IEnumerator<TData> GetEnumerator()
        {
            return BypassInOrder(Root);
        }

        public override IEnumerator<TData> GetReversedEnumerator()
        {
            return GetTreeEnumerator();
        }

        private TreeEnumerator<TData> GetTreeEnumerator()
        {
            return new TreeEnumerator<TData>(this);
        }

        private IEnumerator<TData> BypassInOrder(Node<TData> node)
        {
            Node<TData> head = node;
            Stack<Node<TData>> stack = new Stack<Node<TData>>();

            while(stack.Count!=0 || head != null)
            {
                if (stack.Count != 0)
                {
                    head = stack.Pop();
                    yield return head.data;

                    if(head.rightChild != null)
                    {
                        head = head.rightChild;
                    }
                    else
                    {
                        head = null;
                        continue;
                    }
                }

                while (head != null)
                {
                    stack.Push(head);
                    head = head.leftChild;
                }
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Root, IsEmpty, comparer);
        }

        public override Node<TData> GetLeft()
        {
            return GetLeft(Root);
        }

        public override Node<TData> GetLeft(Node<TData> node)
        {
            while (node.leftChild != null)
            {
                node = node.leftChild;
            }

            return node;
        }

        public override Node<TData> GetRight()
        {
            return GetRight(Root);
        }

        public override Node<TData> GetRight(Node<TData> node)
        {
            while (node.rightChild != null)
            {
                node = node.rightChild;
            }

            return node;
        }

        protected override Node<TData> Find(TData data, out Node<TData> parent)
        {
            return Find(data, Root, out parent);
        }

        private Node<TData> Find(TData data, Node<TData> node, out Node<TData> parent)
        {
            parent = null;
            if (IsEmpty)
            {
                return null;
            }

            Node<TData> tmp = node;
            while (tmp != null)
            {
                if (Compare(data, tmp) > 0)
                {
                    if (tmp.rightChild != null)
                    {
                        parent = tmp;
                        tmp = tmp.rightChild;
                        continue;
                    }

                    return null;
                }

                if (Compare(data, tmp) < 0)
                {
                    if (tmp.leftChild != null)
                    {
                        parent = tmp;
                        tmp = tmp.leftChild;
                        continue;
                    }

                    return null;
                }

                break;
            }

            return tmp;
        }
    }
}
