using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            double[,] a =
            {
                { double.Parse(args[0], culture), double.Parse(args[1], culture) },
                { double.Parse(args[2], culture), double.Parse(args[3], culture) }
            };

            double[,] b =
            {
                { double.Parse(args[4], culture) },
                { double.Parse(args[5], culture) }
            };

            double[,] result = new double[2, 1];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"| {result[i, j],7:F2} |");
                }
            }
        }
    }
}
