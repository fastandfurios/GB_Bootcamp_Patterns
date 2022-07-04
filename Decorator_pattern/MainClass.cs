namespace Decorator_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var concreteComponent = new ConcreteComponent();
            var concreteDecoratorA = new ConcreteDecoratorA();
            var concreteDecoratorB = new ConcreteDecoratorB();

            concreteDecoratorA.SetComponent(concreteComponent);
            concreteDecoratorB.SetComponent(concreteDecoratorA);

            concreteDecoratorB.Operation();
        }
    }
}
