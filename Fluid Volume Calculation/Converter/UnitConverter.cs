﻿using Fluid_Volume_Calculation.Models;

namespace Fluid_Volume_Calculation.Converter
{
    public static class UnitConverter
    {
        /// <summary>Convers cubic feet to cubic metre.</summary>
        /// <param name="volumeInCubicFeet">The volume in cubic feet.</param>
        /// <returns></returns>
        public static CubicMetre CubicFeetToCubicMetre(CubicFeet volumeInCubicFeet)
        {
            return new CubicMetre(volumeInCubicFeet.Value * 0.3048m * 0.3048m * 0.3048m);
        }

        /// <summary>Converts cubic the feet to barrels.</summary>
        /// <param name="volumeInCubicFeet">The volume in cubic feet.</param>
        /// <returns></returns>
        public static OilBarrel CubicFeetToBarrels(CubicFeet volumeInCubicFeet)
        {
            return new OilBarrel(volumeInCubicFeet.Value * 0.178107607m);
        }
    }
}
