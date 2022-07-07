namespace State_pattern
{
    public class ApartmentRentedState : IAutomatState
    {
        private Automat _automat;

        public ApartmentRentedState(Automat automat)
        {
            _automat = automat;
        }

        public string GotApplication()
        {
            return "Hang on, we'ra renting you an apartmeny";
        }

        public string CheckApplication()
        {
            return "Hang on, we'ra renting you an apartmeny";
        }

        public string RentApartment()
        {
            _automat.Count -= 1;
            return "Renting you an apartment....";
        }

        public string DispenseKeys()
        {
            _automat.SetState(_automat.Count <= 0 ? _automat.GetFullyRentedState() : _automat.GetWaitingState());
            return "Here are your keys!";
        }
    }
}
