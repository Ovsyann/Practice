using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class BinarySearchTreeKeyValuePairs<TKey, TValue> : 
        RecursiveTree<ComparableKeyValuePair<TKey,TValue>>, IXmlSerializable where TKey:IComparable<TKey>
    {
        public BinarySearchTreeKeyValuePairs()
        {

        }

        public BinarySearchTreeKeyValuePairs(IComparer<ComparableKeyValuePair<TKey, TValue>> comparer) : base(comparer)
        {

        }

        public BinarySearchTreeKeyValuePairs(IEnumerable<ComparableKeyValuePair<TKey, TValue>> collection) : base(collection)
        {

        }

        public BinarySearchTreeKeyValuePairs(IEnumerable<ComparableKeyValuePair<TKey, TValue>> collection, IComparer<ComparableKeyValuePair<TKey, TValue>> comparer) : base(collection, comparer)
        {

        }

        public bool ContainsKey(TKey key)
        {
            Node<ComparableKeyValuePair<TKey, TValue>> node = Find(new ComparableKeyValuePair<TKey, TValue>(key, default));
            return node != null;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            Node<ComparableKeyValuePair<TKey, TValue>> node = Find(new ComparableKeyValuePair<TKey, TValue>(key, default));
            value = node.data.Value;
            return node != null;
        }

        public TKey[] Keys
        {
            get
            {
                List<TKey> items = new List<TKey>();
                foreach(var item in this)
                {
                    items.Add( item.Key);
                }

                return items.ToArray();
            }
        }

        public bool Remove(TKey key)
        {
            Node<ComparableKeyValuePair<TKey, TValue>> node = Find(new ComparableKeyValuePair<TKey, TValue>(key, default));
            return Remove(node.data);
        }

        public void CopyTo(Array array, int index)
        {
            List<KeyValuePair<TKey, TValue>> items = new List<KeyValuePair<TKey, TValue>>();
            foreach (ComparableKeyValuePair<TKey, TValue> item in this)
            {
                items.Add(new KeyValuePair<TKey, TValue>(item.Key,item.Value));
            }

            Array.Copy(items.ToArray(), array, index);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();

            DataContractSerializer contractSerializer = new DataContractSerializer(typeof(Node<ComparableKeyValuePair<TKey, TValue>>));
            Root = (Node<ComparableKeyValuePair<TKey, TValue>>)contractSerializer.ReadObject(reader);

            //XmlSerializer serializer = new XmlSerializer(typeof(Node<KeyValuePairProvider<TKey, TValue>>));
            //Root = (Node<KeyValuePairProvider<TKey, TValue>>)serializer.Deserialize(reader);
            //if(Root != null)
            //{
            //    Root.leftChild = (Node<KeyValuePairProvider<TKey, TValue>>)serializer.Deserialize(reader);
            //    Root.rightChild = (Node<KeyValuePairProvider<TKey, TValue>>)serializer.Deserialize(reader);
            //}
        }

        public void WriteXml(XmlWriter writer)
        {
            DataContractSerializer contractSerializer = new DataContractSerializer(typeof(Node<ComparableKeyValuePair<TKey, TValue>>));
            contractSerializer.WriteObject(writer, Root);

            //XmlSerializer serializer = new XmlSerializer(typeof(Node<KeyValuePairProvider<TKey, TValue>>));
            //serializer.Serialize(writer, Root);

        }
    }
}
