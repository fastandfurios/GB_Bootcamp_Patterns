namespace State_pattern
{
    public interface IAutomat
    {
        int Count { get; set; }

        void GotApplication();
        void CheckApplication();
        void RentApartment();
        void SetState(IAutomatState state);
        IAutomatState GetWaitingState();
        IAutomatState GetGotApplicationState();
        IAutomatState GetApartmentRentedState();
        IAutomatState GetFullyRentedState();
    }
}
