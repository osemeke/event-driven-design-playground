namespace MediatorConsoleApp.Mediator
{
    public interface ISubscriber
    {
        void Handle(string message);
    }
}