namespace NMockaroo.Attributes
{
    public class MockarooSqlExpressionAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// SQL code to include verbatim in the generated output
        /// <see cref="https://mockaroo.com/api/docs#type_sql_expression"/>
        /// </summary>
        public string Value { get; set; }
    }
}
