namespace Kabatra.SwimmingPoolHoopStressCalculator.UnitTests.Measures
{
    using Measures = SwimmingPoolHoopStressCalculator.Measures;
    using Xunit;
    
    /// <summary>
    ///     Exercises TensileStrength.
    /// </summary>
    public class TensileStrengthTests
    {
        [Fact]
        public void CanBuildTensileStrength()
        {
            const decimal expectedTensileStrengthValue = 100m;
            const Quantities.Pressure expectedTensileStrengthUnitOfMeasure = Quantities.Pressure.Megapascal;

            var tensileStrength = new Measures.Pressure.Builder()
                .Value(expectedTensileStrengthValue)
                .UnitOfMeasure(expectedTensileStrengthUnitOfMeasure)
                .Build();

            Assert.NotNull(tensileStrength);
            Assert.Equal(expectedTensileStrengthValue, tensileStrength.Value);
            Assert.Equal(expectedTensileStrengthUnitOfMeasure, tensileStrength.UnitOfMeasure);
        }
    }
}
