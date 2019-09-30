namespace Kabatra.SwimmingPoolHoopStressCalculator.BusinessModels
{
    /// <summary>
    ///     Aluminum foil as a wall material.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Aluminium_foil"/>
    /// <see href="http://asm.matweb.com/search/SpecificMaterial.asp?bassnum=MA5052H19"/>
    public class AluminumFoil : IWallMaterial
    {
        public Measures.Length Thickness => new Measures.Length.Builder()
            .UnitOfMeasure(Quantities.Length.Millimeter)
            .Value(0.02m)
            .Build();
     
        public Measures.Pressure TensileStrength => new Measures.Pressure.Builder()
            .UnitOfMeasure(Quantities.Pressure.Megapascal)
            .Value(330m)
            .Build();
    }
}
