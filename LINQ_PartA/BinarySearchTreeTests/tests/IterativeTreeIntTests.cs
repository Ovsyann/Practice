using BinarySearchTreeTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BinarySearchTreeTests.tests
{
    public class IterativeTreeIntTests : IterativeTreeTests<int>
    {
        static Comparison<int> comparison = (int x, int y) =>
        {
            if (x > y)
            {
                return 1;
            }
            if (x < y)
            {
                return -1;
            }

            return 0;
        };
        static int Compare(int x,int y)
        {
            if (x > y)
            {
                return 1;
            }
            if (x < y)
            {
                return -1;
            }

            return 0;
        }

        public static IEnumerable<TestCaseData> GetIntTestRootCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2 }).Returns(2);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 21, 34, 56, 32, 43 }).Returns(10);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 4, 2, 6, 10 }).Returns(5);
        }

        public static IEnumerable<TestCaseData> GetIntTestSecondValueCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(3);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 21, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(12);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 4, 2, 6, 10 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(7);
        }

        public static IEnumerable<TestCaseData> GetIntTestAddRangeCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 }, new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(2);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 21, 34, 56, 32, 43 }, new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(10);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 4, 2, 6, 10 }, new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(5);
        }

        public static IEnumerable<TestCaseData> GetIntTestAddOneNewCaseData()
        {
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<int>(comparison, true), 2).Returns(2);
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<int>(comparison, true), 8).Returns(8);
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<int>(comparison, true), 3).Returns(3);
        }

        public static IEnumerable<TestCaseData> GetIntCreationByLeftAndRightCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 3, 1);
            yield return new TestCaseData(new List<int>() { 10, 12, 8 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 12, 8);
            yield return new TestCaseData(new List<int>() { 5, 7, 4 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 7, 4);
        }

        public static IEnumerable<TestCaseData> GetIntCreationByTwoLeftCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 1, 0 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 1, 0);
            yield return new TestCaseData(new List<int>() { 10, 9, 8 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 9, 8);
            yield return new TestCaseData(new List<int>() { 5, 4, 3 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 4, 3);
        }

        public static IEnumerable<TestCaseData> GetIntCreationByTwoRightCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 4 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 3, 4);
            yield return new TestCaseData(new List<int>() { 10, 11, 12 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 11, 12);
            yield return new TestCaseData(new List<int>() { 5, 6, 7 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 6, 7);
        }

        public static IEnumerable<TestCaseData> GetIntCreationByOneLeftCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 1}, new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(1);
            yield return new TestCaseData(new List<int>() { 10, 9}, new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(9);
            yield return new TestCaseData(new List<int>() { 5, 4}, new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(4);
        }

        public static IEnumerable<TestCaseData> GetIntCrationWithoutElementsCaseData()
        {
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<int>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetIntFint_2_CaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 2).Returns(2);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 2, 34, 56, 32, 43 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 2).Returns(2);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 2).Returns(2);
        }

        public static IEnumerable<TestCaseData> GetIntGetEnumeratorCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 21, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 4, 2, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetIntGetLeftCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(1);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 2, 34, 56, 32, 43 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(2);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(1);
        }

        public static IEnumerable<TestCaseData> GetIntGetMaxCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(3);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 2, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(56);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(10);
        }

        public static IEnumerable<TestCaseData> GetIntGetMinCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(1);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 2, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(2);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(1);
        }

        public static IEnumerable<TestCaseData> GetIntGetReversedEnumeratorCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 21, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 4, 2, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetIntGetRightCaseData()
        {
            yield return new TestCaseData(new List<int>() { 2, 3, 1 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(3);
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 2, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(56);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true)).Returns(10);
        }

        public static IEnumerable<TestCaseData> GetIntDeleteNodeCaseData()
        {
            yield return new TestCaseData(new List<int>() { 5, 8, 2, 3, 1, 9, 7, },
                new BinarySearchTreeTask.Comparer<int>(comparison, true),
                new List<int>() { 1,3,5,7,8,9 },
                2);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true), 
                new List<int>() { 1, 2, 3, 5, 6, 7, 10 },
                9);
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 2, 1, 6, 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true),
                new List<int>() { 1, 2, 5, 6, 7, 9, 10 }, 
                3);
        }

        public  static IEnumerable<TestCaseData> GetIntSerializationAndDeserializationTestCaseData()
        {
            yield return new TestCaseData(new List<int>(), 
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 10, 12, 8, 6, 9, 5, 21, 34, 56, 32, 43 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 5, 7, 9, 3, 4, 2, 6, 10 }, 
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetIntNodeSerializationCaseData()
        {
            yield return new TestCaseData(new List<int>() { 10 },
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 10, 9},
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
            yield return new TestCaseData(new List<int>() { 10, 8, 9},
                new BinarySearchTreeTask.Comparer<int>(comparison, true));
        }

        [TestCaseSource(nameof(GetIntNodeSerializationCaseData))]
        public override void TestNodeSerialization(IEnumerable<int> collection, IComparer<int> comparer)
        {
            base.TestNodeSerialization(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntSerializationAndDeserializationTestCaseData))]
        public override void TestSerializationAndDeserialization_OneTree_SameTree(IEnumerable<int> collection, IComparer<int> comparer)
        {
            base.TestSerializationAndDeserialization_OneTree_SameTree(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntTestRootCaseData))]
        public override int TestGetRootValue(IEnumerable<int> values)
        {
            return base.TestGetRootValue(values);
        }

        [TestCaseSource(nameof(GetIntTestSecondValueCaseData))]
        public override int TestCreationByTwoElements_Right_Success(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestCreationByTwoElements_Right_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntTestAddRangeCaseData))]
        public override int TestAddRange_RangeOfNewValues_Success(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestAddRange_RangeOfNewValues_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntTestAddOneNewCaseData))]
        public override int TestAdd_OneNewValue_Success(IComparer<int> comparer, int item)
        {
            return base.TestAdd_OneNewValue_Success(comparer, item);
        }

        [TestCaseSource(nameof(GetIntCreationByLeftAndRightCaseData))]
        public override void TestCreationByThreeElements_LeftAndRight_Success(IEnumerable<int> collection, IComparer<int> comparer, int expectedX, int expectedY)
        {
            base.TestCreationByThreeElements_LeftAndRight_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetIntCreationByTwoLeftCaseData))]
        public override void TestCreationByThreeElements_TwoLeft_Success(IEnumerable<int> collection, IComparer<int> comparer, int expectedX, int expectedY)
        {
            base.TestCreationByThreeElements_TwoLeft_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetIntCreationByTwoRightCaseData))]
        public override void TestCreationByThreeElements_TwoRight_Success(IEnumerable<int> collection, IComparer<int> comparer, int expectedX, int expectedY)
        {
            base.TestCreationByThreeElements_TwoRight_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetIntCreationByOneLeftCaseData))]
        public override int TestCreationByTwoElements_Left_Success(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestCreationByTwoElements_Left_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntCrationWithoutElementsCaseData))]
        public override void TestCreation_EmptyTree_Success(IComparer<int> comparer)
        {
            base.TestCreation_EmptyTree_Success(comparer);
        }

        [TestCaseSource(nameof(GetIntFint_2_CaseData))]
        public override int TestFind_2_Success(IEnumerable<int> collection, IComparer<int> comparer, int itemToFind)
        {
            return base.TestFind_2_Success(collection, comparer, itemToFind);
        }

        [TestCaseSource(nameof(GetIntGetEnumeratorCaseData))]
        public override void TestGetEnumerator_12345_12345(IEnumerable<int> collection, IComparer<int> comparer)
        {
            base.TestGetEnumerator_12345_12345(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntGetLeftCaseData))]
        public override int TestGetLeft_5281397_1(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestGetLeft_5281397_1(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntGetMaxCaseData))]
        public override int TestGetMax_ValuesRange_5(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestGetMax_ValuesRange_5(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntGetMinCaseData))]
        public override int TestGetMin_ValuesRange_56(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestGetMin_ValuesRange_56(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntGetReversedEnumeratorCaseData))]
        public override void TestGetReversedEnumerator_5281397_9875321(IEnumerable<int> collection, IComparer<int> comparer)
        {
            base.TestGetReversedEnumerator_5281397_9875321(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntGetRightCaseData))]
        public override int TestGetRight_5281397_7(IEnumerable<int> collection, IComparer<int> comparer)
        {
            return base.TestGetRight_5281397_7(collection, comparer);
        }

        [TestCaseSource(nameof(GetIntDeleteNodeCaseData))]
        public override void TestDeleteNode_Success(IEnumerable<int> collection, IComparer<int> comparer, List<int> expected, int dataToDelete)
        {
            base.TestDeleteNode_Success(collection, comparer, expected, dataToDelete);
        }
    }
}
