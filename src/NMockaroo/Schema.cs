using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace NMockaroo
{
    public class Schema<T>
    {
        public List<IField> Fields { get; private set; }

        public Schema()
        {
            Fields = new List<IField>();
        }

        public void AddField(Expression<Func<T, object>> property,  IDataType dataType)
        {
            var propertyName = GetPropertyName(property);

            Fields.Add(new Field
            {
                Name = propertyName,
                DataType = dataType
            });
        }

        private static string GetPropertyName(Expression<Func<T, object>> property)
        {
            var lambda = (LambdaExpression) property;
            MemberExpression memberExpression;

            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression) lambda.Body;
                memberExpression = (MemberExpression) unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression) lambda.Body;
            }

            return ((PropertyInfo) memberExpression.Member).Name;
        }
    }
}
