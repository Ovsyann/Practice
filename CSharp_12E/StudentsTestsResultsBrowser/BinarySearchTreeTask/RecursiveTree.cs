using System;
using System.Collections.Generic;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class RecursiveTree<TData> : BinarySearchTree<TData> where TData : IComparable<TData>
    {
        public RecursiveTree() 
        { 

        }

        public RecursiveTree(IComparer<TData> comparer) : base(comparer)
        {

        }

        public RecursiveTree(IEnumerable<TData> collection) : base(collection)
        {

        }

        public RecursiveTree(IEnumerable<TData> collection, IComparer<TData> comparer) : base(collection, comparer)
        {

        }

        public override void Add(TData data)
        {
            Node<TData> nodeToAdd = new Node<TData>(data);

            if (IsEmpty)
            {
                Root = nodeToAdd;
                return;
            }

            Add(Root, nodeToAdd);
        }

        private void Add(Node<TData> current, Node<TData> nodeToAdd)
        {
            if (Compare(nodeToAdd.data, current) > 0)
            {
                if (current.rightChild != null)
                {
                    Add(current.rightChild, nodeToAdd);
                }
                else
                {
                    current.rightChild = nodeToAdd;
                }
            }
            else
            {
                if (current.leftChild != null)
                {
                    Add(current.leftChild, nodeToAdd);
                }
                else
                {
                    current.leftChild = nodeToAdd;
                }
            }
        }

        public override Node<TData> Find(TData data)
        {
            Node<TData> parent;
            return Find(data, Root, out parent);
        }

        public override IEnumerator<TData> GetEnumerator()
        {
            return BypassInOrder(Root).GetEnumerator();
        }

        public override IEnumerator<TData> GetReversedEnumerator()
        {
            return BypassReversOrder(Root).GetEnumerator();
        }

        public override Node<TData> GetLeft()
        {
            return GetLeft(Root);
        }

        public override Node<TData> GetRight()
        {
            return GetRight(Root);
        }

        protected override Node<TData> Find(TData data, out Node<TData> parent)
        {
            return Find(data, Root, out parent);
        }

        private Node<TData> Find(TData data, Node<TData> node, out Node<TData> parent)
        {
            Node<TData> requiredNode;
            if (Compare(data, node) < 0)
            {
                requiredNode = Find(data, node.leftChild, out parent);

                parent = AssignParent(node, parent);
            }
            else if (Compare(data, node) > 0)
            {
                requiredNode = Find(data, node.rightChild, out parent);

                parent = AssignParent(node, parent);
            }
            else
            {
                requiredNode = node;
                parent = null;
            }

            return requiredNode;
        }

        private static Node<TData> AssignParent(Node<TData> node, Node<TData> parent)
        {
            if (parent == null)
            {
                parent = node;
            }

            return parent;
        }

        private IEnumerable<TData> BypassInOrder(Node<TData> node)
        {
            if (node == null)
            {
                yield break;
            }

            foreach (TData item in BypassInOrder(node.leftChild))
            {
                yield return item;
            }

            yield return node.data;

            foreach (TData item in BypassInOrder(node.rightChild))
            {
                yield return item;
            }
        }

        private IEnumerable<TData> BypassReversOrder(Node<TData> node)
        {
            if (node != null)
            {
                foreach (TData item in BypassReversOrder(node.rightChild))
                {
                    yield return item;
                }

                yield return node.data;

                foreach (TData item in BypassReversOrder(node.leftChild))
                {
                    yield return item;
                }
            }
        }

        public override Node<TData> GetLeft(Node<TData> node)
        {
            if(node.leftChild != null)
            {
                return GetLeft(node.leftChild);
            }

            return node;
        }

        public override Node<TData> GetRight(Node<TData> node)
        {
            if (node.rightChild != null)
            {
                return GetRight(node.rightChild);
            }

            return node;
        }
    }
}
