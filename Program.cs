using System;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Enter first number");
		string cislicko = Console.ReadLine();
		decimal cislickoprvni = Convert.ToDecimal(cislicko);
		Console.WriteLine("Enter type of operation");
		string metoda = Console.ReadLine();
		Console.WriteLine("Enter second number");
		string cislicko2 = Console.ReadLine();
		decimal cislickodruhe = Convert.ToDecimal(cislicko2);
		string[] operations = new string[4] { "/", "*", "+", "-" };
		if (metoda == operations[0])
		{
			if (cislickodruhe != 0m)
			{
				Console.WriteLine("cant divide by 0");
			}
			else
			{
				decimal resukt1 = cislickoprvni / cislickodruhe;
				Console.WriteLine($"It equals to {resukt1}");
			}
		}
		else if (metoda == operations[1])
		{
			decimal result2 = cislickoprvni * cislickodruhe;
			Console.WriteLine($"It equals to {result2}");
		}
		else if (metoda == operations[3])
		{
			decimal result3 = cislickoprvni + cislickodruhe;
			Console.WriteLine($"It equals to {result3}");
		}
		else if (metoda == operations[4])
		{
			decimal result4 = cislickoprvni - cislickodruhe;
			Console.WriteLine($"It equals to {result4}");
		}
		else
		{
			Console.WriteLine("Operation doesnt exist");
		}
		Console.ReadKey();
	}
}
