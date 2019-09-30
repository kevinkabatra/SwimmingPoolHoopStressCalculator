namespace Kabatra.SwimmingPoolHoopStressCalculator.Measures
{
    /// <summary>
    ///     The measurement of pressure.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Pressure"/>
    public class Pressure
    {
        protected Pressure()
        {
        }

        public Quantities.Pressure UnitOfMeasure { get; private set; }
        public decimal Value { get; private set; }

        /// <summary>
        ///     Builder class.
        /// </summary>
        public class Builder
        {
            protected readonly Pressure Pressure;

            public Builder()
            {
                Pressure = new Pressure();
            }

            /// <summary>
            ///     Returns the built Pressure object.
            /// </summary>
            /// <returns></returns>
            public Pressure Build()
            {
                return Pressure;
            }

            /// <summary>
            ///     Setter.
            /// </summary>
            /// <param name="unitOfMeasure">A SI unit that will measure the quantity of Pressure.</param>
            /// <returns></returns>
            public Builder UnitOfMeasure(Quantities.Pressure unitOfMeasure)
            {
                Pressure.UnitOfMeasure = unitOfMeasure;
                return this;
            }

            /// <summary>
            ///     Setter.
            /// </summary>
            /// <param name="value">The decimal amount that relates to the value measured.</param>
            /// <returns></returns>
            public Builder Value(decimal value)
            {
                Pressure.Value = value;
                return this;
            }
        }
    }
}
