using static Fluid_Volume_Calculation.DataTypes.Enumerations;

namespace Fluid_Volume_Calculation.DataTypes
{
    public interface IUnitOfVolume
    {
        decimal Value { get; set; }
        VolumeUnit Unit { get; set; }
    }
}
