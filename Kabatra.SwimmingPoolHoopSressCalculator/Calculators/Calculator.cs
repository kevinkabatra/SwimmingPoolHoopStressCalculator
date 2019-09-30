namespace Kabatra.SwimmingPoolHoopStressCalculator.Calculators
{
    using BusinessModels;
    using Constants;
    using Converters;
    using Measures;

    /// <summary>
    ///     Calculates the maximum water depth that a circular swimming pool could
    /// hold based on the material that the wall is made out of, this is determined using
    /// the Hoop Stress formula.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        ///     Handles the calculation.
        /// </summary>
        /// <param name="wallMaterial">The material that the wall is made out of.</param>
        /// <param name="radius">The radius of the pool.</param>
        /// <param name="outputUnitOfMeasure">The unit of measure that the output value should be formatted in.</param>
        /// <returns></returns>
        public static decimal CalculateMaximumWaterDepth(IWallMaterial wallMaterial, Length radius, Quantities.Length outputUnitOfMeasure = Quantities.Length.Meter)
        {
            var maximumInternalPressureWallCanWithstand = GetMaximumInternalPressureWallCanWithstand(wallMaterial);
            var internalPressure = GetInternalPressure(radius);

            var maximumWaterDepthInMeters = maximumInternalPressureWallCanWithstand / internalPressure;
            var convertedMaximumWaterDepth = MeterConverter.FromMetersTo(maximumWaterDepthInMeters, outputUnitOfMeasure);

            return convertedMaximumWaterDepth;
        }

        /// <summary>
        ///     Multiplies the wall's thickness by its tensile strength to find the maximum
        /// internal pressure that it can withstand, measured in Kilograms per second square.
        /// </summary>
        /// <param name="wallMaterial">The material that the wall is made of.</param>
        /// <returns></returns>
        private static decimal GetMaximumInternalPressureWallCanWithstand(IWallMaterial wallMaterial)
        {
            var wallMaterialThicknessInMeters = MeterConverter.ToMetersFrom(
                wallMaterial.Thickness.Value,
                wallMaterial.Thickness.UnitOfMeasure
            );

            var wallMaterialTensileStrengthInPascals = PascalConverter.ToPascalFrom(
                wallMaterial.TensileStrength.Value,
                wallMaterial.TensileStrength.UnitOfMeasure
            );

            var result = wallMaterialThicknessInMeters * wallMaterialTensileStrengthInPascals;
            return result;
        }

        /// <summary>
        ///     Multiplies the constant density of water and gravity of earth by the radius of the
        /// pool to find the total internal pressure, measured in Pascals.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        private static decimal GetInternalPressure(Length radius)
        {
            var waterDensity = new WaterDensity();
            var gravity = new Gravity();
            var radiusInMeters = MeterConverter.ToMetersFrom(radius.Value, radius.UnitOfMeasure);

            var result = waterDensity.Value * gravity.Value * radiusInMeters;
            return result;
        }
    }
}
