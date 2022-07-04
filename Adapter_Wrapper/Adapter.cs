namespace Adapter_Wrapper
{
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee = new();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}