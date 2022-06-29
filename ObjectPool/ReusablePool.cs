namespace ObjectPool
{
    public class ReusablePool : ObjectPool<Reusable>
    {
        public ReusablePool() : base(new Creator(), 2)
        {
        }
    }
}
