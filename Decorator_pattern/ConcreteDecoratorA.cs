namespace Decorator_pattern
{
    public class ConcreteDecoratorA : Decorator
    {
        private string _addedState;

        public override void Operation()
        {
            base.Operation();
            _addedState = "New State";
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
