namespace Executor.Exceptions
{
    using System;

    public class InvalidStringException : Exception
    {
        private const string NullOrEmpyValue = "The value of the variable CANNOT be null or empty!";

        public InvalidStringException(string message)
            : base(message)
        {
            
        }

        public InvalidStringException()
            : base(NullOrEmpyValue)
        {

        }
    }
}
