namespace Kabatra.SwimmingPoolHoopStressCalculator.UnitTests.Calculators
{
    using BusinessModels;
    using Quantities;
    using SwimmingPoolHoopStressCalculator.Calculators;
    using Measures = SwimmingPoolHoopStressCalculator.Measures;
    using Xunit;

    /// <summary>
    ///     Exercises the Calculator to ensure that the correct amounts are being returned.
    /// </summary>
    public class CalculatorTests
    {
        [Fact]
        public void CanFindExpectedMaximumWaterDepthForSwimmingPoolWithAluminumFoilWall()
        {
            var wallMaterial = new AluminumFoil();
            var poolRadius = new Measures.Length.Builder()
                .UnitOfMeasure(Length.Feet)
                .Value(15m)
                .Build();

            var expectedMaximumWaterDepthInInches = new Measures.Length.Builder()
                .UnitOfMeasure(Length.Inches)
                .Value(5.8058724669268443393792217779m)
                .Build();

            var maximumWaterDepthInInches = Calculator.CalculateMaximumWaterDepth(
                wallMaterial,
                poolRadius,
                expectedMaximumWaterDepthInInches.UnitOfMeasure
            );

            Assert.Equal(expectedMaximumWaterDepthInInches.Value, maximumWaterDepthInInches);
        }
    }
}
