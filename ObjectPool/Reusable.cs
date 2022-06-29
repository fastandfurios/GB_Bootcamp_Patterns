namespace ObjectPool
{
    public class Reusable
    {
        public object[] Objs { get; private set; }

        public Reusable(params object[] objs)
        {
            Objs = objs;
        }
    }
}
