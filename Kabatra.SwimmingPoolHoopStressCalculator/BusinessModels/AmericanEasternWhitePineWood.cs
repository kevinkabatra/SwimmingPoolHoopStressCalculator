namespace Kabatra.SwimmingPoolHoopStressCalculator.BusinessModels
{
    /// <summary>
    ///     American Eastern White Pinewood as a wall material.
    /// </summary>
    /// <remarks>
    ///     Assuming that the wall is set up Perpendicular to the grain of the wood, axial
    /// strength is much higher.
    /// </remarks>
    /// <see href="http://www.matweb.com/search/datasheet_print.aspx?matguid=1bec7114d2524b63826044c3cc6c344c"/>
    public class AmericanEasternWhitePineWood : IWallMaterial
    {
        public Measures.Length Thickness => new Measures.Length.Builder()
            .UnitOfMeasure(Quantities.Length.Inches)
            .Value(1m)
            .Build();

        public Measures.Pressure TensileStrength => new Measures.Pressure.Builder()
            .UnitOfMeasure(Quantities.Pressure.Megapascal)
            .Value(2.10m)
            .Build();
    }
}
