namespace Factory_method
{
    public class WearStoreFactory : IStoreFactory
    {
        public IStore CreateStore()
        {
            return new WearStore();
        }
    }
}
