using System;

namespace Command.TurnOnLight
{
    internal class TurnOnLightService : IServiceCommand<TurnOnLightData>
    {
        public void Execute(TurnOnLightData command)
        {
            Console.WriteLine(command.Message);
        }
    }
}
