using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTestsResultsBrowser
{
    public partial class FormAddingFilterToList : Form
    {
        public delegate void NameSettedEventHandler(string name);
        public event NameSettedEventHandler nameSetted;

        public FormAddingFilterToList()
        {
            InitializeComponent();
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFilterName.Text))
            {
                nameSetted?.Invoke(textBoxFilterName.Text);
                Close();
            }

            MessageBox.Show("Input any name");
        }

        private void FormAddingFilterToList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }
    }
}
