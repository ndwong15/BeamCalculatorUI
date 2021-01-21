using System;

namespace ConcreteBeamClasses
{
    /// <summary>
    /// Class represents a basic singularly reinforced rectangular concrete beam
    /// </summary>
    public partial class Beam
    {
        public SteelArea AreaOfSteel{ get; set; }
        public double LoadFactor { get; set; }
        public double SteelMaterialFactor { get; set; }
        public double ConcreteMeterialFactor { get; set; }
        /// <summary>
        /// Units are Megapascals(MPa) aka, Newton per Millimetre squared(N/mm^2)
        /// </summary>
        public double SteelStrength { get; set; }
        /// <summary>
        /// Units are Megapascals(MPa) aka, Newton per Millimetre squared(N/mm^2)
        /// </summary>
        public double ConcreteStrength
        {
            get { return concreteStrength; }
            set 
            { 
                concreteStrength = value;
                alpha1 = 0.85 - 0.0015 * concreteStrength;
                beta1 = 0.97 - 0.0025 * concreteStrength;

                //Formulas from Building Code of Canada
                if (alpha1 < 0.67) alpha1 = 0.67;
                if (beta1 < 0.67) beta1 = 0.67;
            } 
        }
        /// <summary>
        /// Units in MPa
        /// </summary>
        private double concreteStrength; 
        /// <summary>
        /// Units are milimetres(mm)
        /// </summary>
        public double Depth { get; set; }
        /// <summary>
        /// Units are milimetres(mm)
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Conversion factor for stress in concrete block
        /// </summary>
        private double alpha1;
        /// <summary>
        /// Conversion factor for stress in concrete block
        /// </summary>
        private double beta1;
    }
}
