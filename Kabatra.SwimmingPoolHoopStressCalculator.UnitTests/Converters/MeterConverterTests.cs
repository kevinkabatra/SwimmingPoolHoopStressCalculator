namespace Kabatra.SwimmingPoolHoopStressCalculator.UnitTests.Converters
{
    using Quantities;
    using SwimmingPoolHoopStressCalculator.Converters;
    using Xunit;

    /// <summary>
    ///     Exercises converting various values to and from Meters.
    /// </summary>
    public class MeterConverterTests
    {
        [Fact]
        public void CanConverterMeterCubedToLiter()
        {
            const decimal cubicMeters = 1m;
            const decimal expectedLiters = cubicMeters * 1000m;

            var liters = MeterConverter.FromMetersTo(cubicMeters, Volume.Liter);

            Assert.Equal(expectedLiters, liters);
        }

        [Fact]
        public void CanConvertLiterToMeterCubed()
        {
            const decimal liters = 1000m;
            const decimal expectedCubicMeters = liters / 1000m;

            var cubicMeters = MeterConverter.ToMetersFrom(liters, Volume.Liter);

            Assert.Equal(expectedCubicMeters, cubicMeters);
        }
    }
}
