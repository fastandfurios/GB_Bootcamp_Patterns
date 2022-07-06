using System.Collections;

namespace Observer_pattern
{
    public class Simulator : IEnumerable
    {
        private string[] _moves = { "5", "3", "1", "6", "7" };

        public IEnumerator GetEnumerator() 
            => _moves.GetEnumerator();
    }
}
