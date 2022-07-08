namespace Iterator_pattern;

public class ConcreteIterator : Iterator
{
    private readonly Aggregate _aggregate;
    private int _current;

    public ConcreteIterator(Aggregate aggregate)
    {
        _aggregate = aggregate;
    }

    public override object First()
    {
        return _aggregate[0];
    }

    public override object Next()
    {
        object nextItem = null;
        if(_current < _aggregate.Count - 1)
            nextItem = _aggregate[++_current];

        return nextItem;
    }

    public override bool IsDone()
    {
        return _current >= _aggregate.Count;
    }

    public override object CurrentItem()
    {
        return _aggregate[_current];
    }
}