using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public double FirstNumber { set; get; }
        public double SecondNumber { set; get; }

        public double Add()
        {
            return FirstNumber + SecondNumber;
        }

        public double Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public double Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public double Division()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
