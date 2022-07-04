namespace Adapter_Wrapper
{
    public static class MainClass
    {
        public static void Run()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}
