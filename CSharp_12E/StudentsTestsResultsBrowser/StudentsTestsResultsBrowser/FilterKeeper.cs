using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsTestsResultsBrowser.CustomControls;

namespace StudentsTestsResultsBrowser
{
    [Serializable]
    public class FilterKeeper
    {
        public FilterKeeper()
        {

        }

        public FilterKeeper(string name, List<FilterConditionKeeper> filterConditions)
        {
            Name = name;
            FilterConditions = filterConditions;
        }

        public FilterKeeper(string name, List<FilterConditionUserControl> filterConditions)
        {
            Name = name;
            FilterConditions = new List<FilterConditionKeeper>();
            foreach(FilterConditionUserControl condition in filterConditions)
            {
                FilterConditions.Add(new FilterConditionKeeper(condition.Property, condition.Operation,
                    condition.ValueA, condition.ValueB));
            }
        }

        public string Name{ get; set; }
        public List<FilterConditionKeeper> FilterConditions { get; set; }
    }
}
