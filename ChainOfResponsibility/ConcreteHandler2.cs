namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request is > 10 and < 20)
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
