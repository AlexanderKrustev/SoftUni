
namespace SystemSplit.Commands
{
    using System;
    using Factories;
    using Repository;

    public class CommandInterpreter
    {

        public Command ParseCommand(Data data, string[] input, HardwareFactory hardwareFactory, SoftwareFactory softwareFactory)
        {
            switch (input[0])
            {
                case "RegisterPowerHardware": return new RegisterPowerHardware(data,input,hardwareFactory,softwareFactory);
                case "RegisterHeavyHardware": return new RegisterHeavyHardware(data, input,hardwareFactory, softwareFactory);
                case "RegisterExpressSoftware": return new RegisterExpressSoftware(data, input, hardwareFactory, softwareFactory);
                case "RegisterLightSoftware": return  new RegisterLightSoftware(data, input,hardwareFactory,softwareFactory);
                case "Analyze": return new Analyze(data, input,hardwareFactory, softwareFactory);
                case "ReleaseSoftwareComponent": return  new ReleaseSoftwareComponent(data, input,hardwareFactory,softwareFactory);
                case "System Split": return new SystemSplit(data, input,hardwareFactory, softwareFactory);
                case "Dump": return new Dump(data, input, hardwareFactory, softwareFactory);
                case "Restore": return new Restore(data, input, hardwareFactory, softwareFactory);
                case "Destroy": return new Destroy(data, input, hardwareFactory, softwareFactory);
                case "DumpAnalyze": return new DumpAnalyze(data, input, hardwareFactory, softwareFactory);
                    
                default: throw new ArgumentException(string.Format("Incorrect Comand {0}",input[0]));
               
            }
        }
    }
}
