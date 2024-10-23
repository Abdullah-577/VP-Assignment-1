using System;

class Program
{
    static void Main()
    {
        int[,,] cube = new int[3, 3, 3];
        int maindiagonalSum = 0;

        Console.WriteLine("Enter values for the 3x3x3 cube:");

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    Console.Write($"cube[{x},{y},{z}]: ");
                    cube[x, y, z] = int.Parse(Console.ReadLine());
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            maindiagonalSum += cube[i, i, i];
        }

        Console.WriteLine($"The sum of the main diagonal is: {maindiagonalSum}");
    }
}
