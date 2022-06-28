namespace Builder_pattern
{
    public abstract class IndustrialBuilder
    {
        protected IndustrialUnit _industrialUnit;

        public void CreateIndustrial()
        {
            _industrialUnit = new IndustrialUnit();
        }

        public abstract void BuildName();
        public abstract void BuildTemperature();
        public abstract void BuildPressure();
        public abstract void BuildVoltage();
        public abstract void BuildSupplierName();
        public abstract void BuildOperatingStatus();

        public IndustrialUnit GetIndustrialUnit()
        {
            return _industrialUnit;
        }
    }
}
