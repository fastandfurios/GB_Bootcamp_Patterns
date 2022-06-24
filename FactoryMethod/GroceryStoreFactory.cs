namespace Factory_method
{
    public class GroceryStoreFactory : IStoreFactory
    {
        public IStore CreateStore()
        {
            return new GroceryStore();
        }
    }
}
