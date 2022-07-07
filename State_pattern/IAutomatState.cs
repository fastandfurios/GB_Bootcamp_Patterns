namespace State_pattern
{
    public interface IAutomatState
    {
        string GotApplication();
        string CheckApplication();
        string RentApartment();
        string DispenseKeys();
    }
}