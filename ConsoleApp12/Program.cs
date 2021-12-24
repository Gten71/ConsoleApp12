using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[7, 6]
        {
       { 1, 2, 3, 4, 5, 6 },
       { -1, -2, -3, 4, 5, 6 },
        { 7, 8, 9, -10, 1, -9 },
        { -9, -8, -7, 11, -6, -5 },
       { 5, 6, 4, -9, 1, -3 },
        { 3, 5, 3, -7, 1, -2 },
        { 2, 8, 9, 5, 1, -6 }
        };
            double[] mas = new double[7];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                double sred = ClassLibrary1.Class1.sred(a, i);
                mas[i] = sred;
            }
            foreach (double item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
