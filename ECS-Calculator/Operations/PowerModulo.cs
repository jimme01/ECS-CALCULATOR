using System;

namespace ECS_Calculator.Operations
{
    public static class PowerModulo
    {
        public static double Power(double baseNumber, double exponent) => Math.Pow(baseNumber, exponent);
        public static double Modulo(double a, double b) => a % b;
    }
}