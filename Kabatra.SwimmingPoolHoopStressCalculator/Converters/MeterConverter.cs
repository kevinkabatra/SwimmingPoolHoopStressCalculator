namespace Kabatra.SwimmingPoolHoopStressCalculator.Converters
{
    using System;
    using Quantities;

    /// <summary>
    ///     Handles converting to and from meter(s).
    /// </summary>
    public class MeterConverter : QuantityBaseUnitConverter
    {
        /// <summary>
        ///     Converts a given measurement of a quantity of Length to meter(s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="unitOfMeasure">The unit of measure that this value is measured by.</param>
        /// <returns></returns>
        public static decimal ToMetersFrom(decimal value, Length unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case Length.Millimeter:
                    return FromMillimeterTosMeter(value);
                case Length.Meter:
                    return value;
                case Length.Inches:
                    return FromInchesToMeter(value);
                case Length.Feet:
                    return FromFeetToMeters(value);
                default:
                    throw new NotSupportedException(string.Format(NotSupportedErrorMessage, unitOfMeasure));
            }
        }

        /// <summary>
        ///     Converts a given measurement of a quantity of Volume to meter(s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="unitOfMeasure">The unit of measure that this value is measured by.</param>
        /// <returns></returns>
        public static decimal ToMetersFrom(decimal value, Volume unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case Volume.Liter:
                    return FromLiterToMetersCubed(value);
                default:
                    throw new NotSupportedException(string.Format(NotSupportedErrorMessage, unitOfMeasure));
            }
        }

        /// <summary>
        ///     Converts a given measurement of meter(s) to a quantity of Length.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="unitOfMeasure">The unit of measure that this value is measured by.</param>
        /// <returns></returns>
        public static decimal FromMetersTo(decimal value, Length unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case Length.Millimeter:
                    return FromMetersToMillimeter(value);
                case Length.Meter:
                    return value;
                case Length.Inches:
                    return FromMetersToInches(value);
                case Length.Feet:
                    return FromMetersToFeet(value);
                default:
                    throw new NotSupportedException(string.Format(NotSupportedErrorMessage, unitOfMeasure));
            }
        }

        /// <summary>
        ///     Converts a given measurement of meter(s) to a quantity of Volume.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="unitOfMeasure">The unit of measure that this value is measured by.</param>
        /// <returns></returns>
        public static decimal FromMetersTo(decimal value, Volume unitOfMeasure)
        {
            switch (unitOfMeasure)
            {
                case Volume.Liter:
                    return FromMetersCubedToLiter(value);
                default:
                    throw new NotSupportedException(string.Format(NotSupportedErrorMessage, unitOfMeasure));
            }
        }

        /// <summary>
        ///     Converts a given measurement of inch(es) to meter(s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromInchesToMeter(decimal value)
        {
            var result = value / 39.37m;
            return result;
        }

        /// <summary>
        ///     Converts a given measurement of feet to meter(s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromFeetToMeters(decimal value)
        {
            var result = value / 3.281m;
            return result;
        }

        /// <summary>
        ///     Converts a given measurement of meter(s) to feet.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromMetersToFeet(decimal value)
        {
            var result = value * 3.281m;
            return result;
        }

        /// <summary>
        ///     Converts a given measurement of meter(s) to inch(es).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromMetersToInches(decimal value)
        {
            var result = value * 39.37m;
            return result;
        }

        /// <summary>
        ///     Handles conversion of a value from meters cubed to liters.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromMetersCubedToLiter(decimal value)
        {
            return ChangeByBase10(value, 3);
        }

        /// <summary>
        ///     Handles conversion of a value from liters to meters cubed.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromLiterToMetersCubed(decimal value)
        {
            return ChangeByBase10(value, -3);
        }

        /// <summary>
        ///     Handles conversion from millimeter to meter.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromMillimeterTosMeter(decimal value)
        {
            return ChangeByBase10(value, -3);
        }

        /// <summary>
        ///     Handles conversion from meter to millimeter.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static decimal FromMetersToMillimeter(decimal value)
        {
            return ChangeByBase10(value, 3);
        }
    }
}
