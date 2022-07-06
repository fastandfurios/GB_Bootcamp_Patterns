namespace ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request is > 20 and < 30)
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
