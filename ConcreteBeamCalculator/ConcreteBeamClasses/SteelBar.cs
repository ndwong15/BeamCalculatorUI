using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteBeamClasses
{
    public class SteelBar
    {
        /// <summary>
        /// Area in mm^2
        /// </summary>
        public double Area { get; }
        /// <summary>
        /// Integer representing the bar type
        /// </summary>
        public int Identifier { get; }

        private int _quantity;
        /// <summary>
        /// Quantity of bars, must be non-negative.
        /// </summary>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value >= 0)
                {
                    _quantity = value;
                }
                else throw new Exception("Invalid Quantity");
            }
        }
        /// <summary>
        /// Creates new instance with specified bar area
        /// </summary>
        /// <param name="Id">Bar ID</param>
        /// <param name="area">Area in mm^2</param>
        public SteelBar(int id, double area)
        {
            if (area > 0)
            {
                Area = area;
            }
            else
            {
                throw new Exception("Area Not Valid");
            }

            Quantity = 0;
            Identifier = id;
        }
        /// <summary>
        /// Creates new instance with specified bar area and quantity
        /// </summary>
        /// <param name="id">Bar Identifier</param>
        /// <param name="area">Area in mm^2</param>
        /// <param name="count">Quantity of Bars</param>
        public SteelBar(int id, double area, int count)
        {
            if (area > 0)
            {
                Area = area;
            }
            else
            {
                throw new Exception("Area Not Valid");
            }

            Identifier = id;
            Quantity = count;
        }
        /// <summary>
        /// Calculates total area based on current quantity
        /// </summary>
        /// <returns>A double representing total steel area in mm^2</returns>
        public double GetTotalBarArea()
        {
            double totalArea = Quantity * Area;
            return totalArea;
        }
    }
}
