using System;

namespace ECS_Calculator.Operations
{
    public static class MultiplyDivide
    {
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Ділення на нуль неможливе.");
    }
}