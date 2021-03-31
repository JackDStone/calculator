using System;

namespace Calculator
{
    class Program
    {
        static void Introduction()
        {
            Console.WriteLine("Welcome to my calculator application!");
            Console.WriteLine("Please enter 1 for addition, enter 2 for subtraction,");
            Console.WriteLine("Enter 3 for division, or enter 4 for multiplication.");
            Console.WriteLine("Alternatively, enter 0 to repeat this message");
            // introduction

            Console.Write("Please select the required skill: ");
            string selection = Console.ReadLine();
            // selection recorded and selected
        }
        static void CalcAdd()
        {
            Console.WriteLine("Addition selected...");
            Console.Write(value: "Enter a number: ");
            double addNum1 = Convert.ToDouble(Console.ReadLine());
            // num 1 recorded

            Console.Write("Enter a second number: ");
            double addNum2 = Convert.ToDouble(Console.ReadLine());
            // num 2 recorded

            
            Console.WriteLine(addNum1 + addNum2);
            // total of num 1 and num 2 calculated
        }

        static void CalcSubtract()
        {
            Console.WriteLine("Subtraction selected...");
            Console.Write(value: "Enter a number: ");
            double subNum1 = Convert.ToDouble(Console.ReadLine());
            // num 1 recorded

            Console.Write("Enter a second number: ");
            double subNum2 = Convert.ToDouble(Console.ReadLine());
            // num 2 recorded

            Console.WriteLine(subNum1 - subNum2);
            // difference of num 1 and num 2 calculated
        }

        static void CalcDivide()
        {
            Console.WriteLine("Division selected...");
            Console.Write(value: "Enter a number: ");
            double divNum1 = Convert.ToDouble(Console.ReadLine());
            // num 1 recorded

            Console.Write("Enter a second number: ");
            double divNum2 = Convert.ToDouble(Console.ReadLine());
            // num 2 recorded

            Console.WriteLine(divNum1 / divNum2);
            // division of num 1 and num 2 calculated
        }

        static void CalcMultiply()
        {
            Console.WriteLine("Multiplication selected...");
            Console.Write(value: "Enter a number: ");
            double mulNum1 = Convert.ToDouble(Console.ReadLine());
            // num 1 recorded

            Console.Write("Enter a second number: ");
            double mulNum2 = Convert.ToDouble(Console.ReadLine());
            // num 2 recorded

            Console.WriteLine(mulNum1 * mulNum2);
            // product of num 1 and num 2 calculated
        }

        static void Main(string[] args)
        {
            Introduction();
            string selection = Console.ReadLine();
            // introduction

            if (selection == "0")
            {
                Introduction();
            }
            else if (selection == "1")
            {
                CalcAdd();
            }
            else if (selection == "2")
            {
                CalcSubtract();
            }
            else if (selection == "3")
            {
                CalcDivide();
            }
            else if (selection == "4")
            {
                CalcMultiply();
            }
            else
            {
                Console.Write("Invalid selection. ");
            }

            Console.WriteLine("Thank you for using my calculator! Re-open the executable to process another calculation.");
            Console.ReadLine();

        }
    }
}        
            
