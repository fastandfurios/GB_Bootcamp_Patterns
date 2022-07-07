namespace State_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var automat = new Automat(9);

            automat.GotApplication();
            automat.CheckApplication();
            automat.RentApartment();
        }
    }
}
