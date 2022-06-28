namespace Builder_pattern
{
    public class Director
    {
        private IndustrialBuilder _builder;

        public void SetBuilder(IndustrialBuilder builder)
        {
            _builder = builder;
        }

        public IndustrialUnit BuildIndustrialUnit()
        {
            _builder.CreateIndustrial();
            _builder.BuildName();
            _builder.BuildTemperature();
            _builder.BuildPressure();
            _builder.BuildVoltage();
            _builder.BuildSupplierName();
            _builder.BuildOperatingStatus();

            var industrialUnit = _builder.GetIndustrialUnit();
            return industrialUnit;
        }
    }
}
