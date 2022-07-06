namespace Visitor_pattern;

public abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}