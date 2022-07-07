namespace Mediator_pattern;

public abstract class Colleague
{
    protected Mediator _mediator;

    public Colleague(Mediator mediator)
    {
        _mediator = mediator;
    }
}