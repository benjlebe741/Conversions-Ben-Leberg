using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions_Ben_Leberg
{
    public partial class Form1 : Form
    {
        double inputToConvert;
        double[] inCm_CmFt_MeterYards_KmMiles = new double[] { 2.54, 30.48, 0.91, 1.6 };
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string inputNumber = inputNumberTextbox.Text;
            inputToConvert = Convert.ToDouble(inputTextbox.Text);
            outputLabel.Text = $"ANSWER: {ConvertInputToMeasuringSystem(inCm_CmFt_MeterYards_KmMiles[Convert.ToInt32(inputNumber) - 1])}";
           

            
        }

        double ConvertInputToMeasuringSystem(double multiplier) 
        {
            return inputToConvert * multiplier;
        }

    }
}
