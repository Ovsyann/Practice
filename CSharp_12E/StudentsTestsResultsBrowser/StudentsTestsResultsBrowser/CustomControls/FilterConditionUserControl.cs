﻿using StudentsTestsResultsBrowser.CustomControls;
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
using System.Xml.Serialization;

namespace StudentsTestsResultsBrowser.CustomControls
{
    [Serializable]
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

            InitializeStartValues();

            AddBinding(comboBoxOperations, nameof(comboBoxOperations.Text), nameof(Operation));
            AddBinding(comboBoxProperty, nameof(comboBoxProperty.Text), nameof(Property));
            AddBinding(textBoxValueA, nameof(textBoxValueA.Text), nameof(ValueA));
            AddBinding(textBoxValueB, nameof(textBoxValueB.Text), nameof(ValueB));
        }


        private string operation;
        private string property;
        private string valueA;
        private string valueB;

        private void InitializeStartValues()
        {
            property = "FirstName";
            operation = "EqualTo";
        }

        [XmlElement]
        public string Operation 
        {
            get
            {
                return operation;
            } 
            set
            {
                operation = value;
                NotifyPropertyChanged(nameof(Operation));
            }
        }

        [XmlElement]
        public string Property
        {
            get
            {
                return property;
            }
            set
            {
                property = value;
                NotifyPropertyChanged(nameof(Property));
            }
        }

        [XmlElement]
        public string ValueA
        {
            get
            {
                return valueA;
            }
            set
            {
                valueA = value;
                NotifyPropertyChanged(nameof(ValueA));
            }
        }

        [XmlElement]
        public string ValueB
        {
            get
            {
                return valueB;
            }
            set
            {
                valueB = value;
                NotifyPropertyChanged(nameof(ValueB));
            }
        }

        private void AddBinding(Control control, string controlPropertyName, string memberName)
        {
            Binding binding = new Binding(controlPropertyName, this, memberName,true,DataSourceUpdateMode.OnPropertyChanged);
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
