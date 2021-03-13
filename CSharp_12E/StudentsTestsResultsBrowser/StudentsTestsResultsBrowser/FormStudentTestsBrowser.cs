using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsTestsResultsBrowser.CustomControls;
using BinarySearchTreeTask;
using DynamicLinqExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace StudentsTestsResultsBrowser
{
    public partial class FormStudentTestsBrowser : Form
    {
        Filter<StudentTestResult> filter = new Filter<StudentTestResult>();
        BinarySearchTree<StudentTestResult> studentTestResults = new IterativeTree<StudentTestResult>();
        BinarySearchTree<StudentTestResult> visibleStudentsTestsResults;

        public FormStudentTestsBrowser()
        {
            InitializeComponent();
        }

        private void FormStudentTestsBrowser_SizeChanged(object sender, EventArgs e)
        {
            groupBoxFiltersList.Left = groupBoxSort.Left + groupBoxSort.Width + 2;
            groupBoxFiltersList.Width = tableLayoutPanel2.Right - groupBoxFiltersList.Left;
        }

        private void FormStudentTestsBrowser_Load(object sender, EventArgs e)
        {
            groupBoxFilterConditions.Parent = tableLayoutPanel2;
            groupBoxFilterConditions.Parent = tableLayoutPanel1;
            dataGridViewFilterConditions.Parent = groupBoxFilterConditions;
        }

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            filterConditionsList.LayoutPanel.Controls.Add(new FilterConditionUserControl());
        }

        private void filterConditionsList_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void itemOpenTestResults_Click(object sender, EventArgs e)
        {
            LoadStudentsTestsResults();
            ShowStudentsTestsResults();
        }

        private void itemSaveTestResults_Click(object sender, EventArgs e)
        {
            UploadStudentsTestsResults();
        }

        private void itemAddStudentTestResult_Click(object sender, EventArgs e)
        {
            FormAddingStudentTestResult form = new FormAddingStudentTestResult();
            form.StudentTestCreated += AddStudentTestResult;
            form.ShowDialog(this);
        }

        private void itemClearFilters_Click(object sender, EventArgs e)
        {
            ClearConditions();
            ApplyConditions();
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            ClearConditions();
            Type type = typeof(StudentTestResult);
            object propertyValueA;
            object propertyValueB;
            string propertyName;
            foreach (FilterConditionUserControl condition in filterConditionsList.FilterConditions)
            {
                if (condition.Operation == nameof(Operations.EqualTo))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndEqualTo(propertyName, propertyValueA);
                }
                if (condition.Operation == nameof(Operations.GreaterThan))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndGreaterThan(propertyName, propertyValueA);
                }
                if (condition.Operation == nameof(Operations.GreaterTHanOrEqual))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndGreaterThanOrEqual(propertyName, propertyValueA);
                }
                if (condition.Operation == nameof(Operations.LessThan))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndLessThan(propertyName, propertyValueA);
                }
                if (condition.Operation == nameof(Operations.LessThanOrEqual))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndLessThanOrEqual(propertyName, propertyValueA);
                }
                if (condition.Operation == nameof(Operations.Contains))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndContains(propertyName, (string)propertyValueA);
                }
                if (condition.Operation == nameof(Operations.IsMatch))
                {
                    propertyName = GetProperty(condition, out propertyValueA);
                    filter.AndIsMatch(propertyName, new Regex((string)propertyValueA));
                }
                if (condition.Operation == nameof(Operations.IntoRange))
                {
                    propertyName = GetProperty(condition, out propertyValueA, out propertyValueB);
                    filter.AndIntoRange(propertyName, propertyValueA, propertyValueB);
                }
            }

            ApplyConditions();
            ShowStudentsTestsResults();
        }

        private string GetProperty(FilterConditionUserControl condition, out object propertyValueA, out object propertyValueB)
        {
            if (condition.Property == "Score")
            {
                propertyValueA = byte.Parse(condition.ValueA);
                propertyValueB = byte.Parse(condition.ValueB);
            }
            else if (condition.Property == "TestDate")
            {
                propertyValueA = DateTime.Parse(condition.ValueA);
                propertyValueB = DateTime.Parse(condition.ValueB);
            }
            else
            {
                propertyValueA = condition.ValueA;
                propertyValueB = condition.ValueB;
            }

            return condition.Property;
        }

        private string GetProperty(FilterConditionUserControl condition, out object propertyValue)
        {
            if (condition.Property == "Score")
            {
                propertyValue = byte.Parse(condition.ValueA);
            }
            else if (condition.Property == "TestDate")
            {
                propertyValue = DateTime.Parse(condition.ValueA);
            }
            else
            {
                propertyValue = condition.ValueA;
            }

            return condition.Property;
        }

        private void ShowStudentsTestsResults()
        {
            dataGridViewResults.Rows.Clear();
            foreach(StudentTestResult testResult in visibleStudentsTestsResults)
            {
                dataGridViewResults.Rows.Add(testResult.FirstName, testResult.LastName,
                    testResult.TestName, testResult.TestDate.ToShortDateString(), testResult.Score);
            }
        }

        private void LoadStudentsTestsResults()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("SerializedStudentsTests.bin"))
            {
                studentTestResults = (BinarySearchTree<StudentTestResult>)formatter.Deserialize(stream);
            }

            visibleStudentsTestsResults = new IterativeTree<StudentTestResult>(studentTestResults);
        }

        private void UploadStudentsTestsResults()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenWrite("SerializedStudentsTests.bin"))
            {
                formatter.Serialize(stream, studentTestResults);
            }
        }

        private void AddStudentTestResult(StudentTestResult studentTestResult)
        {
            studentTestResults.Add(studentTestResult);
            visibleStudentsTestsResults.Add(studentTestResult);
            ShowStudentsTestsResults();
        }

        private void ClearConditions()
        {
            filter.RemoveAllFilters();
            filterConditionsList.LayoutPanel.Controls.Clear();
        }

        private void ApplyConditions()
        {
            visibleStudentsTestsResults = (IterativeTree<StudentTestResult>)filter.ApplyFilterSettings(studentTestResults);
        }
    }
}
