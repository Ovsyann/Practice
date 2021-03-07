using BinarySearchTreeTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeTests.tests
{
    public abstract class IterativeTreeTests<TItem> : BinaryTreeTests<TItem> where TItem : IComparable<TItem>
    {
        public override BinarySearchTree<TItem> CreateTree(IEnumerable<TItem> collection)
        {
            return new IterativeTree<TItem>(collection);
        }

        public override BinarySearchTree<TItem> CreateTree(IEnumerable<TItem> collection, IComparer<TItem> comparer)
        {
            return new IterativeTree<TItem>(collection, comparer);
        }

        public override BinarySearchTree<TItem> CreateTree(IComparer<TItem> comparer)
        {
            return new IterativeTree<TItem>(comparer);
        }
    }
}
