namespace Executor.IO.Commands
{
    using System;
    using Exceptions;
    using Network;

    public abstract class Command
    {
        private string input;
        private string[] data;
        private Tester judge;
        private StudentsRepository repository;
        private DownloadManager downloadManager;
        private IOManager inputOutputManager;

        protected Command(string input, string[] data, Tester judge, StudentsRepository repository, DownloadManager downloadManager, IOManager inputOutputManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.downloadManager = downloadManager;
            this.inputOutputManager = inputOutputManager;
        }

        protected IOManager InputOutputManager => this.inputOutputManager;
        
        protected DownloadManager DownloadManager => this.downloadManager;

        protected StudentsRepository Repository => this.repository;

        protected Tester Judge => this.judge;

        protected string Input
        {
            get
            {
                return input;
            }

           private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw  new InvalidStringException();
                }
                input = value;
            }
        }

        protected string[] Data
        {
            get
            {
                return data;
            }

          private  set
            {
                if (value == null || value.Length == 0)
                {
                    throw  new NullReferenceException();
                }
                data = value;
            }
        }
      
        public abstract void Execute();
    }
}
