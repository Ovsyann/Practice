using BinarySearchTreeTask;
using DynamicLinqExpressions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicLinqExpressionsTests
{
    public class SorterTests
    {
        static IEnumerable<TestCaseData> GetStudentTestResultCaseData()
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

        static IEnumerable<TestCaseData> GetStudentTestResultNullCaseData()
        {
            yield return new TestCaseData
                (
                    null
                );
        }

        static IEnumerable<TestCaseData> GetStudentTestResultEmptyCaseData()
        {
            yield return new TestCaseData
                (
                    new List<StudentTestResult>()
                );
        }

        [TestCaseSource(nameof(GetStudentTestResultNullCaseData))]
        public void TestWorkWithNullCollection(IEnumerable<StudentTestResult> testResults)
        {
            Sorter<StudentTestResult> Sorter = new Sorter<StudentTestResult>();

            void TryApplySorter()
            {
                IEnumerable<StudentTestResult> result = Sorter.ApplySort(testResults);
            }

            Assert.Throws(typeof(ArgumentNullException), TryApplySorter);
        }

        [TestCaseSource(nameof(GetStudentTestResultEmptyCaseData))]
        public void TestWorkWithEmptyCollection(IEnumerable<StudentTestResult> testResults)
        {
            Sorter<StudentTestResult> Sorter = new Sorter<StudentTestResult>();

            void TryApplySorter()
            {
                IEnumerable<StudentTestResult> result = Sorter.ApplySort(testResults);
            }

            Assert.Throws(typeof(InvalidOperationException), TryApplySorter);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestWorkWithEmptyFilter(IEnumerable<StudentTestResult> expected)
        {
            Sorter<StudentTestResult> sorter = new Sorter<StudentTestResult>();

            IEnumerable<StudentTestResult> actual = sorter.ApplySort(expected);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestAndSortByAsc_TProperty(IEnumerable<StudentTestResult> testResults)
        {
            Sorter<StudentTestResult> sorter = new Sorter<StudentTestResult>();
            const string propertyName = "Score";
            IEnumerable<StudentTestResult> expected = testResults
                .OrderBy(test => test.Score).ToArray();

            sorter.AndSortByAsc<byte>(propertyName);
            IEnumerable<StudentTestResult> actual = sorter.ApplySort(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDoubleSortByDesc(IEnumerable<StudentTestResult> testResults)
        {
            Sorter<StudentTestResult> sorter = new Sorter<StudentTestResult>();
            const string propertyName = "Score";
            const string propertyNameArgument = "FirstName";
            Type typeOfArgument = typeof(string);
            IEnumerable<StudentTestResult> expected = testResults
                .OrderByDescending(test => test.Score).ThenByDescending(item=>item.FirstName).ToArray();

            sorter.AndSortByDesc<byte>(propertyName);
            sorter.AndSortByDesc(propertyNameArgument, typeOfArgument);
            IEnumerable<StudentTestResult> actual = sorter.ApplySort(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDoubleSortByAsc(IEnumerable<StudentTestResult> testResults)
        {
            Sorter<StudentTestResult> sorter = new Sorter<StudentTestResult>();
            const string propertyName = "Score";
            const string propertyNameArgument = "FirstName";
            Type typeOfArgument = typeof(string);
            IEnumerable<StudentTestResult> expected = testResults
                .OrderBy(test => test.Score).ThenBy(item => item.FirstName).ToArray();

            sorter.AndSortByAsc<byte>(propertyName);
            sorter.AndSortByAsc(propertyNameArgument, typeOfArgument);
            IEnumerable<StudentTestResult> actual = sorter.ApplySort(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }
    }
}
