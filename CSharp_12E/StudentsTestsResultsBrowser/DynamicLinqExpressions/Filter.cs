using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DynamicLinqExpressions
{
    public class Filter<TElement>
    {
        //private const int compareToConstant = 0;
        private const string parameterName = "item";
        private readonly Type type = typeof(TElement);
        //private readonly Type valueType = typeof(TValue);
        private Expression expression = null;
        private ParameterExpression parameter = null;

        public Filter()
        {
            parameter = Expression.Parameter(type, parameterName);
        }

        public void AndEqualTo<TProperty>(string propertyName, TProperty propertyValue)
        {
            MemberExpression propertyAccess = GetPropertyAccess(propertyName);

            ConstantExpression constant = Expression.Constant(propertyValue);
            BinaryExpression equality = Expression.Equal(propertyAccess, constant);

            AddCondition(equality);
        }

        public void AndGreaterThan<TProperty>(string propertyName, TProperty propertyValue)
        {
            MemberExpression propertyAccess = GetPropertyAccess(propertyName);

            ConstantExpression constantExpression;
            MethodCallExpression callExpression = CreateCompareToCallExpression(propertyValue, propertyAccess, out constantExpression);

            BinaryExpression greaterThan = Expression.GreaterThan(callExpression, constantExpression);

            AddCondition(greaterThan);
        }


        public void AndGreaterThanOrEqual<TProperty>(string propertyName, TProperty propertyValue)
        {
            MemberExpression propertyAccess = GetPropertyAccess(propertyName);
            
            ConstantExpression constantExpression;
            MethodCallExpression callExpression = CreateCompareToCallExpression(propertyValue, propertyAccess, out constantExpression);

            BinaryExpression greaterThanOrEqual = Expression.GreaterThanOrEqual(callExpression, constantExpression);

            AddCondition(greaterThanOrEqual);
        }

        public void AndLessThan<TProperty>(string propertyName, TProperty propertyValue)
        {
            MemberExpression propertyAccess = GetPropertyAccess(propertyName);

            ConstantExpression constantExpression;
            MethodCallExpression callExpression = CreateCompareToCallExpression(propertyValue, propertyAccess, out constantExpression);

            BinaryExpression lessThan = Expression.LessThan(callExpression, constantExpression);

            AddCondition(lessThan);
        }

        public void AndLessThanOrEqual<TProperty>(string propertyName, TProperty propertyValue)
        {
            MemberExpression propertyAccess = GetPropertyAccess(propertyName);

            ConstantExpression constantExpression;
            MethodCallExpression callExpression = CreateCompareToCallExpression(propertyValue, propertyAccess, out constantExpression);

            BinaryExpression lessThanOrEqual = Expression.LessThanOrEqual(callExpression, constantExpression);

            AddCondition(lessThanOrEqual);
        }


        public void AndIntoRange<TProperty>(string propertyName, TProperty minValue, TProperty maxValue)
        {
            AndLessThanOrEqual(propertyName, maxValue);
            AndGreaterThan(propertyName, minValue);
        }

        public void AndContains(string propertyName, string propertyValue)
        {
            MemberExpression propertyAccess = GetPropertyAccess(propertyName);

            ConstantExpression constant = Expression.Constant(propertyValue);
            Type propertyType = propertyValue.GetType();
            MethodInfo containsMethod = propertyType.GetMethod("Contains", new Type[] { typeof(string) });
            MethodCallExpression callExpression = Expression.Call(propertyAccess, containsMethod, constant);

            UnaryExpression containsExpression = Expression.IsTrue(callExpression);

            AddCondition(containsExpression);
        }

        public void AndIsMatch(string propertyName, Regex regex)
        {
            Type typeRegex = typeof(Regex);

            MemberExpression propertyAccess = GetPropertyAccess(propertyName);

            ConstantExpression constantExpression = Expression.Constant(regex, typeRegex);
            MethodInfo containsMethod = typeRegex.GetMethod("IsMatch", new Type[] { typeof(string) });
            MethodCallExpression callExpression = Expression.Call(constantExpression, containsMethod, propertyAccess);

            UnaryExpression isMatchExpression = Expression.IsTrue(callExpression);

            AddCondition(isMatchExpression);
        }

        public void RemoveAllFilters()
        {
            expression = Expression.Default(type);
        }

        public IEnumerable<TElement> ApplyFilterSettings(IEnumerable<TElement> items)
        {
            if(items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }
            if (!items.Any())
            {
                throw new InvalidOperationException(string.Format("{0} is empty", nameof(items)));
            }
            if (expression == null)
            {
                return items;
            }

            Expression<Func<TElement, bool>> lambda = Expression.Lambda<Func<TElement, bool>>(expression, parameter);
            return items.Where(lambda.Compile());
        }

        private void AddCondition(Expression expression)
        {
            if (this.expression == null)
            {
                this.expression = expression;
            }
            else
            {
                this.expression = Expression.And(this.expression, expression);
            }
        }

        private MethodCallExpression CreateCompareToCallExpression(object propertyValue, MemberExpression property, out ConstantExpression constantExpression)
        {
            constantExpression = Expression.Constant(0);
            ConstantExpression constant = Expression.Constant(propertyValue);

            Type propertyType = propertyValue.GetType();
            MethodInfo compareToInfo = propertyType.GetMethod("CompareTo", new Type[] { propertyType });

            MethodCallExpression callExpression = Expression.Call(property, compareToInfo, constant);
            return callExpression;
        }

        private MemberExpression GetPropertyAccess(string propertyName)
        {
            MemberInfo property = type.GetProperty(propertyName);

            return Expression.MakeMemberAccess(parameter, property);
        }

    }
}
