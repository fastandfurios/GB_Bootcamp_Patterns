namespace Decorator_pattern
{
    public class Decorator : Component
    {
        private Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if(_component != null)
                _component.Operation();
        }
    }
}
