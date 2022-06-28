namespace Builder_pattern
{
    public class IndustrialUnit
    {
        public string Name { get; set; }
        public float Temperature { get; set; }
        public double Pressure { get; set; }
        public int Voltage { get; set; }
        public string SupplierName { get; set; }
        public OperatingStatus OperatingStatus { get; set; }

        public override string ToString()
        {
            return $"Name={Name} \n" +
                   $"Temperature={Temperature} \n" +
                   $"Pressure={Pressure} \n" +
                   $"Voltage={Voltage} \n" +
                   $"SupplierName={SupplierName} \n" +
                   $"OperatingStatus={OperatingStatus}";
        }
    }
}