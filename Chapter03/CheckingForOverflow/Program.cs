using System;

namespace CheckingForOverflow {
    class Program {
        static void Main(string[] args) {
            try {
                checked {
                    int x = int.MaxValue - 1;
                    Console.WriteLine($"Initial value: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                }
            } catch (OverflowException) {
                Console.WriteLine("Wow! There is an overflow!");
            }

            unchecked {
                int y = int.MaxValue + 1;
                Console.WriteLine($"y = {y}");
            }

        }
    }
}