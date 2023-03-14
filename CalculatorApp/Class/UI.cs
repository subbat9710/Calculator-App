using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CalculatorApp.Class
{
    public class UI
    {
        public void StartMeUp()
        {
            Console.WriteLine("Welcome to the Calculator App");
            Console.WriteLine("*****************************");
            Console.WriteLine();

            Calculator calculator = new Calculator();

            try
            {
                Console.WriteLine("Last five calculations History: Y/N");
                Console.WriteLine();
                string yesNo = Console.ReadLine().ToLower().Trim();
                if (yesNo == "y")
                {
                    using (StreamReader sr = new StreamReader(@"C:\Users\Student\workspace\side-projects\CalculatorApp\CalculatorApp\bin\Debug\netcoreapp3.1\History.txt"))
                    {
                        List<string> lines = new List<string>();

                        while (!sr.EndOfStream)
                        {
                            lines.Add(sr.ReadLine());
                            if (lines.Count > 5)
                            {
                                lines.RemoveAt(0);
                            }
                        }
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Type first number then press Enter:");
                float firstInput = float.Parse(Console.ReadLine());
                Console.WriteLine("Type second number then press Enter:");
                float secondInput = float.Parse(Console.ReadLine());

                Console.WriteLine("What is your option?");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Square of First Number");
                string userPick = Console.ReadLine();

                if (userPick == "1")
                {
                    calculator.Add(firstInput, secondInput);
                }
                else if (userPick == "2")
                {
                    calculator.Subtract(firstInput, secondInput);
                }
                else if (userPick == "3")
                {
                    calculator.Divide(firstInput, secondInput);
                }
                else if (userPick == "4")
                {
                    calculator.Multiply(firstInput, secondInput);
                }
                else if (userPick == "5")
                {
                    calculator.Squar(firstInput);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }          
        }
    }
}
