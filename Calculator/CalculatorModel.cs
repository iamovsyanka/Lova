using System;

namespace Calculator
{
    public class CalculatorModel
    {
        private int? firstNumber;
        private int? secondNumber;
        private char? sign;
        private double? result;
        private string display;

        public double? Result
        {
            get
            {
                if (!result.HasValue)
                {
                    throw new InvalidOperationException();
                }
                return result;
            }
        }

        public string Display => display;

        public CalculatorModel()
        {
            Clear();
        }

        public bool CanDoClear() => true;

        public bool CanDoSign() => firstNumber.HasValue && !sign.HasValue;

        public bool CanDoNumber() => !result.HasValue;

        public bool CanDoEquals() => (firstNumber.HasValue && sign.HasValue && secondNumber.HasValue && !result.HasValue);

        public void Plus() => Dosign('+');

        public void Minus() => Dosign('-');

        public void Times() => Dosign('*');

        public void Over() => Dosign('/');

        private void Dosign(char o)
        {
            if (!CanDoSign())
            {
                throw new InvalidOperationException();
            }

            sign = o;
            display += $" {o} ";
        }

        public void Number(int num)
        {
            if (!CanDoNumber())
            {
                throw new InvalidOperationException();
            }

            if ((num < 0) || (num > 9))
            {
                throw new ArgumentException();
            }

            if (!sign.HasValue)
            {
                if (!firstNumber.HasValue)
                {
                    firstNumber = num;
                    display = num.ToString();
                }
                else
                {
                    firstNumber = firstNumber * 10 + num;
                    display += num;
                }
            }
            else
            {
                secondNumber = !secondNumber.HasValue ? num : secondNumber * 10 + num;

                display += num;
            }
        }

        public void Equals()
        {
            if (!CanDoEquals())
            {
                throw new InvalidOperationException();
            }

            switch (sign)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = (double)firstNumber / (double)secondNumber;
                    break;
            }

            display = result.ToString();
        }

        public void Clear()
        {
            firstNumber = null;
            sign = null;
            secondNumber = null;
            result = null;
            display = "0";
        }
    }
}
