using System;
using CalculatorFunctions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions obj = new Functions();

            Console.WriteLine("Enter two numbers");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(string.Format("Addition = {0}", obj.Addition(num1, num2)));

            Console.WriteLine(string.Format("Subtraction = {0}" , obj.Subtraction(num1, num2)));

            Console.WriteLine(string.Format("Multiplication = {0}" , obj.Multiplication(num1, num2)));

            Console.WriteLine(string.Format("Division = {0}" , obj.Division(num1, num2)));

            Console.WriteLine(string.Format("Modulus = {0}" , obj.Mod(num1, num2)));

            Console.ReadLine();
        }
    }
}