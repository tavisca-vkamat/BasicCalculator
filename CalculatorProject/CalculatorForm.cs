using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalculatorForm : Form
    {
        static int flagForOpearator = 0;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonOfClear_Click(object sender, EventArgs e)
        {
            flagForOpearator = 0;
            inputBox1.Text = "";  
            outputBox.Text = "";
        }

        private void buttonOfAddition_Click(object sender, EventArgs e)
        {
            if (flagForOpearator == 0)
            {
                inputBox1.Text = inputBox1.Text + "+";
                flagForOpearator = 1;
            }
            
        }

        private void buttonOfSubtraction_Click(object sender, EventArgs e)
        {
            if (flagForOpearator == 0)
            {
                inputBox1.Text = inputBox1.Text + "-";
                flagForOpearator = 1;
            }
        }

        private void buttonOfMultiplication_Click(object sender, EventArgs e)
        {
            if (flagForOpearator == 0)
            {
                inputBox1.Text = inputBox1.Text + "*";
                flagForOpearator = 1;
            }
        }

        private void buttonOfDivide_Click(object sender, EventArgs e)
        {
            if (flagForOpearator == 0)
            {
                inputBox1.Text = inputBox1.Text + "/";
                flagForOpearator = 1;
            }
        }

        private void buttonOfOne_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "1";
        }

        private void buttonOfTwo_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "2";
        }

        private void buttonOfThree_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "3";
        }
        
        private void buttonOfFour_Click(object sender, EventArgs e)
        {

            inputBox1.Text = inputBox1.Text + "4";
        }

        private void buttonOfFive_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "5";
        }

        private void buttonOfSix_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "6";
        }

        private void buttonOfSeven_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "7";
        }

        private void buttonOfEight_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "8";
        }

        private void buttonOfNine_Click(object sender, EventArgs e)
        {
            inputBox1.Text = inputBox1.Text + "9";
        }

        private void buttonOfZero_Click(object sender, EventArgs e)
        {

            inputBox1.Text = inputBox1.Text + "0";
        }

        private void buttonOfEquals_Click(object sender, EventArgs e)
        {
            /* get string of inputBox1 and do opeartion*/


        }


        private void inputBox1KeyPress()
        {

        }
    }
}
