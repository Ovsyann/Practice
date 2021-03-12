using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinarySearchTreeTask;

namespace StudentsTestsResultsBrowser
{
    public partial class FormAddingStudentTestResult : Form
    {
        public FormAddingStudentTestResult()
        {
            InitializeComponent();
            tableLayoutPanelInner.Parent = tableLayoutPanelOuter;
            BindPropertiesToControls();
        }

        private void BindPropertiesToControls()
        {
            textBoxFirstName.DataBindings.Add(nameof(textBoxFirstName.Text), textBoxFirstName,
                nameof(FirstName));
            textBoxLastName.DataBindings.Add(nameof(textBoxLastName.Text), textBoxLastName,
                nameof(LastName));
            textBoxTestName.DataBindings.Add(nameof(textBoxTestName.Text), textBoxTestName,
                nameof(TestName));
            dateTimePickerTestDate.DataBindings.Add(nameof(dateTimePickerTestDate.Value), dateTimePickerTestDate,
                nameof(TestDate));
            numericUpDownTestScore.DataBindings.Add(nameof(numericUpDownTestScore.Value), numericUpDownTestScore,
                nameof(Score));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TestName { get; set; }
        public DateTime TestDate { get; set; }
        public byte Score { get; set; }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StudentTestResult studentTestResult = new StudentTestResult(FirstName, LastName, TestName, TestDate, Score);
            //ПЕРЕДАТЬ В БРАУЗЕР
        }
    }
}
