namespace Observer_pattern
{
    public class Subject
    {
        private readonly Simulator _simulator = new();
        private const int _speed = 200;

        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        private void Run()
        {
            foreach (string s in _simulator)
            {
                Console.WriteLine($"Subject: {s}");
                SubjectState = s;
                Notify(s);
                Thread.Sleep(_speed);
            }
        }

        public delegate void Callback(string s);

        public event Callback Notify;
    }
}
