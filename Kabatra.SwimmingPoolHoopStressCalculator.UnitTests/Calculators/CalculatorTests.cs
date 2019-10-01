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

            var expectedMaximumWaterDepthInInches = new Measures.Length.Builder()
                .UnitOfMeasure(Length.Inches)
                .Value(5.8058724669268443393792217779m)
                .Build();

            var maximumWaterDepthInInches = GetExpectedMaximumWaterDepthInInches(wallMaterial, expectedMaximumWaterDepthInInches.UnitOfMeasure);

            Assert.Equal(expectedMaximumWaterDepthInInches.Value, maximumWaterDepthInInches);
        }

        [Fact]
        public void CanFindExpectedMaximumWaterDepthForSwimmingPoolWithAmericanEasterWhitePineWoodWall()
        {
            var wallMaterial = new AmericanEasternWhitePineWood();

            var expectedMaximumWaterDepthInInches = new Measures.Length.Builder()
                .UnitOfMeasure(Length.Inches)
                .Value(46.922099508725968522010936389m)
                .Build();

            var maximumWaterDepthInInches = GetExpectedMaximumWaterDepthInInches(wallMaterial, expectedMaximumWaterDepthInInches.UnitOfMeasure);

            Assert.Equal(expectedMaximumWaterDepthInInches.Value, maximumWaterDepthInInches);
        }

        /// <summary>
        ///     Gets the Pool Radius to use for testing.
        /// </summary>
        /// <returns></returns>
        private static Measures.Length GetPoolRadiusTestFixture()
        {
            var poolRadius = new Measures.Length.Builder()
                .UnitOfMeasure(Length.Feet)
                .Value(15m)
                .Build();

            return poolRadius;
        }

        /// <summary>
        ///     Gets the expected water depth 
        /// </summary>
        /// <returns></returns>
        private static decimal GetExpectedMaximumWaterDepthInInches(IWallMaterial wallMaterial, Length unitOfMeasure)
        {
            var maximumWaterDepthInInches = Calculator.CalculateMaximumWaterDepth(
                wallMaterial,
                GetPoolRadiusTestFixture(),
                unitOfMeasure
            );

            return maximumWaterDepthInInches;
        }
    }

}
