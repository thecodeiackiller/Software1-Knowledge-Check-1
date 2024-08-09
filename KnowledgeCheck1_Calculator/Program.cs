using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your homemade calculator.");
            Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    var addNumber2 = Console.ReadLine();

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subtractNumber1 = Console.ReadLine();
                    var subtractNumber2 = Console.ReadLine();

                    if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    var multiplynum1 = Console.ReadLine();
                    var multiplynum2 = Console.ReadLine();

                    if(int.TryParse(multiplynum1,out int mulNumOne) && int.TryParse(multiplynum2 ,out int mulNumTwo))
                    {
                        Console.Write($"Multiplying numbers {multiplynum1} & {multiplynum2} equals");
                        Console.Write(calculator.Multiply(mulNumTwo,mulNumOne));
                    }
                    else
                    {
                        Console.WriteLine("One of more of the integers is not an int.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;
                    break;

                default:
                    Console.WriteLine("Unknown input. Please enter a number 1 through 4.");
                    break;
            }
        }
    }
}