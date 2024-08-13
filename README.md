# Code:You - Knowledge Check 1: Calculator Refactor

Welcome to my repository for the Code:You programming program! This project is a refactor of an existing calculator application that was provided as part of a knowledge check to ensure a solid understanding of fundamental programming concepts in C#. The focus of this project is on creating methods, defining classes, and effectively utilizing these classes and their methods within the `Main` method in the `Program.cs` file.

## Project Overview

In this knowledge check, I have refactored the original project, which I forked and cloned, to enhance its functionality and maintainability. The key improvements I made include:

- **Refactoring for Readability and Reusability**:
  - I created a new method in the `Calculator` class to encapsulate the `TryParse` logic. This method simplifies the process of converting user input strings into integers, ensuring that the input can be parsed correctly before performing any calculations.

- **Enhancing Calculation Accuracy**:
  - After successfully parsing the user input into integers, I converted these integers into `float` values. This adjustment better represents real-life calculator behavior, especially when performing division operations, which require higher precision.

- **Efficient Coding Practices**:
  - I utilized **expression-bodied members** for one-liner methods in the `Calculator` class. This approach makes the code more concise and easier to read, adhering to modern C# coding standards.

## Project Structure

The project contains the following key files:

- **`Program.cs`**: Contains the `Main` method, which serves as the entry point of the application. This file handles user input, performs calculations using the `Calculator` class, and displays results.

- **`Calculator.cs`**: A class that defines various mathematical operations such as addition, subtraction, multiplication, and division. The class also includes a method to check if user input can be parsed into integers using `TryParse`.

## How to Use

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/knowledge-check-1-calculator-refactor.git
