using System;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class ComparableKeyValuePair<TKey, TValue> : 
        IComparable<ComparableKeyValuePair<TKey, TValue>> 
        where TKey :IComparable<TKey>
    {

        public TKey Key { get; set; }

        public TValue Value { get; set; }
       
        public ComparableKeyValuePair() 
        { 

        }

        public ComparableKeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }



        //public XmlSchema GetSchema()
        //{
        //    return null;
        //}

        //public void ReadXml(XmlReader reader)
        //{
        //    reader.ReadStartElement();
        //    DataContractSerializer serializer = new DataContractSerializer(typeof(KeyValuePair<TKey, TValue>));
        //    KeyValuePair = (KeyValuePair<TKey, TValue>)serializer.ReadObject(reader);
        //}

        //public void WriteXml(XmlWriter writer)
        //{
        //    DataContractSerializer serializer = new DataContractSerializer(typeof(KeyValuePair<TKey, TValue>));
        //    serializer.WriteObject(writer, KeyValuePair);
        //}

        //public bool Equals(KeyValuePairProvider<TKey, TValue> other)
        //{
        //    if (other == null)
        //    {
        //        return false;
        //    }

        //    return Key.Equals(other.Key);
        //}

        public override bool Equals(object other)
        {
            if (other is ComparableKeyValuePair<TKey,TValue>)
            {
                return Key.Equals(((ComparableKeyValuePair<TKey,TValue>) other).Key); 
            }

            return false;
        }

        public int CompareTo(ComparableKeyValuePair<TKey, TValue> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return Key.CompareTo(other.Key);
        }
    }
}
