using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Repositories
{
    public class Operations
    {
        public static void Addition()
        {
            (double firstNumber, double secondNumber) = ValidNumber.GetValidNumbers();
            double result = firstNumber + secondNumber;
            Console.WriteLine("the result of the sum operation is: " + result);
            Console.ReadKey();
            Program.Menu();
        }
        public static void Subtraction()
        {
            (double firstNumber, double secondNumber) = ValidNumber.GetValidNumbers();
            double result = firstNumber - secondNumber;
            Console.WriteLine("the result of the subtraction operation: " + result);
            Console.ReadKey();
            Program.Menu();
        }
        public static void Division()
        {
            (double firstNumber, double secondNumber) = ValidNumber.GetValidNumbers();
            double result = firstNumber / secondNumber;
            Console.WriteLine("the result of the division operation: " + result);
            Console.ReadKey();
            Program.Menu();
        }
        public static void Multiplication()
        {
            (double firstNumber, double secondNumber) = ValidNumber.GetValidNumbers();
            double result = firstNumber * secondNumber;
            Console.WriteLine("the result of the multiplication operation: " + result);
            Console.ReadKey();
            Program.Menu();
        }





    }
}
