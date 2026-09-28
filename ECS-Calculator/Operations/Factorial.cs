using System;
using System.Numerics; // FIX: додано BigInteger для підтримки великих факторіалів

namespace ECS_Calculator.Operations
{
    internal static class Factorial
    {
        // FIX: long замінено на BigInteger, щоб уникнути переповнення після 20!
        public static BigInteger Calculate(int number)
        {
            if (number < 0)
            {
                // FIX: виправлено зайві крапки в повідомленні
                throw new ArgumentException(
                    "Факторіал визначений тільки для невід'ємних чисел.");
            }

            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}

