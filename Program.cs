using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[50, 50];

        // Fill the matrix with random values between 0 and 100
        Random rand = new Random();
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                matrix[i, j] = rand.Next(0, 101);
            }
        }

        int median = CalculateMedian(matrix);

        Console.WriteLine("The median value in the matrix is: {0}", median);

        Console.ReadKey();
    }

    static int CalculateMedian(int[,] matrix)
    {
        int[] values = new int[2500];
        int index = 0;

        // Copy the values of the matrix into a one-dimensional array
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                values[index] = matrix[i, j];
                index++;
            }
        }

        // Sort the array
        Array.Sort(values);

        // Find the median value
        int middle = values.Length / 2;
        int median;
        if (values.Length % 2 == 0)
        {
            median = (values[middle - 1] + values[middle]) / 2;
        }
        else
        {
            median = values[middle];
        }

        return median;
    }
}