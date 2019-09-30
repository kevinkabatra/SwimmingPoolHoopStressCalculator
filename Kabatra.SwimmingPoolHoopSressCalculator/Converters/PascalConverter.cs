namespace Kabatra.SwimmingPoolHoopStressCalculator.Converters
{
    using System;
    using Quantities;

    /// <summary>
    ///     Handles converting to and from pascal(s).
    /// </summary>
    public class PascalConverter : QuantityBaseUnitConverter
    {
        /// <summary>
        ///     Converts a given measurement of a quantity of Pressure to pascal(s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="unitOfMeasure">The unit of measure that this value is measured by.</param>
        /// <returns></returns>
        public static decimal ToPascalFrom(decimal value, Pressure unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case Pressure.Pascal:
                    return value;
                case Pressure.Megapascal:
                    return FromMegapascalToPascal(value);
                default:
                    throw new NotSupportedException(string.Format(NotSupportedErrorMessage, unitOfMeasure));
            }
        }

        /// <summary>
        ///     Handles conversion of a value from megapascals to pascals.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromMegapascalToPascal(decimal value)
        {
            return ChangeByBase10(value, 6);
        }
    }
}
