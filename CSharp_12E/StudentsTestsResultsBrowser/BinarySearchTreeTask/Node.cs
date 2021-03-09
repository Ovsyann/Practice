using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class Node<TData> : IComparable<TData>, IEquatable<Node<TData>> where TData : IComparable<TData>
    {
        [XmlElement(nameof(data))]
        public TData data;
        [XmlElement(nameof(leftChild))]
        public Node<TData> leftChild;
        [XmlElement(nameof(rightChild))]
        public Node<TData> rightChild;

        public Node(TData data)
        {
            this.data = data;
        }

        public Node()
        {

        }

        public Node(Node<TData> node)
        {
            data = node.data;
            leftChild = node.leftChild;
            rightChild = node.rightChild;
        }

        public int CompareTo(TData other)
        {
            return data.CompareTo(other);
        }

        public bool Equals(Node<TData> other)
        {
            if(other == null)
            {
                return false;
            }

            if (leftChild != null && rightChild == null)
            {
                return data.Equals(other.data) && 
                    leftChild.Equals(other.leftChild);
            }

            if(rightChild != null && leftChild == null)
            {
                return data.Equals(other.data) && 
                    rightChild.Equals(other.rightChild);
            }

            if(rightChild != null && leftChild != null)
            {
                return data.Equals(other.data) && 
                    rightChild.Equals(other.rightChild) && 
                    leftChild.Equals(other.leftChild);
            }

            return data.Equals(other.data);
        }
    }
}
