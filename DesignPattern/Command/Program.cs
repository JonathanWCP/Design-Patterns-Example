using Command.TurnOffLight;
using Command.TurnOnLight;
using System;
using System.Threading;

namespace Command
{
    public class Program
    {
        private readonly static IServiceCommand<TurnOnLightData> _turnOnLight = new TurnOnLightService();
        private readonly static IServiceCommand<TurnOffLightData> _turnOffLight = new TurnOffLightService();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Thread.Sleep(2000);
            _turnOnLight.Execute(new TurnOnLightData());

            Thread.Sleep(2000);
            _turnOffLight.Execute(new TurnOffLightData());

            Thread.Sleep(2000);
            Console.WriteLine("Exiting the application.");
            Environment.Exit(0);
        }
    }
}
