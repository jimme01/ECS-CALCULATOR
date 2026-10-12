namespace ECS_Calculator.Operations
{
    public static class GcdLcm
    {
        public static long Gcd(long a, long b)
        {
            a = System.Math.Abs(a);
            b = System.Math.Abs(b);

            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static long Lcm(long a, long b)
        {
            if (a == 0 || b == 0)
                return 0;

            return System.Math.Abs(a * b) / Gcd(a, b);
        }
    }
}