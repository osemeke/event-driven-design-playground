using MediatorConsoleApp.Mediator;

namespace MediatorConsoleApp.Subscribers
{
    internal class DisplayScreen : ISubscriber
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void Handle(string message)
        {
            Console.WriteLine($"screen {Name} displayed {message}");
            // call signalr
            // message can be json object that can be saved in a db/cache
        }
    }
}
