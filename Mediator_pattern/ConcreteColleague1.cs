namespace Mediator_pattern;

public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator) : base(mediator)
    {
    }

    public void Send(string message)
    {
        _mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Colleague1 gets message: {message}");
    }
}