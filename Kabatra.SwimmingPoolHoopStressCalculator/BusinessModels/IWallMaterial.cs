namespace Kabatra.SwimmingPoolHoopStressCalculator.BusinessModels
{
    using Measures;

    /// <summary>
    ///     Interface for the various materials that a wall call be made from.
    /// </summary>
    public interface IWallMaterial
    {
        /// <summary>
        ///     Depth of how thick the material is.
        /// </summary>
        Length Thickness { get; }

        /// <summary>
        ///     Tensile strength is the capacity of a material or structure to withstand loads tending to elongate,
        /// as opposed to compressive strength, which withstands loads tending to reduce size.
        /// </summary>
        /// <see href="https://en.wikipedia.org/wiki/Ultimate_tensile_strength"/>
        Pressure TensileStrength { get; }
    } 
}
