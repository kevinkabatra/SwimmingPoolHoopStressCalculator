namespace Kabatra.SwimmingPoolHoopStressCalculator.UnitTests.Units
{
    using Constants;
    using Quantities;
    using Xunit;

    /// <summary>
    ///     Exercises setting water density to its known constants.
    /// </summary>
    public class WaterDensityTests
    {
        [Fact]
        public void CanGetExpectedValueForKilogramsPerMeterCubed()
        {
            const decimal expectedWaterDensityValue = 998.2071m;
            
            const Density unitOfMeasure = Density.KilogramPerMeterCubed;
            var waterDensity = new WaterDensity(unitOfMeasure);

            Assert.Equal(expectedWaterDensityValue, waterDensity.Value);
        }

        [Fact]
        public void CanGetExpectedValueForKilogramsPerLiter()
        {
            const decimal expectedWaterDensityValue = 998207.1m;

            const Density unitOfMeasure = Density.KilogramPerLiter;
            var waterDensity = new WaterDensity(unitOfMeasure);

            Assert.Equal(expectedWaterDensityValue, waterDensity.Value);
        }
    }
}
