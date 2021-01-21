using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConcreteBeamClasses;

namespace ConcreteBeamCalculator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Object that handles functions of the form
        /// </summary>
        public Beam beam = new Beam();
        /// <summary>
        /// Tracks area of steel
        /// </summary>
        public double steelArea { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles click on calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Check for good data
            if(CheckTextboxData())
            {
                answerTextbox.Text = "Check Inputs";
                return;
            }
            ParseAllTextboxes();

            //Calculate the solution
            double answer = beam.GetMomentResistance(steelArea);
            answerTextbox.Text = $"{answer} kN*m";
        }
        /// <summary>
        /// Does a preliminary check on if the string will parse, and updates text colour to match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depthTextbox_Leave(object sender, EventArgs e)
        {
            double answer;
            TextBox box = (TextBox)sender;

            if(double.TryParse(box.Text, out answer) && answer > 0)
            {
                box.ForeColor = Color.Black;
            }
            else
            {
                box.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// Checks if the string in the textbox will parse, and within range of [0,1]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void factorTextbox_Leave(object sender, EventArgs e)
        {
            double answer;
            TextBox box = (TextBox)sender;

            if (double.TryParse(box.Text, out answer) && answer > 0 && answer <= 1)
            {
                box.ForeColor = Color.Black;
            }
            else
            {
                box.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// Checks colour of text in textboxes to determine validity of data input
        /// </summary>
        /// <returns>True if one textbox has bad data</returns>
        private bool CheckTextboxData()
        {
            bool check = widthTextbox.ForeColor == Color.Red ||
                depthTextbox.ForeColor == Color.Red ||
                steelAreaTextbox.ForeColor == Color.Red ||
                steelStrengthTextbox.ForeColor == Color.Red ||
                concreteStrengthTextbox.ForeColor == Color.Red ||
                steelFactorTextbox.ForeColor == Color.Red ||
                concreteFactorTextbox.ForeColor == Color.Red;

            return check;
        }
        /// <summary>
        /// Helper method to allow child form to update "steelArea"
        /// </summary>
        public void UpdateSteelArea(double area)
        {
            steelArea = area;
        }

        private void factorsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(factorsCheckbox.Checked == true)
            {
                concreteFactorTextbox.ReadOnly = true;
                concreteFactorTextbox.Text = "0.65";
                concreteFactorTextbox.ForeColor = Color.Black;
                steelFactorTextbox.ReadOnly = true;
                steelFactorTextbox.Text = "0.85";
                steelFactorTextbox.ForeColor = Color.Black;
            }
            else
            {
                concreteFactorTextbox.ReadOnly = false;
                steelFactorTextbox.ReadOnly = false;
            }
        }
        /// <summary>
        /// Performs the parse and updates all relevant data
        /// </summary>
        private void ParseAllTextboxes()
        {
            double buffer;

            double.TryParse(steelAreaTextbox.Text, out buffer);
            steelArea = buffer;

            double.TryParse(depthTextbox.Text, out buffer);
            beam.Depth = buffer;

            double.TryParse(widthTextbox.Text, out buffer);
            beam.Width = buffer;

            double.TryParse(steelStrengthTextbox.Text, out buffer);
            beam.SteelStrength = buffer;

            double.TryParse(concreteStrengthTextbox.Text, out buffer);
            beam.ConcreteStrength = buffer;

            double.TryParse(steelFactorTextbox.Text, out buffer);
            beam.SteelMaterialFactor = buffer;

            double.TryParse(concreteFactorTextbox.Text, out buffer);
            beam.ConcreteMeterialFactor = buffer;
        }
    }
}
