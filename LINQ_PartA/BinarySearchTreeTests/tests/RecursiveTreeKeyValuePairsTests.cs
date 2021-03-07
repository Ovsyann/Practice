using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BinarySearchTreeTask;
using NUnit.Framework;

namespace BinarySearchTreeTests.tests
{
    public class RecursiveTreeKeyValuePairsTests : RecursiveTreeTests<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>
    {
        static Comparison<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> comparison = 
            (ComparableKeyValuePair<string, int> x, ComparableKeyValuePair<string, int> y) =>
        {
            if (x.Key.Length > y.Key.Length)
            {
                return 1;
            }
            if (x.Key.Length < y.Key.Length)
            {
                return -1;
            }

            return 0;
        };

        public static IEnumerable<TestCaseData> GetTestKeyValuePairInstanceCaseSource()
        {
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Танк", 100)
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Самолёт", 140)
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Авианосец", 600)
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Гаубица", 80)
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair < string, int >("Гаубица", 80),
                        new BinarySearchTreeTask.ComparableKeyValuePair < string, int >("БТР", 50)
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
        }

        public static IEnumerable<TestCaseData> GetTestKeyValuePairsForTreeCaseSource()
        {
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Самолёт", 140),
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>( "Танк", 100),
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Авианосец", 600),
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("Гаубица", 80),
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, int>("БТР", 50)
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Comparison<ComparableKeyValuePair<string, int>>)comparison, (bool)true)
                );
        }

        [TestCaseSource(nameof(GetTestKeyValuePairInstanceCaseSource))]
        public void TestNodeKeyValueSerialization(IEnumerable<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> collection, 
            IComparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> comparer)
        {
            BinarySearchTreeKeyValuePairs<string, int> tree = new BinarySearchTreeKeyValuePairs<string, int>(collection, comparer);
            XmlSerializer serializer = new XmlSerializer(typeof(Node<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>));
            Node<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> expected = new Node<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>((Node<ComparableKeyValuePair<string, int>>)tree.Root);

            using (FileStream stream = File.Create("Serialized.xml"))
            {
                serializer.Serialize(stream, tree.Root);
            }

            Node<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> actual;
            using (FileStream stream = File.OpenRead("Serialized.xml"))
            {
                actual = (Node<BinarySearchTreeTask.ComparableKeyValuePair<string, int>>)serializer.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetTestKeyValuePairsForTreeCaseSource))]
        public void TestTreeXmlSerialization(IEnumerable<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> collection,
            IComparer<BinarySearchTreeTask.ComparableKeyValuePair<string, int>> comparer)
        {
            BinarySearchTreeKeyValuePairs<string,int> expected = new BinarySearchTreeKeyValuePairs<string, int>(collection, comparer);
            XmlSerializer serializer = new XmlSerializer(typeof(BinarySearchTreeKeyValuePairs<string, int>));

            using (FileStream stream = File.Create("SerializedKeyValuePairTree.xml"))
            {
                serializer.Serialize(stream, expected);
            }

            BinarySearchTreeKeyValuePairs<string, int> actual;
            using (FileStream stream = File.OpenRead("SerializedKeyValuePairTree.xml"))
            {
                actual = (BinarySearchTreeKeyValuePairs<string, int>)serializer.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
