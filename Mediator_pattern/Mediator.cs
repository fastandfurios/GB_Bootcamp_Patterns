namespace Mediator_pattern
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}