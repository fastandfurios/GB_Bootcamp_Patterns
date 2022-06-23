using System.Collections;

namespace Singleton_Multiton
{
    public class Multiton
    {
        private static Dictionary<string, Multiton> _instances = new();
        private static Multiton _multitonInstance = null;

        public static Multiton Instance(string key)
        {
            _multitonInstance = _instances[key];
            if (_multitonInstance is null)
            {
                _multitonInstance = new Multiton();
                _instances.Add(key, _multitonInstance);
            }

            return _multitonInstance;
        }
    }
}
