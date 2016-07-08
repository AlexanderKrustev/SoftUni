namespace Executor.IO.Commands
{
    using Exceptions;
    using Network;

    public class CompareFilesCommand : Command
    {
        public CompareFilesCommand(string input, string[] data, Tester judge, StudentsRepository repository, DownloadManager downloadManager, IOManager inputOutputManager)
            : base(input, data, judge, repository, downloadManager, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            string firstPath = this.Data[1];
            string secondPath = this.Data[2];

            this.Judge.CompareContent(firstPath, secondPath);

        }
    }
}
