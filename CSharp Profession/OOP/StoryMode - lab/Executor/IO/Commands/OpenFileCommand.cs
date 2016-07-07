namespace Executor.IO.Commands
{
    using System.Diagnostics;
    using Exceptions;
    using Network;

    public  class OpenFileCommand : Command
    {
       public OpenFileCommand(string input, string[] data, Tester judge, StudentsRepository repository, DownloadManager downloadManager, IOManager inputOutputManager)
            : base(input, data, judge, repository, downloadManager, inputOutputManager)
       {
       }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string fileName = this.Data[1];
            Process.Start(SessionData.currentPath + "\\" + fileName);
           
        }
    }
}
