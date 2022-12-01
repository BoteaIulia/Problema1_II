using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Introduceti cate numere va contine sirul:");
		Console.Write("\n");
		Console.Write("n= ");


		int n;
		int pare = 0;
		n = Convert.ToInt32(Console.ReadLine());

		Console.Write("\n");

		for (int i = 0; i < n; i++)
		{
			int nr;
			nr = Convert.ToInt32(Console.ReadLine());
			if (nr % 2 == 0)
			{
				pare++;
			}
			
		}
		Console.Write("\n");
		Console.Write("Sirul contine "+pare+" numere pare");
		Console.Write("\n");


	}
}