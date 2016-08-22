﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Operations
    {

        bool validateNumbers(string number1, string number2)
        {
            double r=0.0;
            bool one = double.TryParse(number1 , out r);
            bool two = double.TryParse(number2 , out r);

            return one && two;
        }
        /* addition subtraction multiplication division*/

        public string multiplication(string First_number, string Second_number)
        {
            if (validateNumbers(First_number, Second_number))
            {
                string result = Convert.ToString(double.Parse(First_number) * double.Parse(Second_number));
                return result;
            }
            else
                return "Invalid number ! ";

        }
    }
}