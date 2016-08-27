namespace Executor.IO
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Executor.Contracts;
    using Executor.Static_data;

    public class InputReader : IReader
    {
        private const string EndCommand = "quit";

        private IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();

            while (input != EndCommand)
            {
                this.interpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();
            }

            if (SessionData.TaskPool.Count != 0)
            {
                Task.WaitAll(SessionData.TaskPool.ToArray());
            }
        }
    }
}
