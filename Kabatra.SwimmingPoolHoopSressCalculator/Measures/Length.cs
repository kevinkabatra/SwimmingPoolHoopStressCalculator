namespace Kabatra.SwimmingPoolHoopStressCalculator.Measures
{
    /// <summary>
    ///     The measurement of length.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Length"/>
    public class Length
    {
        protected Length()
        {
        }

        public Quantities.Length UnitOfMeasure { get; private set; }
        public decimal Value { get; private set; }

        /// <summary>
        ///     Builder class.
        /// </summary>
        public class Builder
        {
            protected readonly Length Length;

            public Builder()
            {
                Length = new Length();
            }

            /// <summary>
            ///     Returns the built Length object.
            /// </summary>
            /// <returns></returns>
            public Length Build()
            {
                return Length;
            }

            /// <summary>
            ///     Setter.
            /// </summary>
            /// <param name="unitOfMeasure">A SI unit that will measure the quantity of Length.</param>
            /// <returns></returns>
            public Builder UnitOfMeasure(Quantities.Length unitOfMeasure)
            {
                Length.UnitOfMeasure = unitOfMeasure;
                return this;
            }

            /// <summary>
            ///     Setter.
            /// </summary>
            /// <param name="value">The decimal amount that relates to the value measured.</param>
            /// <returns></returns>
            public Builder Value(decimal value)
            {
                Length.Value = value;
                return this;
            }
        }
    }
}
