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
using StudentsTestsResultsBrowser;

namespace StudentTestResultsBrowser
{
    public partial class FormStudentTestsBrowser : Form
    {
        Filter<StudentTestResult> filter = new Filter<StudentTestResult>();
        BinarySearchTree<StudentTestResult> studentTestResults = new IterativeTree<StudentTestResult>();

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

        private void buttonClearConditions_Click(object sender, EventArgs e)
        {
            filter.RemoveAllFilters();
            filterConditionsList.LayoutPanel.Controls.Clear();
        }

        private void itemOpenTestResults_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Rows.Clear();

            LoadStudentsTestsResults();

            dataGridViewResults.Rows.Add(studentTestResults.ToArray());
        }

        private void itemSaveTestResults_Click(object sender, EventArgs e)
        {
            UploadStudentsTestsResults();
        }

        private void LoadStudentsTestsResults()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("SerializedStudentsTests.bin"))
            {
                studentTestResults = (BinarySearchTree<StudentTestResult>)formatter.Deserialize(stream);
            }
        }

        private void UploadStudentsTestsResults()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenWrite("SerializedStudentsTests.bin"))
            {
                formatter.Serialize(stream, studentTestResults);
            }
        }

        private void itemAddStudentTestResult_Click(object sender, EventArgs e)
        {
            FormAddingStudentTestResult form = new FormAddingStudentTestResult();
            form.ShowDialog(this);
        }
    }
}
