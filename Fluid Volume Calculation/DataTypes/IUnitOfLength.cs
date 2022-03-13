using static Fluid_Volume_Calculation.DataTypes.Enumerations;

namespace Fluid_Volume_Calculation.DataTypes
{
    public interface IUnitOfLength
    {
        decimal Value { get; set; }

        LengthUnit Unit { get; set; }
    }
}
