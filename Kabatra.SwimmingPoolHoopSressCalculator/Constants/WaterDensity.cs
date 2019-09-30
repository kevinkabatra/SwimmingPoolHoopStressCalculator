namespace Kabatra.SwimmingPoolHoopStressCalculator.Constants
{
    using Converters;
    using Quantities;

    /// <summary>
    ///     Object representing the known constant values for water density. Does not take into account the temperature.
    /// </summary>
    /// <see href="https://www.vcalc.com/wiki/vCalc/Density+Water+at+STP+%28US%29"/>
    public class WaterDensity
    {
        public readonly decimal Value;
        public readonly Density UnitOfMeasure;

        private const decimal DensityOfWaterInKilogramsPerMeterCubedAtStandardTemperatureAndPressure = 998.2071m;

        /// <summary>
        ///     Constructs a new Water Density. The value will change based on the unit of measure selected.
        /// </summary>
        /// <param name="unitOfMeasure"></param>
        public WaterDensity(Density unitOfMeasure = Density.KilogramPerMeterCubed)
        {
            UnitOfMeasure = unitOfMeasure;

            switch(unitOfMeasure)
            {
                case Density.KilogramPerLiter:
                    Value = MeterConverter.FromMetersTo(
                        DensityOfWaterInKilogramsPerMeterCubedAtStandardTemperatureAndPressure,
                        Volume.Liter
                    );
                    break;
                case Density.KilogramPerMeterCubed:
                    Value = DensityOfWaterInKilogramsPerMeterCubedAtStandardTemperatureAndPressure;
                    break;
                default:
                    throw new System.NotSupportedException("Density type of: " + unitOfMeasure + " is currently not supported.");
            }
        }
    }
}
