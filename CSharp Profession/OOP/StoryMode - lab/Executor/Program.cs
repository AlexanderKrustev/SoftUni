using System;

namespace Executor
{
    using Network;

    public class Program
    {
        public static void Main()
        {
            

            Tester tester = new Tester();
            DownloadManager downloadManager = new DownloadManager();
            IOManager ioManager=new IOManager();
            StudentsRepository repo=new StudentsRepository(new RepositorySorter(), new RepositoryFilter());
            CommandInterpreter currentInterpreter=new CommandInterpreter(tester, repo, downloadManager, ioManager);
            InputReader reader=new InputReader(currentInterpreter);

            reader.StartReadingCommands();


        }
    }
}