namespace ChainOfResponsibility
{
    public static class MainClass
    {
        public static void Run()
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            var handler3 = new ConcreteHandler3();

            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);

            var requests =new[] { 2, 5, 14, 22, 18, 3, 27 };

            foreach (var request in requests)  
            {
                handler1.HandlerRequest(request);
            }
        }
    }
}
