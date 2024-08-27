﻿using System;

public class Exercise7
{
	public static void Main()
	{
		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter another number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
		Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
		Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);

		// Handle division by zero
		if (num2 != 0)
		{
			Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
			Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
		}
		else
		{
			Console.WriteLine("Division by zero is not allowed.");
		}

		Console.ReadKey();  // Correct method call to wait for a key press before closing
	}
}
