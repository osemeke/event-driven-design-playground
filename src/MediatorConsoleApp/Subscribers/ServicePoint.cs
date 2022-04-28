using MediatorConsoleApp.Mediator;

namespace MediatorConsoleApp.Subscribers
{
    internal class ServicePoint : ISubscriber
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void Handle(string message)
        {
            Console.WriteLine($"Service point {this.Name} sent message: {message}");
        }
    }
}
