using StudentTestResultsBrowser.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicLinqExpressions;

namespace StudentTestResultsBrowser
{
    public partial class FormStudentTestsBrowser : Form
    {
        public FormStudentTestsBrowser()
        {
            InitializeComponent();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            //flowLayoutPanelFilterConditions.Controls.Add(new FilterCondition());
        }

        private void buttonClearConditions_Click(object sender, EventArgs e)
        {
            //flowLayoutPanelFilterConditions.Controls.Clear();
        }
    }
}
