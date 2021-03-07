using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BinarySearchTreeTask
{
    [Serializable]
    public class Comparer<TData> : System.Collections.Generic.Comparer<TData>
    {
        public readonly bool isDirectOrder;
        private readonly Func<TData, TData, int> func;

        public Comparer(bool isRightOrder)
        {
            isDirectOrder = isRightOrder;
            func = Default.Compare;
        }

        public Comparer(IComparer<TData> comparer, bool isDirectOrder)
        {
            this.isDirectOrder = isDirectOrder;
            this.func = comparer.Compare;
        }

        public Comparer(Comparison<TData> comparison, bool isDirectOrder)
        {
            this.isDirectOrder = isDirectOrder;
            this.func = comparison.Invoke;
        }

        public Comparer(Func<TData, TData, int> func, bool isDirectOrder)
        {
            this.isDirectOrder = isDirectOrder;
            this.func = func;
        }

        public override int Compare([AllowNull] TData x, [AllowNull] TData y)
        {
            int coef = isDirectOrder ? 1 : -1;
            return coef * func(x, y);
        }
    }
}
