namespace Builder_pattern
{
    public class LightIndustrialUnitBuilder : IndustrialBuilder
    {
        public override void BuildName()
        {
            _industrialUnit.Name = "Light Industry";
        }

        public override void BuildTemperature()
        {
            _industrialUnit.Temperature = 100.0f;
        }

        public override void BuildPressure()
        {
            _industrialUnit.Pressure = 10.0;
        }

        public override void BuildVoltage()
        {
            _industrialUnit.Voltage = 220;
        }

        public override void BuildSupplierName()
        {
            _industrialUnit.SupplierName = "First Supplier";
        }

        public override void BuildOperatingStatus()
        {
            _industrialUnit.OperatingStatus = OperatingStatus.OPERATING;
        }
    }
}
