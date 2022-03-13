using static Fluid_Volume_Calculation.DataTypes.Enumerations;

namespace Fluid_Volume_Calculation.DataTypes
{
    public interface IUnitOfArea
    {
        decimal Value { get; set; }

        AreaUnit Unit { get; set; }
    }
}

