using System;

namespace Command.TurnOffLight
{
    public class TurnOffLightService : IServiceCommand<TurnOffLightData>
    {
        public void Execute(TurnOffLightData command)
        {
            Console.WriteLine(command.Message);
        }
    }
}
