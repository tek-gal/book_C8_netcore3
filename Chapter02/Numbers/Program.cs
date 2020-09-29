using System;

namespace Numbers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"Double uses {sizeof(double)} and stores {double.MinValue:N0} - {double.MaxValue:N0}");
            Console.WriteLine($"Decimal uses {sizeof(decimal)} and stores {decimal.MinValue:N0} - {decimal.MaxValue:N0}");

            Console.WriteLine("Using double");

            double a = 0.1;
            double b = 0.2;

            double result = a + b;

            if (result == 0.3) {
                Console.WriteLine("The result equals 0.3");
            } else {
                Console.WriteLine("The result does NOT equal 0.3");
            }

            Console.WriteLine("Using decimal");

            decimal aa = 0.1M;
            decimal bb = 0.2M;

            decimal result2 = aa + bb;

            if (result2 == 0.3M) {
                Console.WriteLine("The result equals 0.3");
            } else {
                Console.WriteLine("The result does NOT equal 0.3");
            }

            Console.WriteLine(double.NaN);
            Console.WriteLine(double.Epsilon);  // the smallest positive number can be stored in a double
            Console.WriteLine(double.PositiveInfinity);
        }
    }
}