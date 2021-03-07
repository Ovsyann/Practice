using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using BinarySearchTreeTask;
using NUnit.Framework;

namespace BinarySearchTreeTests.tests
{
    public class BinarySearchTreeDictionaryTests
    {
        static Comparison<ComparableKeyValuePair<string, string[]>> keyValueComparison =
            (ComparableKeyValuePair<string, string[]> x, ComparableKeyValuePair<string, string[]> y) =>
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

        static Comparison<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> stringComparison = 
            (ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>> x,
                ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>> y) =>
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

        private static IEnumerable<BinarySearchTreeTask.ComparableKeyValuePair<string, string[]>> GetHelloTranslation()
        {
            return new List<BinarySearchTreeTask.ComparableKeyValuePair<string, string[]>>() 
            { 
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Russian", new string[] { "Привет", "Здравствуйте", "Добрый день" }),
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Deuthc", new string[] { "Guten tag", "Hallo", "HAIL" }),
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Norvegese", new string[] { "Bonjorno", "ciao" }),
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Italiano", new string[] { "hallo", "god dag" }),
            };
        }

        private static IEnumerable<BinarySearchTreeTask.ComparableKeyValuePair<string, string[]>> GetByeTranslation()
        {
            return new List<BinarySearchTreeTask.ComparableKeyValuePair<string, string[]>>()
            {
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Russian", new string[] { "Пока", "До свидания", "До встречи" }),
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Deuthc", new string[] { "Tschüss", "Auf Wiedersehen"}),
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Norvegese", new string[] { "for", "Ha det", "Ser deg" }),
                new BinarySearchTreeTask.ComparableKeyValuePair<string, string[]> ("Italiano", new string[] { "ci vediamo", "fino a" }),
            };
        }

        public static IEnumerable<TestCaseData> GetTestDictionaryTreeSerializationCaseData()
        {
            yield return new TestCaseData
                (
                    new List<BinarySearchTreeTask.ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>>(),
                    new BinarySearchTreeTask.Comparer<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>>((Comparison<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>>)stringComparison, (bool)true)
                );
            yield return new TestCaseData
                (
                    new List<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>>()
                    {
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>
                        (
                            "hello",
                            new BinarySearchTreeKeyValuePairs<string, string[]>((IEnumerable<ComparableKeyValuePair<string, string[]>>)GetHelloTranslation(), (IComparer<ComparableKeyValuePair<string, string[]>>)new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, string[]>>((Comparison<ComparableKeyValuePair<string, string[]>>)keyValueComparison,(bool)true))
                        ),
                        new BinarySearchTreeTask.ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>
                        (
                            "bye",
                            new BinarySearchTreeKeyValuePairs<string, string[]>((IEnumerable<ComparableKeyValuePair<string, string[]>>)GetByeTranslation(), (IComparer<ComparableKeyValuePair<string, string[]>>)new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, string[]>>((Comparison<ComparableKeyValuePair<string, string[]>>)keyValueComparison,(bool)true))
                        ),
                    },
                    new BinarySearchTreeTask.Comparer<BinarySearchTreeTask.ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>>((Comparison<ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>>)stringComparison, (bool)true)
                );
            
        }



        [TestCaseSource(nameof(GetTestDictionaryTreeSerializationCaseData))]
        public void TestDictionaryTreeSerialization(
            IEnumerable<BinarySearchTreeTask.ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> collection,
            IComparer<BinarySearchTreeTask.ComparableKeyValuePair<string, BinarySearchTreeKeyValuePairs<string, string[]>>> comparer)
        {
            BinarySearchTreeDictionary expected = new BinarySearchTreeDictionary( collection, comparer );
            XmlSerializer serializer = new XmlSerializer(typeof(BinarySearchTreeDictionary));

            using(FileStream stream = File.Create("SerializedDictionary.xml"))
            {
                serializer.Serialize(stream, expected);
            }

            BinarySearchTreeDictionary actual;
            using(FileStream stream = File.OpenRead("SerializedDictionary.xml"))
            {
                actual = (BinarySearchTreeDictionary)serializer.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
