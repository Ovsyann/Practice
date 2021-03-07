using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BinarySearchTreeTask
{
    [Serializable]
    public abstract class BinarySearchTree<TData> : IEnumerable<TData>, ISerializable where TData : IComparable<TData>
    {
        protected Node<TData> root;

        [XmlElement(elementName:"Root")]
        public Node<TData> Root 
        {
            get
            {
                return root;
            }
            protected set
            {
                root = value;
            }
        }

        public bool IsEmpty
        {
            get 
            {
                return Root == null;
            }
        }

      protected IComparer<TData> comparer;

        public BinarySearchTree()
        {

        }

        public BinarySearchTree(IComparer<TData> comparer)
        {
            this.comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
            Root = null;
        }

        public BinarySearchTree(IEnumerable<TData> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            AddRange(collection);
        }

        public BinarySearchTree(IEnumerable<TData> collection, IComparer<TData> comparer)
        {
            if(comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            this.comparer = comparer;
            AddRange(collection);
        }

        public BinarySearchTree(SerializationInfo info, StreamingContext context)
        {
            Root = (Node<TData>)info.GetValue(nameof(Root), typeof(Node<TData>));
        }

        public abstract void Add(TData data);

        public virtual void AddRange(IEnumerable<TData> data)
        {
            foreach (TData dataItem in data)
            {
                Add(dataItem);
            }
        }

        public abstract Node<TData> Find(TData data);
        protected abstract Node<TData> Find(TData data, out Node<TData> parent);

        public abstract Node<TData> GetRight();
        public abstract Node<TData> GetLeft();
        public abstract Node<TData> GetRight(Node<TData> startNode);
        public abstract Node<TData> GetLeft(Node<TData> startNode);
        public Node<TData> GetMax(Node<TData> node) 
        {
            if (IsForward)
            {
                return GetRight(node);
            }
            else
            {
                return GetLeft(node);
            }
        }
        public Node<TData> GetMin(Node<TData> node)
        {
            if (IsForward)
            {
                return GetLeft(node);
            }
            else
            {
                return GetRight(node);
            }
        }

        public Node<TData> GetMax()
        {
            return GetMax(Root);
        }
        public Node<TData> GetMin()
        {
            return GetMin(Root);
        }

        protected bool IsForward
        {
            get
            {
                if (comparer is Comparer<TData>)
                {
                    return ((Comparer<TData>)comparer).isDirectOrder;
                }

                return true;
            }
        }

        protected int Compare(TData data, Node<TData> node)
        {
            if (comparer == null)
            {
                return data.CompareTo(node.data);
            }

            return comparer.Compare(data, node.data);

        }

        public bool Remove(TData data)
        {
            if (IsEmpty)
            {
                return false;
            }

            Node<TData> parent;
            Node<TData> node = Find(data, out parent);
            //1 case
            if (node.leftChild == null && node.rightChild == null)
            {
                RemoveNodeHavingNoChilds(node, parent);
                return true;
            }
            //2 case
            if (node.leftChild != null ^ node.rightChild != null)
            {
                RemoveNodeHavingOneChild(node, parent);
                return true;
            }
            //3 case
            if (node.leftChild != null && node.rightChild != null)
            {
                if(Compare(data,Root) == 0)
                {
                    parent = new Node<TData>();

                    parent.leftChild = Root;
                    RemoveNodeHavingBothChilds(node, parent);
                    Root = parent.leftChild;

                    parent = null;
                    return true;
                }

                RemoveNodeHavingBothChilds(node, parent);
                return true;
            }

            return false;
        }

        private void RemoveNodeHavingNoChilds(Node<TData> nodeToRemove, Node<TData> parent)
        {
            Replace(nodeToRemove, parent, null);
        }

        private void RemoveNodeHavingOneChild(Node<TData> nodeToRemove, Node<TData> parent)
        {
            if (nodeToRemove.leftChild != null)
            {
                Replace(nodeToRemove, parent, nodeToRemove.leftChild);
            }
            if (nodeToRemove.rightChild != null)
            {
                Replace(nodeToRemove, parent, nodeToRemove.rightChild);
            }
        }

        private void RemoveNodeHavingBothChilds(Node<TData> nodeToRemove, Node<TData> parent)
        {
            Node<TData> min;
            if (IsForward) 
            {
                min = GetMin(nodeToRemove.rightChild); 
            }
            else
            {
                min = GetMin(nodeToRemove.leftChild);
            }

            Node<TData> parentOfMin;
            Find(min.data, out parentOfMin);

            //если min является дочерним для удаляемого, то нужно просто передвинуть его на место удаляемого
            if (Compare(nodeToRemove.rightChild.data, min) == 0)
            {
                Replace(nodeToRemove, parent, min);
                min.leftChild = nodeToRemove.leftChild;
                return;
            }
            if (Compare(nodeToRemove.leftChild.data, min) == 0)
            {
                Replace(nodeToRemove, parent, min);
                min.rightChild = nodeToRemove.rightChild;
                return;
            }

            //если у min есть правый дочерний, то нужно перепривязать его к соответствующему у родителя min'а
            if (IsForward && min.rightChild != null)
            {
                Replace(min, parentOfMin, min.rightChild);
            }
            //если у min есть левый дочерний, то нужно перепривязать его к соответствующему у родителя min'а
            if (!IsForward && min.leftChild != null)
            {
                Replace(min, parentOfMin, min.leftChild);
            }
            else
            {
                //дать null родителю минимального в соответствующий слот, если у min нет дочернего
                Replace(min, parentOfMin, null);
            }

            min.rightChild = nodeToRemove.rightChild;
            min.leftChild = nodeToRemove.leftChild;
            Replace(nodeToRemove, parent, min);
        }

        private void Replace(Node<TData> nodeToReplace, Node<TData> parent, Node<TData> node)
        {
            if (parent.rightChild != null && Compare(nodeToReplace.data, parent.rightChild) == 0)
            {
                parent.rightChild = node;
            }
            if (parent.leftChild != null && Compare(nodeToReplace.data, parent.leftChild) == 0)
            {
                parent.leftChild = node;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
                return GetEnumerator();
        }

        public abstract IEnumerator<TData> GetEnumerator();
        public abstract IEnumerator<TData> GetReversedEnumerator();

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Root), Root);
        }
    }
}
