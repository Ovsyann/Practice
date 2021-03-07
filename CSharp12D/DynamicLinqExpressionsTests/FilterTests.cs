using BinarySearchTreeTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using DynamicLinqExpressions;
using System.Linq;
using System.Text.RegularExpressions;

namespace DynamicLinqExpressionsTests
{
    public class Tests
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
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();

            void TryApplyFilter()
            {
                IEnumerable<StudentTestResult> result = filters.ApplyFilterSettings(testResults);
            }

            Assert.Throws(typeof(ArgumentNullException), TryApplyFilter);
        }

        [TestCaseSource(nameof(GetStudentTestResultEmptyCaseData))]
        public void TestWorkWithEmptyCollection(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();

            void TryApplyFilter()
            {
                IEnumerable<StudentTestResult> result = filters.ApplyFilterSettings(testResults);
            }

            Assert.Throws(typeof(InvalidOperationException), TryApplyFilter);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestWorkWithEmptyFilter(IEnumerable<StudentTestResult> expected)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();

            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(expected);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestIntAndEqualTo(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "Score";
            const byte propertyValue = 5;
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.Score == propertyValue).ToArray();

            filters.AndEqualTo(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestIntAndGreaterThan(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "Score";
            const byte propertyValue = 3;
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.Score > propertyValue).ToArray();

            filters.AndGreaterThan(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestIntAndGreaterThanOrEqual(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "Score";
            const byte propertyValue = 3;
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.Score >= propertyValue).ToArray();

            filters.AndGreaterThanOrEqual(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestIntAndLessThan(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "Score";
            const byte propertyValue = 4;
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.Score < propertyValue).ToArray();

            filters.AndLessThan(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestIntAndLessThanOrEqual(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "Score";
            const byte propertyValue = 4;
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.Score <= propertyValue).ToArray();

            filters.AndLessThanOrEqual(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestIntAndIntoRange(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "Score";
            const byte propertyValueMax = 5;
            const byte propertyValueMin = 5;
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.Score < propertyValueMax && test.Score > propertyValueMin).ToArray();

            filters.AndIntoRange(propertyName, propertyValueMin, propertyValueMax);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndEqualTo(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string propertyValue = "ivan";
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.FirstName == propertyValue).ToArray();

            filters.AndEqualTo(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndGreaterThan(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string propertyValue = "ivan";
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.FirstName.CompareTo(propertyValue) > 0).ToArray();

            filters.AndGreaterThan(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndGreaterThanOrEqual(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string propertyValue = "ivan";
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.FirstName.CompareTo(propertyValue) >= 0).ToArray();

            filters.AndGreaterThanOrEqual(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndLessThan(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string propertyValue = "ivan";
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.FirstName.CompareTo(propertyValue) < 0).ToArray();

            filters.AndLessThan(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndLessThanOrEqual(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string propertyValue = "ivan";
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.FirstName.CompareTo(propertyValue) <= 0).ToArray();

            filters.AndLessThanOrEqual(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndContains(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string propertyValue = "iv";
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.FirstName.Contains(propertyValue)).ToArray();

            filters.AndContains(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestStringAndIsMatch(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "FirstName";
            const string template = @"\b[A-Z]\w*\b";
            Regex propertyValue = new Regex(@"\b[A-Z]\w*\b");
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => Regex.IsMatch(test.FirstName, template)).ToArray();

            filters.AndIsMatch(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDateTimeAndEqualTo(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "TestDate";
            DateTime propertyValue = new DateTime(2021, 02, 04);
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.TestDate == propertyValue).ToArray();

            filters.AndEqualTo(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDateTimeAndGreaterThan(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "TestDate";
            DateTime propertyValue = new DateTime(2021, 02, 04);
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.TestDate > propertyValue).ToArray();

            filters.AndGreaterThan(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDateTimeAndGreaterThanOrEqual(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "TestDate";
            DateTime propertyValue = new DateTime(2021, 02, 04);
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.TestDate >= propertyValue).ToArray();

            filters.AndGreaterThanOrEqual(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDateTimeAndLessThan(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "TestDate";
            DateTime propertyValue = new DateTime(2021, 02, 04);
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.TestDate < propertyValue).ToArray();

            filters.AndLessThan(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDateTimeAndLessThanOrEqual(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "TestDate";
            DateTime propertyValue = new DateTime(2021, 02, 04);
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.TestDate <= propertyValue).ToArray();

            filters.AndLessThanOrEqual(propertyName, propertyValue);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(GetStudentTestResultCaseData))]
        public void TestDateTimeAndIntoRange(IEnumerable<StudentTestResult> testResults)
        {
            Filter<StudentTestResult> filters = new Filter<StudentTestResult>();
            const string propertyName = "TestDate";
            DateTime propertyValueMax = new DateTime(2021, 01, 04);
            DateTime propertyValueMin = new DateTime(2021, 03, 04);
            IEnumerable<StudentTestResult> expected = testResults
                .Where(test => test.TestDate < propertyValueMax && test.TestDate > propertyValueMin).ToArray();

            filters.AndIntoRange(propertyName, propertyValueMin, propertyValueMax);
            IEnumerable<StudentTestResult> actual = filters.ApplyFilterSettings(testResults).ToArray();

            Assert.AreEqual(expected, actual);
        }
    }
}