using System;

namespace cv9
{
    public class Calculator
    {
        private State _state;
        private enum State
        {
            Number1,
            Number2,
            Operation,
            Result
        };
        private Operation _operation;
        private enum Operation
        {
            Plus,
            Minus,
            Multiply,
            Divide,
            Power
        };
        public String Display { get; set; }
        public String Memory { get; set; }
        private string number1;
        private string number2;

        public Calculator()
        {
            this._state = State.Number1;
            this.Display = "0";
            this.Memory = "M";
            this.number1 = "0";
            this.number2 = "0";
        }

        public void Button(string button)
        {
            string number = "";

            switch (button)
            {
                case "+":
                    this._state = State.Operation;
                    this._operation = Operation.Plus;
                    break;
                case "−":
                    this._state = State.Operation;
                    this._operation = Operation.Minus;
                    break;
                case "×":
                    this._state = State.Operation;
                    this._operation = Operation.Multiply;
                    break;
                case "÷":
                    this._state = State.Operation;
                    this._operation = Operation.Divide;
                    break;
                case "x²":
                    this._state = State.Result;
                    this._operation = Operation.Power;
                    break;
                case "+/-":
                    if (this._state == State.Number1)
                    {
                        this.number1 = (Convert.ToDouble(this.number1) * -1).ToString();
                    }
                    else if (this._state == State.Number2)
                    {
                        this.number2 = (Convert.ToDouble(this.number2) * -1).ToString();
                    }
                    break;
                case ",":
                    number = button;
                    break;
                case "DEL":
                    if (this._state == State.Number1 && !string.IsNullOrEmpty(this.number1))
                    {
                        this.number1 = this.number1.Substring(0, this.number1.Length - 1);
                        this.Display = this.number1;
                    }
                    else if (this._state == State.Number2 && !string.IsNullOrEmpty(this.number2))
                    {
                        this.number2 = this.number1.Substring(0, this.number2.Length - 1);
                        this.Display = this.number2;
                    }
                    else
                    {
                        this.number1 = "0";
                    }
                    break;
                case "C":
                    this._state = State.Number1;
                    this.Memory = this.Display;
                    this.Display = "0";
                    this.number1 = "0";
                    this.number2 = "0";
                    break;
                case "=":
                    this._state = State.Result;
                    this.Display = this.Result();
                    this.Memory = this.Display;
                    this.number1 = "0";
                    this.number2 = "0";
                    break;
                default:
                    if (this._state == State.Number1 && this.number1 == "0")
                    {
                        this.number1 = "";
                    }
                    else if (this._state == State.Number2 && this.number2 == "0")
                    {
                        this.number2 = "";
                    }
                    number = button;
                    break;
            }

            switch (this._state)
            {
                case State.Number1:
                    this.number1 += number;
                    this.Display = this.number1;
                    break;
                case State.Number2:
                    this.number2 += number;
                    this.Display = this.number2;
                    break;
                case State.Operation:
                    this._state = State.Number2;
                    break;
                case State.Result:
                    this._state = State.Number1;
                    this.number1 = this.Display;
                    break;
            }
        }

        private string Result()
        {
            double number1;
            double number2 = 0;

            try
            {
                switch (this._operation)
                {
                    case Operation.Power:
                        number1 = Convert.ToDouble(this.number1);
                        break;
                    default:
                        number1 = Convert.ToDouble(this.number1);
                        number2 = Convert.ToDouble(this.number2);
                        break;
                }

                switch (this._operation)
                {
                    case Operation.Plus:
                        return Convert.ToString(number1 + number2);
                    case Operation.Minus:
                        return Convert.ToString(number1 - number2);
                    case Operation.Multiply:
                        return Convert.ToString(number1 * number2);
                    case Operation.Divide:
                        if (number2 == 0)
                        {
                            return "Math ERROR";
                        }
                        return Convert.ToString(number1 / number2);
                    case Operation.Power:
                        return Convert.ToString(number1 * number1);
                    default:
                        return "0";
                }
            }
            catch (Exception e)
            {
                return "Math ERROR";
            }
        }
    }
}
