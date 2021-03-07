using System;
using System.Diagnostics.CodeAnalysis;

namespace BinarySearchTreeTask
{
    [Serializable]
    public struct StudentTestResult : IComparable<StudentTestResult>
    {
        private string firstName;
        private string lastName;
        private string testName;
        private DateTime testDate;
        private byte score;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string TestName
        {
            get
            {
                return testName;
            }
            set
            {
                testName = value;
            }
        }

        public DateTime TestDate
        {
            get
            {
                return testDate;
            }
            set
            {
                testDate = value;
            }
        }

        public byte Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public StudentTestResult(string firstName, string lastName, string testName, DateTime testDate, byte score)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.testName = testName;
            this.testDate = testDate;
            this.score = score;
        }

        public int CompareTo([AllowNull] StudentTestResult other)
        {
            if (FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            }

            if (LastName != other.LastName)
            {
                return LastName.CompareTo(other.LastName);
            }

            if (TestName != other.TestName)
            {
                return TestName.CompareTo(other.TestName);
            }

            if (TestDate != other.TestDate)
            {
                return TestDate.CompareTo(other.TestDate);
            }

            return Score.CompareTo(other.Score);
        }
    }
}
