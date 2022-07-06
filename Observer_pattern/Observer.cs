namespace Observer_pattern
{
    public class Observer : IObserver
    {
        private string _name;
        private Subject _subject;
        private string _state;
        private string _gap;

        public Observer(string name, Subject subject, string gap)
        {
            _name = name;
            _subject = subject;
            _gap = gap;
            _subject.Notify += Update;
        }

        public void Update(string state)
        {
            _state = state;
            Console.WriteLine($"{_gap}{_name}: {_state}");
        }
    }
}
