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

namespace StudentsTestsResultsBrowser.CustomControls
{
    public partial class FilterConditionUserControl : UserControl, INotifyPropertyChanged
    {
        public event EventHandler<FilterConditionUserControl> Removing;
        public event PropertyChangedEventHandler PropertyChanged;

        public FilterConditionUserControl()
        {
            InitializeComponent();
            //ЗАБИНДИТЬ СВОЙСТВА И ПОЛЯ ВВОДА
        }

        //public Operations Operation
        //{
        //    //get
        //    //{
                
        //    //}
        //}

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
