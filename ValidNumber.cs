using System;

namespace Calculator.Repositories
{
    public class ValidNumber
    {
        public static bool IsValidNumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        public static (double, double) GetValidNumbers()
        {
            Console.WriteLine("Enter the first number: ");
            string valor1 = Console.ReadLine();
            while (!IsValidNumber(valor1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                valor1 = Console.ReadLine();
            }
            double firstNumber = double.Parse(valor1);
            Console.WriteLine("Enter the second number:");
            string valor2 = Console.ReadLine();
            while (!IsValidNumber(valor2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                valor2 = Console.ReadLine();
            }
            double secondNumber = double.Parse(valor2);

            return (firstNumber, secondNumber);
        }
    }
}
