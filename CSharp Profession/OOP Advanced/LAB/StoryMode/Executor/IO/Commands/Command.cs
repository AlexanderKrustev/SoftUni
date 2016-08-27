namespace Executor.IO.Commands
{
    using Exceptions;
    using Executor.Contracts;

    public abstract class Command : IExecutable
    {
        private string input;
        private string[] data;

      

        protected Command(string input,string[] data)
        {
            this.Input = input;
            this.Data = data;

           }

        public string Input
        {
            get
            {
                return this.input;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException(value);
                }

                this.input = value;
            }
        }

        public string[] Data
        {
            get
            {
                return this.data;
            }

            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new InvalidCommandException(this.Input);
                }

                this.data = value;
            }
        }
      

        public abstract void Execute();
    }
}
