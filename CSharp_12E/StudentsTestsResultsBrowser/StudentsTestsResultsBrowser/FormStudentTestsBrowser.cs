using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTestResultsBrowser
{
    public partial class FormStudentTestsBrowser : Form
    {
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
            filterConditionUserControl1.Parent = filterConditionsListUserControl1;
            groupBoxFilterConditions.Parent = tableLayoutPanel2;
            groupBoxFilterConditions.Parent = tableLayoutPanel1;
            dataGridViewFilterConditions.Parent = groupBoxFilterConditions;
        }
    }
}
