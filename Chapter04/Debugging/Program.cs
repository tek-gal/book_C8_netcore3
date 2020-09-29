using System;

namespace Debugging {
    class Program {
        static double Add(double a, double b) {
            return a + b;
        }

        // F9 to place a breakpoint
        // F10 to step over -while debugging
        static void Main(string[] args) {
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a, b);
            Console.WriteLine($"{a} + {b} = {answer}");
            Console.ReadLine();
        }
    }
}