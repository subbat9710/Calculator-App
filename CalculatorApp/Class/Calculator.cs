using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CalculatorApp.Class
{
    public class Calculator
    {
        public float Addition { get; set; }
        public float Subtraction { get; set; }
        public float Division { get; set; }
        public float Multiplication { get; set; }
        public float SquareOfNumber { get; set; }

        public Calculator()
        {
        }

        public void Start()
        {
            UI userInterface = new UI();
            userInterface.StartMeUp();
        }

        public void Add(float firstNumber, float secondNumber)
        {
            Addition = firstNumber + secondNumber;
            Console.WriteLine($"Your Result: {firstNumber} + {secondNumber} = {Addition}");
            Log.WriteLog($"{firstNumber} + {secondNumber} = {Addition}");
        }

        public void Subtract(float firstNumber, float secondNumber)
        {
            Subtraction = firstNumber - secondNumber;
            Console.WriteLine($"Your Result: {firstNumber} - {secondNumber} = {Subtraction}");
            Log.WriteLog($"{firstNumber} - {secondNumber} = {Subtraction}");
        }

        public void Divide(float firstNumber, float secondNumber)
        {
            try
            {
                Division = firstNumber / secondNumber;
                Console.WriteLine($"Your Result: {firstNumber} / {secondNumber} = {Division}");
                Log.WriteLog($"{firstNumber} / {secondNumber} = {Division}");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPS! you can't divide by Zero!");
            }
        }

        public void Multiply(float firstNumber, float secondNumber)
        {
            Multiplication = firstNumber * secondNumber;
            Console.WriteLine($"Your Result: {firstNumber} * {secondNumber} = {Multiplication}");
            Log.WriteLog($"{firstNumber} * {secondNumber} = {Multiplication}");
        }

        public void Squar(float firstNumber)
        {
            SquareOfNumber = firstNumber * firstNumber;
            Console.WriteLine($"Square of {firstNumber} is {SquareOfNumber}");
            Log.WriteLog($"Square of {firstNumber} is {SquareOfNumber}");
        }
    }
}
