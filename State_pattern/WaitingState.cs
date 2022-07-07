namespace State_pattern
{
    public class WaitingState : IAutomatState
    {
        private Automat _automat;

        public WaitingState(Automat automat)
        {
            _automat = automat;
        }

        public string GotApplication()
        {
            _automat.SetState(_automat.GetGotApplicationState());
            return "Thanks for the application.";
        }

        public string CheckApplication()
        {
            return "You have to submit an application.";
        }

        public string RentApartment()
        {
            return "You have to submit an application.";
        }

        public string DispenseKeys()
        {
            return "You have to submit an application.";
        }
    }
}
