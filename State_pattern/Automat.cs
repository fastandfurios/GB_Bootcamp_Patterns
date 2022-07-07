namespace State_pattern
{
    public class Automat : IAutomat
    {
        private IAutomatState _waitingState;
        private IAutomatState _gotApplicationState;
        private IAutomatState _apartmentRentedState;
        private IAutomatState _fullyRentedState;
        private IAutomatState _state;
        private int _count;

        public Automat(int count)
        {
            _count = count;
            _waitingState = new WaitingState(this);
            _gotApplicationState = new GotApplicationState(this);
            _apartmentRentedState = new ApartmentRentedState(this);
            _fullyRentedState = new FullyRentedState(this);
            _state = _waitingState;
        }

        public int Count { get => _count; set => _count = value; }

        public void GotApplication()
        {
            Console.WriteLine(_state.GotApplication());
        }

        public void CheckApplication()
        {
            Console.WriteLine(_state.CheckApplication());
        }

        public void RentApartment()
        {
            Console.WriteLine(_state.RentApartment());
            Console.WriteLine(_state.DispenseKeys());
        }

        public void SetState(IAutomatState state)
        {
            _state = state;
        }

        public IAutomatState GetWaitingState()
        {
            return _waitingState;
        }

        public IAutomatState GetGotApplicationState()
        {
            return _gotApplicationState;
        }

        public IAutomatState GetApartmentRentedState()
        {
            return _apartmentRentedState;
        }

        public IAutomatState GetFullyRentedState()
        {
            return _fullyRentedState;
        }
    }
}
