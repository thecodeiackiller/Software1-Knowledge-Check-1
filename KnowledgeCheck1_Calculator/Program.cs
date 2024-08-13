using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math.");
            Console.WriteLine("Enter 1 to Add");
            Console.WriteLine("Enter 2 to Subtract");
            Console.WriteLine("Enter 3 to Multiply");
            Console.WriteLine("Enter 4 to Divide");
            Console.WriteLine();

            string mathStart = "Enter two numbers. Press ENTER after each number.";
            string errorMessage = "Invalid numbers. Please enter two valid numbers";
            string calculation = Console.ReadLine();

            switch(calculation)
            {
                case "1":
                    Console.WriteLine(mathStart);
                    // Is there a way to write a method that can simplify things even more when getting the input for the user:
                    string userInput1 = Console.ReadLine();
                    string userInput2 = Console.ReadLine();
                    if(Calculator.floatParseCheck(userInput1, userInput2, out float num1,out float num2)) 
                    {

                        Console.WriteLine($"{num1} + {num2} = {Calculator.Add(num1, num2)}");


                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                    break;
            }
            switch(calculation)
            {
                case "2":
                    Console.WriteLine(mathStart);
                    string userInput1 = Console.ReadLine();
                    string userInput2 = Console.ReadLine();
                    if(Calculator.floatParseCheck(userInput1,userInput2, out float num1, out float num2))
                    {
                        Console.WriteLine($"{num1} - {num2} = {Calculator.Substract(num1,num2)}");
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                    break;
            }
            switch (calculation)
            {
                case "3":
                    Console.WriteLine(mathStart);
                    string userInput1 = Console.ReadLine();
                    string userInput2 = Console.ReadLine();
                    if (Calculator.floatParseCheck(userInput1, userInput2, out float num1, out float num2))
                    {
                        Console.WriteLine($"{num1} * {num2} = {Calculator.Multiply(num1, num2)}");
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                    
                    break;
            }
            switch (calculation)
            {
                case "4":
                    Console.WriteLine(mathStart);
                    string userInput1 = Console.ReadLine();
                    string userInput2 = Console.ReadLine();
                    if (Calculator.floatParseCheck(userInput1, userInput2, out float num1, out float num2))
                    {
                        Console.WriteLine($"{num1} / {num2} = {Calculator.Divide(num1, num2)}");
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                    break;
            }




        }
    }
}