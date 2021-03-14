using System;

namespace StudentsTestsResultsBrowser
{
    [Serializable]
    public class FilterConditionKeeper
    {
        public FilterConditionKeeper()
        {

        }

        public FilterConditionKeeper(string property, string operation, string valueA, string valueB)
        {
            Property = property;
            Operation = operation;
            ValueA = valueA;
            ValueB = valueB;
        }

        public string Operation { get; set; }

        public string Property { get; set; }

        public string ValueA { get; set; }

        public string ValueB { get; set; }
    }
}