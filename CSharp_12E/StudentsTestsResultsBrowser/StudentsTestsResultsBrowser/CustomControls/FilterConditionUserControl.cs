using StudentTestResultsBrowser.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinarySearchTreeTask;

namespace StudentsTestsResultsBrowser.CustomControls
{
    public partial class FilterConditionUserControl : UserControl, INotifyPropertyChanged
    {
        public event EventHandler<FilterConditionUserControl> Removing;
        public event PropertyChangedEventHandler PropertyChanged;

        public FilterConditionUserControl()
        {
            InitializeComponent();

            comboBoxOperations.DataSource = Enum.GetValues(typeof(Operations));
            comboBoxProperty.DataSource = typeof(StudentTestResult).GetProperties()
                .Select(property => property.Name)
                .ToArray();

            AddBinding(comboBoxOperations, nameof(comboBoxOperations.Text), nameof(Operation));
            AddBinding(comboBoxProperty, nameof(comboBoxProperty.Text), nameof(Property));
            AddBinding(textBoxValueA, nameof(textBoxValueA.Text), nameof(ValueA));
            AddBinding(textBoxValueB, nameof(textBoxValueB.Text), nameof(ValueB));
        }

        private string operation;
        private string property;
        private string valueA;
        private string valueB;

        public string Operation 
        {
            get
            {
                return operation;
            } 
            private set
            {
                operation = value;
                NotifyPropertyChanged(nameof(Operation));
            }
        }

        public string Property
        {
            get
            {
                return property;
            }
            private set
            {
                property = value;
                NotifyPropertyChanged(nameof(Property));
            }
        }

        public string ValueA
        {
            get
            {
                return valueA;
            }
            private set
            {
                valueA = value;
                NotifyPropertyChanged(nameof(ValueA));
            }
        }

        public string ValueB
        {
            get
            {
                return valueB;
            }
            private set
            {
                valueB = value;
                NotifyPropertyChanged(nameof(ValueB));
            }
        }

        private void AddBinding(Control control, string controlPropertyName, string memberName)
        {
            Binding binding = new Binding(controlPropertyName, this, memberName);
            control.DataBindings.Add(binding);
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void buttonRemoveCondition_Click(object sender, EventArgs e)
        {
            Removing?.Invoke(sender, this);
        }
    }
}
