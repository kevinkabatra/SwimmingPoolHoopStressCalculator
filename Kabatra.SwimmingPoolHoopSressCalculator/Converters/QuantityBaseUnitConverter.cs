namespace Kabatra.SwimmingPoolHoopStressCalculator.Converters
{
    using System;

    /// <summary>
    ///     Abstract class that supports finding values based on the metric system.
    /// </summary>
    public abstract class QuantityBaseUnitConverter
    {
        protected const string NotSupportedErrorMessage = "The specified UnitOfMeasure: {0} is not yet supported.";

        /// <summary>
        ///     Changes a quantity by a given number of prefixes.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="numberOfPositionsToMove">The number of decimal places / prefixes to move. Positive to increase prefix, negative to decrease.</param>
        /// <returns></returns>
        protected static decimal ChangeByBase10(decimal value, int numberOfPositionsToMove)
        {
            decimal result;

            if (numberOfPositionsToMove == 0)
            {
                return value;
            }

            if (numberOfPositionsToMove > 0)
            {
                var factor = Math.Pow(10, numberOfPositionsToMove);
                result = value * Convert.ToDecimal(factor);
            }
            else
            {
                var divisor = Math.Pow(10, Math.Abs(numberOfPositionsToMove));
                result = value / Convert.ToDecimal(divisor);
            }

            return result;
        }
    }
}
