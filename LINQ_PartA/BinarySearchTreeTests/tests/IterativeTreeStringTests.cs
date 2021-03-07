using BinarySearchTreeTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BinarySearchTreeTests.tests
{
    public class IterativeTreeStringTests : IterativeTreeTests<string>
    {
        static Comparison<string> comparison = (string x, string y) =>
        {
            if (x.Length > y.Length)
            {
                return 1;
            }
            if (x.Length < y.Length)
            {
                return -1;
            }

            return 0;
        };

        public static IEnumerable<TestCaseData> GetStringTestRootCaseData()
        {
            yield return new TestCaseData(new List<string>() { "brown" }).Returns("brown");
            yield return new TestCaseData(new List<string>() { "fox" }).Returns("fox");
            yield return new TestCaseData(new List<string>() { "quit" }).Returns("quit");
        }

        public static IEnumerable<TestCaseData> GetStringTestSecondValueCaseData()
        {
            yield return new TestCaseData(new List<string>() { "fox", "brown"}, 
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("brown");
            yield return new TestCaseData(new List<string>() { "brown", "pronencation" }, 
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("pronencation");
            yield return new TestCaseData(new List<string>() { "a", "quit"}, 
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("quit");
        }

        public static IEnumerable<TestCaseData> GetStringTestAddRangeCaseData()
        {
            yield return new TestCaseData(new List<string>() { "brown", "greenyyy", "bluest" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("brown");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" }, 
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("greenyyy");
            yield return new TestCaseData(new List<string>() { "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" }, 
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("bluest");
        }

        public static IEnumerable<TestCaseData> GetStringTestAddOneNewCaseData()
        {
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<string>(comparison, true), "2").Returns("2");
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<string>(comparison, true), "8").Returns("8");
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<string>(comparison, true), "3").Returns("3");
        }

        public static IEnumerable<TestCaseData> GetStringCreationByLeftAndRightCaseData()
        {
            yield return new TestCaseData(new List<string>() { "brown", "greenyyy", "blue" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "greenyyy", "blue");
            yield return new TestCaseData(new List<string>() { "brosdwn", "greeeeenyyy", "blue" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "greeeeenyyy", "blue");
            yield return new TestCaseData(new List<string>() { "brownnn", "greenyyy", "blue" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "greenyyy", "blue");
        }

        public static IEnumerable<TestCaseData> GetStringCreationByTwoLeftCaseData()
        {
            yield return new TestCaseData(new List<string>() { "brow", "gre", "bl" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "gre", "bl");
            yield return new TestCaseData(new List<string>() { "brown", "gree", "blue" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "gree", "blue");
            yield return new TestCaseData(new List<string>() { "brown", "gre", "b" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "gre", "b");
        }

        public static IEnumerable<TestCaseData> GetStringCreationByTwoRightCaseData()
        {
            yield return new TestCaseData(new List<string>() { "red", "quickly", "yellowSubmarin" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "quickly", "yellowSubmarin");
            yield return new TestCaseData(new List<string>() { "re", "quick", "yellow" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "quick", "yellow");
            yield return new TestCaseData(new List<string>() { "r", "qui", "yell" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "qui", "yell");
        }

        public static IEnumerable<TestCaseData> GetStringCreationByOneLeftCaseData()
        {
            yield return new TestCaseData(new List<string>() { "reded", "quic" }, new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("quic");
            yield return new TestCaseData(new List<string>() { "redy", "qui" }, new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("qui");
            yield return new TestCaseData(new List<string>() { "red", "qu" }, new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("qu");
        }

        public static IEnumerable<TestCaseData> GetStringCrationWithoutElementsCaseData()
        {
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<string>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetStringFindCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "bluest").Returns("bluest");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "yellowSubmarin").Returns("yellowSubmarin");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true), "yellowSub").Returns("yellowSub");
        }

        public static IEnumerable<TestCaseData> GetStringGetEnumeratorCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin",  "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetStringGetLeftCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("red");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("bluest");
            yield return new TestCaseData(new List<string>() { "greenyyy", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("greenyyy");
        }

        public static IEnumerable<TestCaseData> GetStringGetMaxCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("yellowSubmarin");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("yellowSubmar");
            yield return new TestCaseData(new List<string>() { "greenyy", "bluest", "yellowSub" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("yellowSub");
        }

        public static IEnumerable<TestCaseData> GetStringGetMinCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("red");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("bluest");
            yield return new TestCaseData(new List<string>() { "greenyy", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("greenyy");
        }

        public static IEnumerable<TestCaseData> GetStringGetReversedEnumeratorCaseData()
        {
            yield return new TestCaseData(new List<string>() { "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetStringGetRightCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("yellowSubmarin");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("yellowSubmar");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSub" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true)).Returns("yellowSub");
        }

        public static IEnumerable<TestCaseData> GetStringDeleteNodeCaseData()
        {
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true),
                new List<string>() { "red", "bluest", "yellowSub", "yellowSubmar", "yellowSubmarin" },
                "greenyyy");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true),
                new List<string>() { "bluest", "greenyyy", "yellowSub", "yellowSubmarin"},
                "red");
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest", "red", "yellowSubmarin", "yellowSub", "yellowSubmar", "yare" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true),
                new List<string>() { "red", "yare", "bluest", "greenyyy", "yellowSub", "yellowSubmar" },
                "yellowSubmarin");
        }

        public static IEnumerable<TestCaseData> GetStringTestSerializationCaseData()
        {
            yield return new TestCaseData(new List<string>(),
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new List<string>() { "greenyyy", "bluest"},
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
            yield return new TestCaseData(new List<string>() { "greenyyy", "blue", "yellow" },
                new BinarySearchTreeTask.Comparer<string>(comparison, true));
        }

        [TestCaseSource(nameof(GetStringTestSerializationCaseData))]
        public void TestStringTreeSerializationByRootSerialization(IEnumerable<string> collection, IComparer<string> comparer)
        {
            BinarySearchTreeString expected = new BinarySearchTreeString(collection, comparer);
            XmlSerializer serializer = new XmlSerializer(typeof(BinarySearchTreeString));

            using (FileStream stream = File.Create("SerializedStringTree.xml"))
            {
                serializer.Serialize(stream, expected);
            }

            BinarySearchTreeString actual;
            using (FileStream stream = File.OpenRead("SerializedStringTree.xml"))
            {
                actual = (BinarySearchTreeString)serializer.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStringTestSerializationCaseData))]
        public void TestStringTreeSerializationByRootSerializationWithTreeMutation(IEnumerable<string> collection, IComparer<string> comparer)
        {
            BinarySearchTreeString expected = new BinarySearchTreeString(collection, comparer);
            XmlSerializer serializer = new XmlSerializer(typeof(BinarySearchTreeString));

            using (FileStream stream = File.Create("SerializedStringTree.xml"))
            {
                serializer.Serialize(stream, expected);
            }

            BinarySearchTreeString actual;
            using (FileStream stream = File.OpenRead("SerializedStringTree.xml"))
            {
                actual = (BinarySearchTreeString)serializer.Deserialize(stream);
            }

            expected.Add("TheNewString");

            using (FileStream stream = File.Create("SerializedStringTree.xml"))
            {
                serializer.Serialize(stream, expected);
            }

            using (FileStream stream = File.OpenRead("SerializedStringTree.xml"))
            {
                actual = (BinarySearchTreeString)serializer.Deserialize(stream);
            }

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStringTestRootCaseData))]
        public override string TestGetRootValue(IEnumerable<string> values)
        {
            return base.TestGetRootValue(values);
        }

        [TestCaseSource(nameof(GetStringTestSecondValueCaseData))]
        public override string TestCreationByTwoElements_Right_Success(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestCreationByTwoElements_Right_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringTestAddRangeCaseData))]
        public override string TestAddRange_RangeOfNewValues_Success(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestAddRange_RangeOfNewValues_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringTestAddOneNewCaseData))]
        public override string TestAdd_OneNewValue_Success(IComparer<string> comparer, string item)
        {
            return base.TestAdd_OneNewValue_Success(comparer, item);
        }

        [TestCaseSource(nameof(GetStringCreationByLeftAndRightCaseData))]
        public override void TestCreationByThreeElements_LeftAndRight_Success(IEnumerable<string> collection, IComparer<string> comparer, string expectedX, string expectedY)
        {
            base.TestCreationByThreeElements_LeftAndRight_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetStringCreationByTwoLeftCaseData))]
        public override void TestCreationByThreeElements_TwoLeft_Success(IEnumerable<string> collection, IComparer<string> comparer, string expectedX, string expectedY)
        {
            base.TestCreationByThreeElements_TwoLeft_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetStringCreationByTwoRightCaseData))]
        public override void TestCreationByThreeElements_TwoRight_Success(IEnumerable<string> collection, IComparer<string> comparer, string expectedX, string expectedY)
        {
            base.TestCreationByThreeElements_TwoRight_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetStringCreationByOneLeftCaseData))]
        public override string TestCreationByTwoElements_Left_Success(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestCreationByTwoElements_Left_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringCrationWithoutElementsCaseData))]
        public override void TestCreation_EmptyTree_Success(IComparer<string> comparer)
        {
            base.TestCreation_EmptyTree_Success(comparer);
        }

        [TestCaseSource(nameof(GetStringFindCaseData))]
        public override string TestFind_2_Success(IEnumerable<string> collection, IComparer<string> comparer, string itemToFind)
        {
            return base.TestFind_2_Success(collection, comparer, itemToFind);
        }

        [TestCaseSource(nameof(GetStringGetEnumeratorCaseData))]
        public override void TestGetEnumerator_12345_12345(IEnumerable<string> collection, IComparer<string> comparer)
        {
            base.TestGetEnumerator_12345_12345(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringGetLeftCaseData))]
        public override string TestGetLeft_5281397_1(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestGetLeft_5281397_1(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringGetMaxCaseData))]
        public override string TestGetMax_ValuesRange_5(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestGetMax_ValuesRange_5(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringGetMinCaseData))]
        public override string TestGetMin_ValuesRange_56(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestGetMin_ValuesRange_56(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringGetReversedEnumeratorCaseData))]
        public override void TestGetReversedEnumerator_5281397_9875321(IEnumerable<string> collection, IComparer<string> comparer)
        {
            base.TestGetReversedEnumerator_5281397_9875321(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringGetRightCaseData))]
        public override string TestGetRight_5281397_7(IEnumerable<string> collection, IComparer<string> comparer)
        {
            return base.TestGetRight_5281397_7(collection, comparer);
        }

        [TestCaseSource(nameof(GetStringDeleteNodeCaseData))]
        public override void TestDeleteNode_Success(IEnumerable<string> collection, IComparer<string> comparer, List<string> expected, string dataToDelete)
        {
            base.TestDeleteNode_Success(collection, comparer, expected, dataToDelete);
        }
    }
}
