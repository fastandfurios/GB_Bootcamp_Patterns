namespace ObjectPool
{
    public class Creator : ICreation<Reusable>
    {
        private static int _id = 0;

        public Reusable Create()
        {
            ++_id;
            return new(_id);
        }
    }
}
