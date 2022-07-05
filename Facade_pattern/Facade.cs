namespace Facade_pattern
{
    public static class Facade
    {
        static SubsystemA _a = new();
        static SubsystemB _b = new();
        static SubsystemC _c = new();

        public static void Operation1()
        {
            Console.WriteLine($"Operation 1\n {_a.A1()}{_a.A2()}{_b.B1()}");
        }

        public static void Operation2()
        {
            Console.WriteLine($"Operation 2\n {_b.B1()}{_c.C1()}");
        }
    }
}
