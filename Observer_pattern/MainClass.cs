namespace Observer_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var subject = new Subject();
            var observe = new Observer("Center", subject, "\t\t");
            var observe2 = new Observer("Right", subject, "\t\t\t\t");
            subject.Go();
        }
    }
}
