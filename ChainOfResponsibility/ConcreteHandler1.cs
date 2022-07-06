namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request is > 0 and < 10)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
            }
            else if (_successor != null)
            {
                _successor.HandlerRequest(request);
            }
        }
    }
}
