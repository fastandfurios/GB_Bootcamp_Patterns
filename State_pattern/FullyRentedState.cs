namespace State_pattern
{
    public class FullyRentedState : IAutomatState
    {
        private Automat _automat;

        public FullyRentedState(Automat automat)
        {
            _automat = automat;
        }

        public string GotApplication()
        {
            return "Sorry, we're fully rented.";
        }

        public string CheckApplication()
        {
            return "Sorry, we're fully rented.";
        }

        public string RentApartment()
        {
            return "Sorry, we're fully rented.";
        }

        public string DispenseKeys()
        {
            return "Sorry, we're fully rented.";
        }
    }
}
