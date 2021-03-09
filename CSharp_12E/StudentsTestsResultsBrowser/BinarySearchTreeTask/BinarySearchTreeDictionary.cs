using System;
using System.Collections.Generic;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class BinarySearchTreeDictionary :
        BinarySearchTreeKeyValuePairs<string, BinarySearchTreeKeyValuePairs<string, string[]>>
    {
        public BinarySearchTreeDictionary()
        {
        }

        public BinarySearchTreeDictionary(IComparer<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> comparer) : base(comparer)
        {
        }

        public BinarySearchTreeDictionary(IEnumerable<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> collection) : base(collection)
        {
        }

        public BinarySearchTreeDictionary(IEnumerable<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> collection, IComparer<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> comparer) : base(collection, comparer)
        {
        }
    }
}
