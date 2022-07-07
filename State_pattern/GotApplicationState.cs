namespace State_pattern
{
    public class GotApplicationState : IAutomatState
    {
        private Automat _automat;
        private readonly Random _random;

        public GotApplicationState(Automat automat)
        {
            _automat = automat;
            _random = new Random(DateTime.Now.Millisecond);
        }

        public string GotApplication()
        {
            return "We alredy got your application.";
        }

        public string CheckApplication()
        {
            var yesNo = _random.Next() % 10;

            if (yesNo > 4 && _automat.Count > 0)
            {
                _automat.SetState(_automat.GetApartmentRentedState());
                return "Congratulations, you were approved.";
            }
            else
            {
                _automat.SetState(_automat.GetWaitingState());
                return "Sorry, you were not approved.";
            }
        }

        public string RentApartment()
        { 
            return "You must have your application checked.";
        }

        public string DispenseKeys()
        {
            return "You must have your application checked.";
        }
    }
}
