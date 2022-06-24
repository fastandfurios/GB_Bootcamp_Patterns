using Singleton_Multiton;
using Factory_method;

var singleton = Singleton.Instance();
var singleton2 = Singleton.Instance();

var multiton = Multiton.Instance("1");
multiton = Multiton.Instance("2");

var limitedMultiton = LimitedMultiton.Instance(LimitedMultiton.Count.ONE);
limitedMultiton = LimitedMultiton.Instance(LimitedMultiton.Count.TWO);

Console.WriteLine(singleton.Equals(singleton2));

//***********************************************

IStore store = new GroceryStore();
store.SaleGood();

IStoreFactory storeFactory = new GroceryStoreFactory();
var storeGrocery = storeFactory.CreateStore();
storeGrocery.SaleGood();

IStoreFactory storeFactoryWear = new WearStoreFactory();
var storeWear = storeFactoryWear.CreateStore();
storeWear.SaleGood();

//***********************************************