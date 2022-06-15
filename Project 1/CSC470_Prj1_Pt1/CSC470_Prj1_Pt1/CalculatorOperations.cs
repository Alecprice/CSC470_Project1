using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_Prj1_Pt1
{
	class Calculator
	{
		public static double DoOperation(double num1, double num2, string mathOperation)
		{
			double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.


			switch (mathOperation)
			{
				case "a":
				case "add":
				case "+":
					result = num1 + num2;
					break;
				case "s":
				case "subtract":
				case "-":
					result = num1 - num2;
					break;
				case "m":
				case "multiply":
				case "*":
					result = num1 * num2;
					break;
				case "d":
				case "divide":
				case "/":
					if (num2 != 0)
					{
						result = num1 / num2;
					}

					break;

				// Return text for an incorrect entry.
				default:
					break;
			}
			return result;
		}
	}
}
