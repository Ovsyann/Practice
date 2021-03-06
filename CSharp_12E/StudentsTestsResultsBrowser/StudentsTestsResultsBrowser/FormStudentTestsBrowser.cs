﻿using System;
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
using System.Xml.Serialization;

namespace StudentsTestsResultsBrowser
{
    public partial class FormStudentTestsBrowser : Form
    {
        Filter<StudentTestResult> filter = new Filter<StudentTestResult>();
        BinarySearchTree<StudentTestResult> studentTestResults = new IterativeTree<StudentTestResult>();
        List<StudentTestResult> visibleStudentsTestsResults;
        Sorter<StudentTestResult> sorter;
        List<FilterKeeper> filters;

        public FormStudentTestsBrowser()
        {
            InitializeComponent();
            groupBoxFiltersList.Parent = tableLayoutPanel2;
        }

        //private void FormStudentTestsBrowser_SizeChanged(object sender, EventArgs e)
        //{
        //    groupBoxFiltersList.Left = groupBoxSort.Left + groupBoxSort.Width + 2;
        //    groupBoxFiltersList.Width = tableLayoutPanel2.Right - groupBoxFiltersList.Left;
        //}

        private void FormStudentTestsBrowser_Load(object sender, EventArgs e)
        {
            groupBoxFilterConditions.Parent = tableLayoutPanel2;
            groupBoxFilterConditions.Parent = tableLayoutPanel1;
            dataGridViewFilterConditions.Parent = groupBoxFilterConditions;

            comboBox1.DataSource = typeof(StudentTestResult).GetProperties()
                .Select(property => property.Name)
                .ToArray();
            comboBoxPropertyB.DataSource = typeof(StudentTestResult).GetProperties()
                .Select(property => property.Name)
                .ToArray();
        }

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            filterConditionsList.LayoutPanel.Controls.Add(new FilterConditionUserControl());
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
            form.ShowDialog();
        }

        private void itemClearFilters_Click(object sender, EventArgs e)
        {
            ClearConditions();
            ShowStudentsTestsResults();
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            ConfigureCondition();
            ShowStudentsTestsResults();
        }

        private void UpdateVisualization(FilterConditionUserControl condition)
        {
            dataGridViewFilterConditions.Rows.Add(condition.Property, condition.Operation, condition.ValueA, condition.ValueB);
        }

        private void ConfigureCondition()
        {
            filter.RemoveAllFilters();
            dataGridViewFilterConditions.Rows.Clear();

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

                UpdateVisualization(condition);
            }
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
            if (filterConditionsList.FilterConditions.Any())
            {
                ConstructSortingInfo();
                ApplyExistingConditions();
            }

