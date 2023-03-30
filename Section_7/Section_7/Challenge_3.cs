using System;
namespace Section_7
{
	class Challenge_3
	{
		static int[,] matrix =
		{
			{ 1, 2, 3},
			{ 4, 5, 6},
			{ 7, 8, 9}
		};

		static void main(string[] args)
		{
			foreach(int item in matrix)
			{
				Console.WriteLine(item + "");
				Console.Read();
			}

			Console.WriteLine("This is our 2D array printed using nested for loop");

			for(int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.WriteLine(matrix[i, j] % 2 == 0 ? matrix[i, j] + "" : "even number");
					Console.Read();

				}
			}
		}
	}
	
}

