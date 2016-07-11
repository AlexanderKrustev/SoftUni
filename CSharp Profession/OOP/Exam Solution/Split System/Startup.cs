namespace SystemSplit
{
    using System;
    using Commands;
    using Factories;
    using Repository;


    public class Startup
    {
        static void Main()
        {

            string input = Console.ReadLine();
            Data data=new Data();
            CommandInterpreter commandHandler=new CommandInterpreter();
            HardwareFactory hardwareFactory=new HardwareFactory();
            SoftwareFactory softwareFactory= new SoftwareFactory();

            while (true)
            {
                string[] inputParameters = input.Split(new[] {'(', ')', ','}, StringSplitOptions.RemoveEmptyEntries);

                Command c=commandHandler.ParseCommand(data, inputParameters, hardwareFactory, softwareFactory);
                c.Execute();

                if (inputParameters[0].Equals("System Split"))
                {
                    break;
                }
                input = Console.ReadLine();
            }
           
        }
    }
}
