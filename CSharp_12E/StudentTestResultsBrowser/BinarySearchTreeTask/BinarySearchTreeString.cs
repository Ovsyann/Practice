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
    public class BinarySearchTreeString : IterativeTree<string>, IXmlSerializable
    {
        public BinarySearchTreeString()
        {

        }

        public BinarySearchTreeString(IComparer<string> comparer) : base(comparer)
        {
        }

        public BinarySearchTreeString(IEnumerable<string> collection) : base(collection)
        {
        }

        public BinarySearchTreeString(IEnumerable<string> collection, IComparer<string> comparer) : base(collection, comparer)
        {
        }

        public BinarySearchTreeString(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement(nameof(BinarySearchTreeString));
            XmlSerializer serializer = new XmlSerializer(typeof(Node<string>));
            Root = (Node<string>)serializer.Deserialize(reader);
        }

        public void WriteXml(XmlWriter writer)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Node<string>));
            serializer.Serialize(writer, Root);
        }
    }
}
