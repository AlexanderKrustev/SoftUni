namespace Executor.Exceptions
{
    using System;

    public class KeyNotFoundException : Exception
    {
        private const string KeyNotFound = "The given key is not present in the collection";

        public KeyNotFoundException(string message)
            : base(message)
        {
            
        }

        public KeyNotFoundException()
            : base(KeyNotFound)
        {
            
        }
    }
}
