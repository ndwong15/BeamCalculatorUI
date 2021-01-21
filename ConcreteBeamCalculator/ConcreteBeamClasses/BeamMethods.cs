using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteBeamClasses
{
    public partial class Beam
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Beam()
        {
            AreaOfSteel = new SteelArea();
        }
        /// <summary>
        /// Calculates Moment of Resistance for the beam
        /// </summary>
        /// <returns>A double representing strength in kilonewton Metres(kN*m)</returns>
        public double GetMomentResistance()
        {
            double resistance;  //Stores Moment Resistance value
            double steelDepth = Depth - 35 - 10; //Units are Millimetres
            double steelArea = AreaOfSteel.GetTotalArea();

            resistance = steelArea * SteelMaterialFactor * SteelStrength *
                (steelDepth -   (steelArea * SteelMaterialFactor * SteelStrength)/
                                (2 * alpha1 * ConcreteMeterialFactor * ConcreteStrength * Width));

            return resistance;
        }
        /// <summary>
        /// Calculates Moment of Resistance for the beam, area override
        /// </summary>
        /// <param name="area">Area of steel in square millimetres (mm^2)</param>
        /// <returns>A double representing strength in Kilonewton Metres(kN*m)</returns>
        public double GetMomentResistance(double area)
        {
            double resistance;  //Stores Moment Resistance value
            double steelDepth = Depth - 35 - 10; //Units are Millimetres
            double steelArea = area;

            resistance = steelArea * SteelMaterialFactor * SteelStrength *
                (steelDepth - (steelArea * SteelMaterialFactor * SteelStrength) /
                                (2 * alpha1 * ConcreteMeterialFactor * ConcreteStrength * Width));

            return resistance;
        }
        /// <summary>
        /// Allows user to check the value of the field alpha1
        /// </summary>
        /// <returns>alpha1 field, double</returns>
        public double ReturnAlpha1()
        {
            return alpha1;
        }
        /// <summary>
        /// Allows user to check the value of the field beta1
        /// </summary>
        /// <returns>beta1 field, double</returns>
        public double ReturnBeta1()
        {
            return beta1;
        }
    }
}
