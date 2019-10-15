using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Home : Form
    {
        Calculator calculator = new Calculator();

        public Home()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Add().ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Subtract().ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Multiply().ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Division().ToString();
        }
    }
}
