using System.Reflection;

namespace ObjectPool
{
    public static class MainClass
    {
        public static void Run()
        {
            Console.WriteLine(MethodInfo.GetCurrentMethod()!.Name);
            var reusablePool = new ReusablePool();

            var thrd1 = new Thread(RunPool);
            var thrd2 = new Thread(RunPool);
            var thisObject1 = reusablePool.GetObject();
            var thisObject2 = reusablePool.GetObject();
            thrd1.Start(reusablePool);
            thrd2.Start(reusablePool);
            ViewObject(thisObject1);
            ViewObject(thisObject2);
            Thread.Sleep(2000);
            reusablePool.Release(thisObject1);
            Thread.Sleep(2000);
            reusablePool.Release(thisObject2);
        }

        private static void ViewObject(Reusable thisObject)
        {
            foreach (var obj in thisObject.Objs)
            {
                Console.WriteLine(obj.ToString() + @" ");
            }

            Console.WriteLine();
        }

        private static void RunPool(object? obj)
        {
            Console.WriteLine("\t" + MethodInfo.GetCurrentMethod()!.Name);
            var reusablePoll = obj as ReusablePool;
            Console.WriteLine("\tstart wait");
            var thisObject1 = reusablePoll.WaitForObject();
            ViewObject(thisObject1);
            Console.WriteLine("\tend wait");
            reusablePoll.Release(thisObject1);
        }
    }
}
