namespace SingletonLib
{
    public class Singleton
    {
        private static Singleton _instance = null;

        public static Singleton Instance()
        {
            //return _instance ??= new Singleton();

            if( _instance == null )
                _instance = new Singleton();

            return _instance;
        }
    }
}