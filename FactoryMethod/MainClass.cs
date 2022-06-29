namespace Factory_method
{
    public static class MainClass
    {
        public static void Run()
        {
            IStore store = new GroceryStore();
            store.SaleGood();

            IStoreFactory storeFactory = new GroceryStoreFactory();
            var storeGrocery = storeFactory.CreateStore();
            storeGrocery.SaleGood();

            IStoreFactory storeFactoryWear = new WearStoreFactory();
            var storeWear = storeFactoryWear.CreateStore();
            storeWear.SaleGood();
        }
    }
}
