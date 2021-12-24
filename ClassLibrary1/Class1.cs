using System;
//5.2 базовый 13 вариант 
namespace ClassLibrary1
{
    public class Class1
    {
        public static double sred(int[,] a, int b)
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum += a[b, i];
            }
            double arif = sum / a.GetLength(1);
            return arif;
        }
    }
}
