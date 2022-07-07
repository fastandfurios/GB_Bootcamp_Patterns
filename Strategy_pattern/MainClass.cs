namespace Strategy_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var context = new Context(new ConcreteStrategy1());
            context.ExecuteOperation();
            context.SetStrategy(new ConcreteStrategy2());
            context.ExecuteOperation();
        }
    }
}
