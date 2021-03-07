using System;
using System.Collections.Generic;
using System.Linq;
using BinarySearchTreeTask;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace BinarySearchTreeTests.tests
{
    class IterativeTreeStudentTestResultTest : IterativeTreeTests<StudentTestResult>
    {
        static Comparison<StudentTestResult> comparison = (StudentTestResult x, StudentTestResult y) =>
        {
            if (x.Score > y.Score)
            {
                return 1;
            }
            if (x.Score < y.Score)
            {
                return -1;
            }

            return 0;
        };

        public static IEnumerable<StudentTestResult> GetStudentTestResults() 
        {
            return new List<StudentTestResult>()
            {
                new StudentTestResult() {FirstName = "ivan", LastName= "Ivanov", Score=5},
                new StudentTestResult() {FirstName = "Petr", LastName= "Petrov", Score=8},
                new StudentTestResult() {FirstName = "Sidor", LastName= "Sidorov", Score=2},
                new StudentTestResult() {FirstName = "Kirill", LastName= "Kirillov", Score=1},
                new StudentTestResult() {FirstName = "Sergey", LastName= "Sergeev", Score=3},
                new StudentTestResult() {FirstName = "Sumail", LastName= "Sumailov", Score=7},
                new StudentTestResult() {FirstName = "Elisey", LastName= "Eliseev", Score=9},

            };
        }

        public static IEnumerable<StudentTestResult> GetStudentTestResultsWithoutThird()
        {
            return new List<StudentTestResult>()
            {
                new StudentTestResult() {FirstName = "Kirill", LastName= "Kirillov", Score=1},
                new StudentTestResult() {FirstName = "Sergey", LastName= "Sergeev", Score=3},
                new StudentTestResult() {FirstName = "ivan", LastName= "Ivanov", Score=5},
                new StudentTestResult() {FirstName = "Sumail", LastName= "Sumailov", Score=7},
                new StudentTestResult() {FirstName = "Petr", LastName= "Petrov", Score=8},
                new StudentTestResult() {FirstName = "Elisey", LastName= "Eliseev", Score=9},
            };
        }

        public static IEnumerable<StudentTestResult> GetStudentTestResultsWithoutFifth()
        {
            return new List<StudentTestResult>()
            {
                new StudentTestResult() {FirstName = "Kirill", LastName= "Kirillov", Score=1},
                new StudentTestResult() {FirstName = "Sidor", LastName= "Sidorov", Score=2},
                new StudentTestResult() {FirstName = "Sergey", LastName= "Sergeev", Score=3},
                new StudentTestResult() {FirstName = "ivan", LastName= "Ivanov", Score=5},
                new StudentTestResult() {FirstName = "Petr", LastName= "Petrov", Score=8},
                new StudentTestResult() {FirstName = "Elisey", LastName= "Eliseev", Score=9},
            };
        }

        public static IEnumerable<StudentTestResult> GetStudentTestResultsWithoutSixth()
        {
            return new List<StudentTestResult>()
            {
                new StudentTestResult() {FirstName = "Kirill", LastName= "Kirillov", Score=1},
                new StudentTestResult() {FirstName = "Sidor", LastName= "Sidorov", Score=2},
                new StudentTestResult() {FirstName = "Sergey", LastName= "Sergeev", Score=3},
                new StudentTestResult() {FirstName = "ivan", LastName= "Ivanov", Score=5},
                new StudentTestResult() {FirstName = "Sumail", LastName= "Sumailov", Score=7},
                new StudentTestResult() {FirstName = "Petr", LastName= "Petrov", Score=8},
            };
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultTestRootCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults())).Returns(
                GetStudentTestResults().ToArray()[0]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultTestSecondValueCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns(
                GetStudentTestResults().ToArray()[1]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultTestAddRangeCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()), 
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns(
                GetStudentTestResults().ToArray()[0]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultTestAddOneNewCaseData()
        {
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true), 
                GetStudentTestResults().FirstOrDefault()).Returns(GetStudentTestResults().FirstOrDefault());
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                GetStudentTestResults().LastOrDefault()).Returns(GetStudentTestResults().LastOrDefault());
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultCreationByLeftAndRightCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>() { 
                    GetStudentTestResults().ToArray()[0], GetStudentTestResults().ToArray()[1], GetStudentTestResults().ToArray()[2]},
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                GetStudentTestResults().ToArray()[1], 
                GetStudentTestResults().ToArray()[2]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultCreationByTwoLeftCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>() {
                    GetStudentTestResults().ToArray()[0], GetStudentTestResults().ToArray()[2], GetStudentTestResults().ToArray()[3]},
                 new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                 GetStudentTestResults().ToArray()[2], 
                 GetStudentTestResults().ToArray()[3]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultCreationByTwoRightCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>() {
                    GetStudentTestResults().ToArray()[0], GetStudentTestResults().ToArray()[1], GetStudentTestResults().ToArray()[6]},
                 new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                 GetStudentTestResults().ToArray()[1],
                 GetStudentTestResults().ToArray()[6]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultCreationByOneLeftCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>() 
            { 
                GetStudentTestResults().ToArray()[0], 
                GetStudentTestResults().ToArray()[2], 
            },

            new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns(GetStudentTestResults().ToArray()[2]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultCrationWithoutElementsCaseData()
        {
            yield return new TestCaseData(new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultFind_2_CaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true), 
                GetStudentTestResults().ToArray()[2]).Returns
                (
                    GetStudentTestResults().ToArray()[2]
                );
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultGetEnumeratorCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultGetLeftCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns
                (
                    GetStudentTestResults().ToArray()[3]
                );
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultGetMaxCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns(GetStudentTestResults().ToArray()[6]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultGetMinCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
               new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns
               (
                   GetStudentTestResults().ToArray()[3]
               );
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultGetReversedEnumeratorCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                 new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true));
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultGetRightCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true)).Returns(GetStudentTestResults().ToArray()[6]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultDeleteNodeCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                new List<StudentTestResult>(GetStudentTestResultsWithoutThird()),
                GetStudentTestResults().ToArray()[2]);
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                new List<StudentTestResult>(GetStudentTestResultsWithoutFifth()),
                GetStudentTestResults().ToArray()[5]);
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
                new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true),
                new List<StudentTestResult>(GetStudentTestResultsWithoutSixth()),
                GetStudentTestResults().ToArray()[6]);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultSerializationCaseData()
        {
            yield return new TestCaseData(new List<StudentTestResult>(GetStudentTestResults()),
               new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true));
            yield return new TestCaseData(new List<StudentTestResult>(),
               new BinarySearchTreeTask.Comparer<StudentTestResult>(comparison, true));
        }

        [TestCaseSource(nameof(GetStudentTestResultSerializationCaseData))]
        public override void TestSerializationAndDeserialization_OneTree_SameTree(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            base.TestSerializationAndDeserialization_OneTree_SameTree(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultTestRootCaseData))]
        public override StudentTestResult TestGetRootValue(IEnumerable<StudentTestResult> values)
        {
            return base.TestGetRootValue(values);
        }

        [TestCaseSource(nameof(GetStudentTestResultTestSecondValueCaseData))]
        public override StudentTestResult TestCreationByTwoElements_Right_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestCreationByTwoElements_Right_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultTestAddRangeCaseData))]
        public override StudentTestResult TestAddRange_RangeOfNewValues_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestAddRange_RangeOfNewValues_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultTestAddOneNewCaseData))]
        public override StudentTestResult TestAdd_OneNewValue_Success(IComparer<StudentTestResult> comparer, StudentTestResult item)
        {
            return base.TestAdd_OneNewValue_Success(comparer, item);
        }

        [TestCaseSource(nameof(GetStudentTestResultCreationByLeftAndRightCaseData))]
        public override void TestCreationByThreeElements_LeftAndRight_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer, StudentTestResult expectedX, StudentTestResult expectedY)
        {
            base.TestCreationByThreeElements_LeftAndRight_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetStudentTestResultCreationByTwoLeftCaseData))]
        public override void TestCreationByThreeElements_TwoLeft_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer, StudentTestResult expectedX, StudentTestResult expectedY)
        {
            base.TestCreationByThreeElements_TwoLeft_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetStudentTestResultCreationByTwoRightCaseData))]
        public override void TestCreationByThreeElements_TwoRight_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer, StudentTestResult expectedX, StudentTestResult expectedY)
        {
            base.TestCreationByThreeElements_TwoRight_Success(collection, comparer, expectedX, expectedY);
        }

        [TestCaseSource(nameof(GetStudentTestResultCreationByOneLeftCaseData))]
        public override StudentTestResult TestCreationByTwoElements_Left_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestCreationByTwoElements_Left_Success(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultCrationWithoutElementsCaseData))]
        public override void TestCreation_EmptyTree_Success(IComparer<StudentTestResult> comparer)
        {
            base.TestCreation_EmptyTree_Success(comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultFind_2_CaseData))]
        public override StudentTestResult TestFind_2_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer, StudentTestResult itemToFind)
        {
            return base.TestFind_2_Success(collection, comparer, itemToFind);
        }

        [TestCaseSource(nameof(GetStudentTestResultGetEnumeratorCaseData))]
        public override void TestGetEnumerator_12345_12345(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            base.TestGetEnumerator_12345_12345(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultGetLeftCaseData))]
        public override StudentTestResult TestGetLeft_5281397_1(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestGetLeft_5281397_1(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultGetMaxCaseData))]
        public override StudentTestResult TestGetMax_ValuesRange_5(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestGetMax_ValuesRange_5(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultGetMinCaseData))]
        public override StudentTestResult TestGetMin_ValuesRange_56(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestGetMin_ValuesRange_56(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultGetReversedEnumeratorCaseData))]
        public override void TestGetReversedEnumerator_5281397_9875321(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            base.TestGetReversedEnumerator_5281397_9875321(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultGetRightCaseData))]
        public override StudentTestResult TestGetRight_5281397_7(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer)
        {
            return base.TestGetRight_5281397_7(collection, comparer);
        }

        [TestCaseSource(nameof(GetStudentTestResultDeleteNodeCaseData))]
        public override void TestDeleteNode_Success(IEnumerable<StudentTestResult> collection, IComparer<StudentTestResult> comparer, List<StudentTestResult> expected, StudentTestResult dataToDelete)
        {
            base.TestDeleteNode_Success(collection, comparer, expected, dataToDelete);
        }

        public static IEnumerable<TestCaseData> GetStudentTestResultFirstTestDateCaseData()
        {
            yield return new TestCaseData
                (
                    new List<StudentTestResult>()
                    {
                        new StudentTestResult() {FirstName = "ivan", LastName= "Ivanov", TestName = "HTML - 100", TestDate = DateTime.Parse("25.12.2020"), Score=3},
                        new StudentTestResult() {FirstName = "Petr", LastName= "Petrov", TestName = "HTML - 200", TestDate = DateTime.Parse("26.12.2020"), Score=5},
                        new StudentTestResult() {FirstName = "Sidor", LastName= "Sidorov", TestName = "SQL", TestDate = DateTime.Parse("03.01.2021"), Score=1},
                        new StudentTestResult() {FirstName = "Kirill", LastName= "Kirillov", TestName = "CssHtml100", TestDate = DateTime.Parse("04.01.2021"), Score=2},
                        new StudentTestResult() {FirstName = "Sergey", LastName= "Sergeev", TestName = "CSS - 300", TestDate = DateTime.Parse("01.02.2021"), Score=3},
                        new StudentTestResult() {FirstName = "Sumai", LastName= "Sumailov", TestName = "SQL - 200", TestDate = DateTime.Parse("03.02.2021"), Score=4},
                        new StudentTestResult() {FirstName = "Elisey", LastName= "Eliseev", TestName = "SQL - 100", TestDate = DateTime.Parse("04.02.2021"), Score=5},
                        new StudentTestResult() {FirstName = "Sumai", LastName= "Sumailov", TestName = "SQL - 200", TestDate = DateTime.Parse("05.02.2021"), Score=5},
                        new StudentTestResult() {FirstName = "Kirill", LastName= "Kirillov", TestName = "CssHtml100", TestDate = DateTime.Parse("05.01.2021"), Score=5},
                    }
                );
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestFirstStudentTestDate(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            DateTime expected = testResults
                .First().TestDate;

            var query = tree
                .Where(p => p.TestDate == tree.Min(p => p.TestDate))
                .Select(p => p.TestDate);

            DateTime actual = query.First();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestStudentTestAmount(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            int expected = testResults
                .Where(p => p.TestDate.Year == DateTime.Now.Year)
                .Count();

            var query = tree
                .Where(p => p.TestDate.Year == DateTime.Now.Year)
                .Count();

            int actual = query;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestStudentTestsThreeMaxEstimates(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            IEnumerable<byte> expected = testResults
                .OrderBy(p => p.Score)
                .TakeLast(3)
                .Select(p => p.Score);

            IEnumerable<byte> actual = tree
                .OrderBy(p=>p.Score)
                .TakeLast(3)
                .Select(p=>p.Score);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestStudentTestsFullStudentNames(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = testResults
                .OrderBy(p=>p.FirstName)
                .Select(p => new KeyValuePair<string, string>(p.FirstName, p.LastName)).
                Distinct()
                .ToArray();

            var actual = tree
                .Select(p => new KeyValuePair<string, string>(p.FirstName, p.LastName)).
                Distinct()
                .ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestGoodStudents(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = testResults
                .OrderBy(p=>p.FirstName)
                .Where(p => p.Score > 3)
                .Distinct()
                .ToArray();

            var actual = tree
                .Where(p => p.Score > 3)
                .Distinct()
                .ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestFailedTests(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = testResults
                .OrderBy(p => p.FirstName)
                .Where(p => p.Score < 3)
                .Distinct()
                .ToArray();

            var actual = tree
                .Where(p => p.Score < 3)
                .Distinct()
                .ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestStudentAverageScore(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = testResults.GroupBy(p => p.FirstName).
                Select(p => new KeyValuePair<string, double>(p.Key, p.Average(p => p.Score)))
                .OrderBy(p=>p.Key);

            var actual = tree.GroupBy(p => p.FirstName).
                Select(p => new KeyValuePair<string, double>(p.Key, p.Average(p => p.Score)));

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestMonthAndYearParameters(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            int year = DateTime.Now.Year;
            int month = 2;
            var expected = testResults
                .OrderBy(p => p)
                .Where(p => p.TestDate.Month == month && p.TestDate.Year == year);

            var actual = tree
                .Where(p => p.TestDate.Month == month && p.TestDate.Year == year);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestWrongTestNames(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            Regex template = new Regex(@"(SQL|CSS|HTML)\s-\s(100|200|300)");
            var expected = testResults
                .OrderBy(p => p)
                .Where(p => !template.IsMatch(p.TestName))
                .ToArray();

            var actual = tree
                .Where(p => !template.IsMatch(p.TestName))
                .ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestTestsOfEachStudent(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected= testResults
                .OrderBy(p=>p.FirstName)
                .GroupBy(p => p.FirstName, p => p.TestName,
                    (name, tests) => new KeyValuePair<string, string[]>(name, tests.ToArray()))
                .ToArray();

            var actual = tree
                .GroupBy(p => p.FirstName, p => p.TestName, 
                    (name,tests)=> new KeyValuePair<string,string[]>(name,tests.ToArray()))
                .ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestStudentsTestsRetakes(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = new KeyValuePair<string, string[]>[]
            {
                new KeyValuePair<string, string[]>("Kirill",new string[]{"CssHtml100"}),
                new KeyValuePair<string, string[]>("Sumai",new string[]{"SQL - 200"})
            };

            var actual = tree.GroupBy(p => new { p.FirstName, p.TestName })
                .Where(p => p.Count() > 1)
                .Select(p => p.Key)
                .GroupBy(p=>p.FirstName,p=>p.TestName, (name,tests)=>new KeyValuePair<string,string[]>(name,tests.ToArray()))
                .ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestTestsAreNotTaken(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = new string[]
            {
                 "HTML - 100", 
                 "HTML - 200"
            };
            int year = DateTime.Now.Year;

            var testsNames = tree
                .Where(p => p.TestDate.Year == year)
                .Select(p => p.TestName);
            var actual = tree
                .Where(p => !testsNames.Contains(p.TestName))
                .Select(p=>p.TestName)
                .ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultFirstTestDateCaseData))]
        public void TestTestsAreNotTakenByExcept(IEnumerable<StudentTestResult> testResults)
        {
            BinarySearchTree<StudentTestResult> tree = CreateTree(testResults);
            var expected = new string[]
            {
                 "HTML - 100",
                 "HTML - 200"
            };
            int year = DateTime.Now.Year;

            var testsNames = tree
                .Where(p => p.TestDate.Year == year);

            var actual = tree.Except(testsNames)
                .Select(test => test.TestName);

            Assert.AreEqual(expected, actual);
        }
    }
}
