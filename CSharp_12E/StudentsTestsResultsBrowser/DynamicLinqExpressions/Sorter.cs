using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DynamicLinqExpressions
{
    public class Sorter<TItem>
    {
        private readonly string parameterName = "item";
        private ParameterExpression parameter = null;
        private readonly Type type = typeof(TItem);
        private List<Tuple<SortingDirection, MemberExpression>> sortingСriteria;

        public Sorter()
        {
            parameter = Expression.Parameter(type, parameterName);
            sortingСriteria = new List<Tuple<SortingDirection, MemberExpression>>();
        }

        public void AndSortByAsc<TProperty>(string propertyName)
        {
            RememberCriteria(propertyName, SortingDirection.Asc, typeof(TProperty));
        }


        public void AndSortByAsc(string propertyName, Type propertyType)
        {
            RememberCriteria(propertyName, SortingDirection.Asc, propertyType);
        }

        public void AndSortByDesc<TProperty>(string propertyName)
        {
            RememberCriteria(propertyName, SortingDirection.Desc, typeof(TProperty));
        }

        public void AndSortByDesc(string propertyName, Type propertyType)
        {
            RememberCriteria(propertyName, SortingDirection.Desc, propertyType);
        }

        private void RememberCriteria(string propertyName, SortingDirection providerKind, Type propertyType)
        {
            MemberInfo property = this.type.GetProperty(propertyName, propertyType);
            MemberExpression propertyExpression = Expression.MakeMemberAccess(parameter, property);

            sortingСriteria.Add(new Tuple<SortingDirection, MemberExpression>(providerKind, propertyExpression));
        }

        public IEnumerable<TItem> ApplySort(IEnumerable<TItem> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }
            if (!items.Any())
            {
                throw new InvalidOperationException(string.Format("{0} is empty", nameof(items)));
            }
            if (!sortingСriteria.Any())
            {
                return items;
            }

            IOrderedEnumerable<TItem> result = default;
            foreach(Tuple<SortingDirection, MemberExpression> criterion in sortingСriteria)
            {
                result = ApplyCriterion(items, result, criterion);
            }

            return result;
        }

        private IOrderedEnumerable<TItem> ApplyCriterion(
            IEnumerable<TItem> items, 
            IOrderedEnumerable<TItem> result,
            Tuple<SortingDirection, MemberExpression> criterion)
        {
            Type type = criterion.Item2.Type;
            UnaryExpression expression = Expression.Convert(criterion.Item2, typeof(object));
            Expression<Func<TItem, object>> lambda = Expression.Lambda<Func<TItem, object>>(expression, parameter);

            result = BuildExpression(items, result, criterion, lambda);

            return result;
        }

        private static IOrderedEnumerable<TItem> BuildExpression(IEnumerable<TItem> items, IOrderedEnumerable<TItem> result, 
            Tuple<SortingDirection, MemberExpression> criterion, Expression<Func<TItem, object>> lambda)
        {
            switch (criterion.Item1)
            {
                case SortingDirection.Asc:

                    result = result == null ?
                        items.OrderBy(lambda.Compile()) :
                        result.ThenBy(lambda.Compile());

                    break;

                case SortingDirection.Desc:

                    result = result == null ?
                        items.OrderByDescending(lambda.Compile()) :
                        result.ThenByDescending(lambda.Compile());

                    break;
            }

            return result;
        }
    }
}
