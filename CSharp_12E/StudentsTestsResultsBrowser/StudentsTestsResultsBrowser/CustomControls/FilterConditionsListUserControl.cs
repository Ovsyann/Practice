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
using BinarySearchTreeTask;

namespace StudentsTestsResultsBrowser.CustomControls
{
    public partial class FilterConditionsListUserControl : UserControl
    {
        private List<FilterConditionUserControl> FilterConditions { get; set; }

        public FilterConditionsListUserControl()
        {
            InitializeComponent();
            FilterConditions = new List<FilterConditionUserControl>();
        }

        public Control LayoutPanel
        {
            get
            {
                return layoutPanelControl;
            }
        }

        private void AddCondition(FilterConditionUserControl condition)
        {
            condition.Removing += RemoveCondition;
            condition.PropertyChanged += ChangeControlProperty;
            FilterConditions.Add(condition);
        }

        private void ChangeControlProperty(object sender, PropertyChangedEventArgs e)
        {
            //FilterConditionUserControl control = 
        }

        private void RemoveCondition(object sender, FilterConditionUserControl condition)
        {
            FilterConditions.Remove(condition);
            LayoutPanel.Controls.Remove(condition);
        }

        private void ClearConditions()
        {
            
        }

        private void layoutPanelControl_ControlAdded(object sender, ControlEventArgs e)
        {
            AddCondition((FilterConditionUserControl)e.Control);
        }
    }
}
