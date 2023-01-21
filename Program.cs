using System;
using Calculator.Repositories;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {            
            Console.Clear();
            Console.WriteLine("choose one of the options");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("| 1 - Addition        |");
            Console.WriteLine("| 2 - Subtraction     |");
            Console.WriteLine("| 3 - Division        |");
            Console.WriteLine("| 4 - Multiplication  |");
            Console.WriteLine("| 5 - Exit            |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("select an option: ");
            int res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Operations.Addition(); break;
                case 2: Operations.Subtraction(); break;
                case 3: Operations.Division(); break;
                case 4: Operations.Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
       
    }
}


