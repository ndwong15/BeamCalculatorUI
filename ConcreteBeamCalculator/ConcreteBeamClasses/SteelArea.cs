using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteBeamClasses
{
    public class SteelArea
    {
        private List<SteelBar> BarList { get; set; }

        /// <summary>
        /// Indexer for bar ID numbers
        /// </summary>
        /// <param name="id">ID Number</param>
        /// <returns>SteelBar object with the specified ID number</returns>
        public SteelBar this[int id]
        {
            get { return BarList.Find(a => a.Identifier == id); }
        }
        /// <summary>
        /// Empty Constructor with all quantities default 0.
        /// </summary>
        public SteelArea()
        {
            AddBarsToList();
        }
        /// <summary>
        /// Sets initial quantities to provided values
        /// </summary>
        /// <param name="barCount">Array of 8 integers representing bars of 10, 15, 20, 25, 30, 35, 45, 55 respectively</param>
        public SteelArea(int[] barCount)
        {
            SetBarQuantities(barCount);
        }
        /// <summary>
        /// Calculates area based on the bar numbers
        /// </summary>
        /// <returns>A double representing steel area in mm^2</returns>
        public double GetTotalArea()
        {
            double area = 0;

            BarList.ForEach(a => area += a.GetTotalBarArea() );

            return area;
        }
        /// <summary>
        /// Adds the standard 8 sizes of metric rebar to the list
        /// </summary>
        private void AddBarsToList()
        {
            BarList = new List<SteelBar>(10);
            BarList.Add(new SteelBar(10, 100) );
            BarList.Add(new SteelBar(15, 200) );
            BarList.Add(new SteelBar(20, 300) );
            BarList.Add(new SteelBar(25, 500) );
            BarList.Add(new SteelBar(30, 700) );
            BarList.Add(new SteelBar(35, 1000));
            BarList.Add(new SteelBar(45, 1500));
            BarList.Add(new SteelBar(55, 2500));
        }
        /// <summary>
        /// Uses array to set every bar quantity
        /// </summary>
        /// <param name="barCount">Array of 8 integers representing bars of 10, 15, 20, 25, 30, 35, 45, 55 respectively</param>
        public void SetBarQuantities(int[] barCount)
        {
            //Error Check
            if (barCount.Length != 8)
            {
                throw new Exception("Incorrect Array Size");
            }
            for (int i = 0; i < barCount.Length; i++)
            {
                if (barCount[i] < 0) throw new Exception("Array Contains Negative Numbers");
            }

            //Create the object
            AddBarsToList();
            for (int i = 0; i < barCount.Length; i++)
            {
                BarList[i].Quantity = barCount[i];
            }
        }
    }
}
