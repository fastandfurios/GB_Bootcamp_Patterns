namespace Singleton_Multiton
{
    public class LimitedMultiton
    {
        private static Dictionary<Enum, LimitedMultiton> _instances = new();
        private static LimitedMultiton _limitedMultitonInstance = null;

        public static LimitedMultiton Instance(Enum key)
        {
            _limitedMultitonInstance = _instances[key];
            if (_limitedMultitonInstance is null)
            {
                _limitedMultitonInstance = new LimitedMultiton();
                _instances.Add(key, _limitedMultitonInstance);
            }

            return _limitedMultitonInstance;
        }

        public enum Count
        {
            ONE,
            TWO,
            THREE
        }
    }
}
