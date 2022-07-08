namespace Iterator_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var concreteAggregate = new ConcreteAggregate();
            concreteAggregate[0] = "Item A";
            concreteAggregate[1] = "Item B";
            concreteAggregate[2] = "Item C";
            concreteAggregate[3] = "Item D";

            var concreteIterator = new ConcreteIterator(concreteAggregate);

            Console.WriteLine("Iterating over collection: ");

            var item = concreteIterator.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = concreteIterator.Next();
            }
        }
    }
}
