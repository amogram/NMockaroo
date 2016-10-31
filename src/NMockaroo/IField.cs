namespace NMockaroo
{
    public interface IField
    {
        string Name { get; set; }
        IDataType DataType { get; set; }
    }

    public class Field : IField
    {
        public string Name { get; set; }
        public IDataType DataType { get; set; }
    }
}