            dataGridViewResults.Rows.Clear();
            foreach(StudentTestResult testResult in visibleStudentsTestsResults)
            {
                dataGridViewResults.Rows.Add(testResult.FirstName, testResult.LastName,
                    testResult.TestName, testResult.TestDate.ToShortDateString(), testResult.Score);
            }
        }

        private void ConstructSortingInfo()
        {
            sorter = new Sorter<StudentTestResult>();
            ConstructFirstSortingInfo();
            ConstructSecondSortingInfo();
        }

        private void ConstructSecondSortingInfo()
        {
            if (radioButton2Asc.Checked)
            {
                if (comboBoxPropertyB.Text == "Score")
                {
                    sorter.AndSortByAsc(comboBoxPropertyB.Text, typeof(int));
                }

                if (comboBoxPropertyB.Text == "TestDate")
                {
                    sorter.AndSortByAsc(comboBoxPropertyB.Text, typeof(DateTime));
                }
                else
                {
                    sorter.AndSortByAsc(comboBoxPropertyB.Text, typeof(string));
                }
            }
            if (radioButton1.Checked)
            {
                if (comboBoxPropertyB.Text == "Score")
                {
                    sorter.AndSortByDesc(comboBoxPropertyB.Text, typeof(int));
                }

                if (comboBoxPropertyB.Text == "TestDate")
                {
                    sorter.AndSortByDesc(comboBoxPropertyB.Text, typeof(DateTime));
                }
                else
                {
                    sorter.AndSortByDesc(comboBoxPropertyB.Text, typeof(string));
                }
            }
        }

        private void ConstructFirstSortingInfo()
        {
            if (radioButtonAsc.Checked)
            {
                if (comboBox1.Text == "Score")
                {
                    sorter.AndSortByAsc(comboBox1.Text, typeof(int));
                }

                if (comboBox1.Text == "TestDate")
                {
                    sorter.AndSortByAsc(comboBox1.Text, typeof(DateTime));
                }
                else
                {
                    sorter.AndSortByAsc(comboBox1.Text, typeof(string));
                }
            }
            if (radioButtonDesc.Checked)
            {
                if (comboBox1.Text == "Score")
                {
                    sorter.AndSortByDesc(comboBox1.Text, typeof(int));
                }

                if (comboBox1.Text == "TestDate")
                {
                    sorter.AndSortByDesc(comboBox1.Text, typeof(DateTime));
                }
                else
                {
                    sorter.AndSortByDesc(comboBox1.Text, typeof(string));
                }
            }
        }

        private void LoadStudentsTestsResults()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("SerializedStudentsTests.bin"))
            {
                studentTestResults = (BinarySearchTree<StudentTestResult>)formatter.Deserialize(stream);
            }

            visibleStudentsTestsResults = new List<StudentTestResult>(studentTestResults);
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
            if (visibleStudentsTestsResults == null)
            {
                visibleStudentsTestsResults = new List<StudentTestResult>(studentTestResults);
            }
            else
            {
                visibleStudentsTestsResults.Add(studentTestResult);
            }

            ShowStudentsTestsResults();
        }

        private void ClearConditions()
        {
            filter.RemoveAllFilters();

            dataGridViewFilterConditions.Rows.Clear();
            filterConditionsList.LayoutPanel.Controls.Clear();
        }

        private void ApplyExistingConditions()
        {
            IEnumerable<StudentTestResult> buffer = new List<StudentTestResult>(filter.ApplyFilterSettings(studentTestResults));
            buffer = sorter.ApplySort(buffer);

            if (checkBoxOnlyTake.Checked)
            {
                buffer = buffer.Take((int)numericUpDown1.Value);
            }
            
            visibleStudentsTestsResults = new List<StudentTestResult>(buffer);
        }

        private void buttonAddToFiltersList_Click(object sender, EventArgs e)
        {
            FormAddingFilterToList form = new FormAddingFilterToList();
            form.nameSetted += AddFilterToList;
            if(filters == null)
            {
                filters = new List<FilterKeeper>();
            }

            form.ShowDialog(this);
            buttonSaveFilters.Enabled = true;
        }

        private void AddFilterToList(string name)
        {
            filters.Add(new FilterKeeper(name, filterConditionsList.FilterConditions));
            listBoxFiltersList.Items.Add(name);
        }

        private void buttonSaveFilters_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FilterKeeper>));
            using(FileStream stream = File.OpenWrite("SerializedFilters.xml"))
            {
                serializer.Serialize(stream, filters);
            }
        }

        private void buttonOpenFilters_Click(object sender, EventArgs e)
        {
            if (File.Exists("SerializedFilters.xml")) 
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<FilterKeeper>));
                using (FileStream stream = File.OpenRead("SerializedFilters.xml"))
                {
                    filters = (List<FilterKeeper>)serializer.Deserialize(stream);
                }

                listBoxFiltersList.Items.AddRange(filters.Select(filter => filter.Name).ToArray());
            }

            buttonApplyCheckedFilter.Enabled = true;
        }

        private void buttonApplyCheckedFilter_Click(object sender, EventArgs e)
        {
            filterConditionsList.LayoutPanel.Controls.Clear();
            filterConditionsList.FilterConditions = new List<FilterConditionUserControl>();

            FilterKeeper filterKeeper = filters.Find(filter => filter.Name == (string)listBoxFiltersList.SelectedItem);
            foreach (FilterConditionKeeper conditionKeeper in filterKeeper.FilterConditions)
            {
                FilterConditionUserControl condition = new FilterConditionUserControl();
                condition.Property = conditionKeeper.Property;
                condition.Operation = conditionKeeper.Operation;
                condition.ValueA = conditionKeeper.ValueA;
                condition.ValueB = conditionKeeper.ValueB;
                filterConditionsList.FilterConditions.Add(condition);
                filterConditionsList.LayoutPanel.Controls.Add(condition);
            }
        }

        private void filterConditionsList_Load(object sender, EventArgs e)
        {

        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            filters.Clear();
            listBoxFiltersList.Items.Clear();
            buttonApplyCheckedFilter.Enabled = false;
            buttonSaveFilters.Enabled = false;
        }
    }
}
