using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalclulatorServiceClient.CalculatorServiceReference;

namespace CalclulatorServiceClient
{
    public partial class Main : Form
    {
        MyCalculatorClass myCalculator;

        public Main()
        {
            InitializeComponent();

            myCalculator = new MyCalculatorClass();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            tbResult.Text = myCalculator.Calculate(tbNumber1.Text, tbNumber2.Text, cbOperations.Text);
        }

        
    }
    class MyCalculatorClass
    {
        MyCalculatorServiceClient calculator;
        Int32 number1;
        Int32 number2;

        public MyCalculatorClass()
        {
            calculator = new MyCalculatorServiceClient();
            number1 = 0;
            number2 = 0;
        }

        private Boolean ConvertNumbers(String txtNumber1, String txtNumber2)
        {
            try
            {
                number1 = Convert.ToInt32(txtNumber1);
                number2 = Convert.ToInt32(txtNumber2);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public String Calculate(String txtNumber1, String txtNumber2, String txtOperation)
        {
            
            if (!ConvertNumbers( txtNumber1, txtNumber2))
                return "Bad numbers!";

            Int32 result = 0;

            switch (txtOperation)
            {
            case "Add":
                result = calculator.Add(number1, number2);
                break;
            case "Subtract":
                result = calculator.Subtract(number1, number2);
                break;
            case "Multiply":
                result = calculator.Multiply(number1, number2);
                break;
            }

            return result.ToString();
        }

    }
}
