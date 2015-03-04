using System;

namespace NMockaroo.Exceptions
{
    [Serializable]
    public class MockarooException : Exception
    {
        public MockarooException()
        {
        }

        public MockarooException(string message)
            : base(message)
        {
        }

        public MockarooException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}