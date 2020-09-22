using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp
{
	public class MathCalculator
	{
		public void Menu() 
		{
			try
			{
				int a;
				Console.WriteLine("Math App\n\nPlease select from the following options:\n\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit\n");
				string b = Console.ReadLine();


				while (int.TryParse(b, out a) == false || a < 1 || a > 5)
				{

					Console.WriteLine("Please pick a number between 1 and 5!");
					b = Console.ReadLine();

				}


				if (a == 1)
				{
					Addition();
					Menu();
				}
				else if (a == 2)
				{
					Subtraction();
					Menu();
				}
				else if (a == 3)
				{
					Multiplication();
					Menu();
				}
				else if (a == 4)
				{
					Division();
					Menu();
				}
				else if (a == 5)
				{
					Exit();
				}

			}
			catch (DivideByZeroException dEx)
			{
				Console.WriteLine(dEx);
				Division();
			}
			catch (FormatException fEx)
			{
				Console.WriteLine(fEx);
			}
			catch (OverflowException oEx)
			{
				Console.WriteLine(oEx);
			}
			catch (InvalidOperationException ioEx)
			{
				Console.WriteLine(ioEx);
			}
			catch (Exception Ex)
			{
				Console.WriteLine(Ex);
			}
		}

		string Addition()
		{
			int a, b;
			Console.WriteLine("Please enter your first number:");
			string input = Console.ReadLine();
			while (int.TryParse(input, out a) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			Console.WriteLine("Please enter your second number:");
			input = Console.ReadLine();
			while (int.TryParse(input, out b) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			int c = checked (a + b);
			Console.WriteLine($"Your answer: {a} + {b} = {c}");
			return Console.ReadLine();
		}

		string Subtraction()
		{
			int a, b;
			Console.WriteLine("Please enter your first number:");
			string input = Console.ReadLine();
			while (int.TryParse(input, out a) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			Console.WriteLine("Please enter your second number:");
			input = Console.ReadLine();
			while (int.TryParse(input, out b) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			int c =  checked (a - b);
			Console.WriteLine($"Your answer: {a} - {b} = {c}");
			return Console.ReadLine();
		}

		string Multiplication()
		{
			double a, b;
			Console.WriteLine("Please enter your first number:");
			string input = Console.ReadLine();
			while (double.TryParse(input, out a) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			Console.WriteLine("Please enter your second number:");
			input = Console.ReadLine();
			while (double.TryParse(input, out b) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			double c = checked (a * b);
			Console.WriteLine($"Your answer: {a} * {b} = {c}");
			return Console.ReadLine();
		}

		string Division()
		{
			decimal a, b;
			Console.WriteLine("Please enter your first number:");
			string input = Console.ReadLine();
			while (decimal.TryParse(input, out a) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			Console.WriteLine("Please enter your second number:");
			input = Console.ReadLine();
			while (decimal.TryParse(input, out b) == false)
			{

				Console.WriteLine("Please enter a number!");
				input = Console.ReadLine();

			}
			decimal c = checked (a / b);
			Console.WriteLine($"Your answer: {a} / {b} = {c}");
			return Console.ReadLine();
		}

		string Exit()
		{
			Console.WriteLine("Thanks for stopping by!");
			return Console.ReadLine();
		}
	}
}
