using System;

namespace ECS_Calculator.Operations
{
    internal static class Factorial
    {
        public static long Calculate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Факторіал визначений тільки для невід'ємних чисел.");
            }

            long result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}