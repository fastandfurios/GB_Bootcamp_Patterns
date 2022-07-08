using System.Collections;

namespace Iterator_pattern
{
    public class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override int Count 
        { 
            get => _items.Count;
            protected set { }
        }

        public override object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}
