namespace Executor.IO.Commands
{
    using System.Text;
    using Exceptions;
    using Network;

    public class GetHelpCommand: Command
    {
        public GetHelpCommand(string input, string[] data, Tester judge, StudentsRepository repository, DownloadManager downloadManager, IOManager inputOutputManager)
            : base(input, data, judge, repository, downloadManager, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.DisplayHelp();
        }

        public void DisplayHelp()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{new string('_', 100)}");
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "make directory - mkdir nameOfFolder"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "traverse directory - ls depth"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "comparing files - cmp absolutePath1 absolutePath2"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "change directory - cdRel relativePath or \"..\" for level up"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "change directory - cdAbs absolutePath"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "read students data base - readDb fileName"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "filter {courseName} excelent/average/poor  take 2/5/all students - filterExcelent (the output is written on the console)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "order increasing students - order {courseName} ascending/descending take 20/10/all (the output is written on the console)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "download file - download URL (saved in current directory)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "download file asinchronously - downloadAsynch URL (saved in the current directory)"));
            stringBuilder.AppendLine(string.Format("|{0, -98}|", "get help – help"));
            stringBuilder.AppendLine($"{new string('_', 100)}");
            stringBuilder.AppendLine();
            OutputWriter.WriteMessageOnNewLine(stringBuilder.ToString());
        }
    }
}
