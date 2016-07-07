namespace Executor.IO.Commands
{
    using Exceptions;
    using Network;

    public class DownloadFileCommand : Command
    {
        public DownloadFileCommand(string input, string[] data, Tester judge, StudentsRepository repository, DownloadManager downloadManager, IOManager inputOutputManager)
            : base(input, data, judge, repository, downloadManager, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string url = this.Data[1];
            this.DownloadManager.Download(url);
        }
    }
}
