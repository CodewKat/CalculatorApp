using System;
namespace CalculatorApp
{
    public class Calculator : CalculatorBase
    {
        public Calculator()
        {
        }


        public override double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public override double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }


        public override double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }


        public override double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }


}

