namespace Builder_pattern
{
    public class HeavyIndustrialUnitBuilder : IndustrialBuilder
    {
        public override void BuildName()
        {
            _industrialUnit.Name = "Heavy Industry";
        }

        public override void BuildTemperature()
        {
            _industrialUnit.Temperature = 1000.0f;
        }

        public override void BuildPressure()
        {
            _industrialUnit.Pressure = 500.0;
        }

        public override void BuildVoltage()
        {
            _industrialUnit.Voltage = 380;
        }

        public override void BuildSupplierName()
        {
            _industrialUnit.SupplierName = "Great Supplier";
        }

        public override void BuildOperatingStatus()
        {
            _industrialUnit.OperatingStatus = OperatingStatus.OPERATING;
        }
    }
}
