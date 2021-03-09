using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTreeTask
{
    public class TreeEnumerator<TData> : IEnumerator<TData> where TData : IComparable<TData>
    {
        private BinarySearchTree<TData> tree;
        private Node<TData> head;
        private Stack<Node<TData>> stack;
        private bool isStart;

        public TreeEnumerator(BinarySearchTree<TData> tree)
        {
            stack = new Stack<Node<TData>>();
            this.tree = tree;
            head = this.tree.Root;
            isStart = true;
        }

        public TData Current => head.data;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            tree = null;
            head = null;
            stack.Clear();
            stack = null;
        }

        public bool MoveNext()
        {
            while (stack.Count != 0 || head != null)
            {
                if (stack.Count != 0 && head == null)
                {
                    head = stack.Pop();
                    return true;
                }
                if(stack.Count != 0 || !isStart)
                {
                    if (head.leftChild != null)
                    {
                        head = head.leftChild;
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
                    head = head.rightChild;
                }

                isStart = false;
            }

            return false;
        }

        public void Reset()
        {
            stack.Clear();
            head = tree.Root;
        }
    }
}
