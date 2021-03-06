using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_Prj1_Pt1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool endConsoleApp = false;
			// Display title as the C# console calculator app.
			Console.WriteLine(" Calculator in C#\r");
			Console.WriteLine("------------------------\n");

			while (!endConsoleApp)
			{
				// Declare variables and set to empty.
				string numInput1 = "";
				string numInput2 = "";
				double result = 0;

				// Ask the user to type the first number.
				Console.Write("First number : ");
				numInput1 = Console.ReadLine();

				double cleanNum1 = 0;
				while (!double.TryParse(numInput1, out cleanNum1))
				{
					Console.Write("This is not valid input. Please enter an integer value: ");
					numInput1 = Console.ReadLine();
				}

				// Ask the user to choose an operator.
				Console.WriteLine("Choose an operator from the following list:");
				Console.WriteLine("\ta - Add (+)");
				Console.WriteLine("\ts - Subtract (-)");
				Console.WriteLine("\tm - Multiply (*)");
				Console.WriteLine("\td - Divide (/)");
				Console.Write("Your option? ");

				string MathOperation = Console.ReadLine();


				// Ask the user to type the second number.
				Console.Write("Type second number, and then press Enter: ");
				numInput2 = Console.ReadLine();

				double cleanNum2 = 0;
				while (!double.TryParse(numInput2, out cleanNum2))
				{
					Console.Write("This is not valid input. Please enter an integer value: ");
					numInput2 = Console.ReadLine();
				}


				try
				{
					result = Calculator.DoOperation(cleanNum1, cleanNum2, MathOperation.ToLower());
					if (double.IsNaN(result))
					{
						Console.WriteLine("This operation will result in a mathematical error.\n");
					}
					else Console.WriteLine("Your result: {0:0.##}\n", result);
				}
				catch (Exception e)
				{
					Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
				}

				Console.WriteLine("------------------------\n");

				// Wait for the user to respond before closing.
				Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
				if (Console.ReadLine() == "n") endConsoleApp = true;

				Console.WriteLine("\n"); // Friendly linespacing.
			}
			return;
		}
	}
}