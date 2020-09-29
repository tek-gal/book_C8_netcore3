using System;

namespace WritingFunctions {
    class Program {
        static void TimesTable(byte number) {
            Console.WriteLine($"This is the {number} times table.");
            for (int row = 1; row <= 12; row++) {
                Console.WriteLine($"{row} x {number} = {row * number}");
            }
            Console.WriteLine();
        }

        static void RunTimesTable() {
            bool isNumber;

            do {
                Console.Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(Console.ReadLine(), out byte number);

                if (isNumber) {
                    TimesTable(number);
                } else {
                    Console.WriteLine("You did not enter a valid number.");
                }
            } while (isNumber);
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode) {
            decimal rate = 0.0M;

            switch (twoLetterRegionCode) {
                case "CH":
                    rate = 0.08M;
                    break;
                case "DK":
                case "NO":
                    rate = 0.25M;
                    break;
                case "GB":
                case "FR":
                    rate = 0.2M;
                    break;
                case "HU":
                    rate = 0.27M;
                    break;
                case "OR":
                case "AK":
                case "MT":
                    rate = 0.0M;
                    break;
                default:
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }

        /// <summary>
        /// Pass a 32-bit integer to get the factorial.
        /// </summary>
        /// <param name="number">Number is an integer value.</param>
        /// <returns>Number as an integer.</returns>
        static int Factorial(int number) {
            if (number < 1) {
                return 0;
            } else if (number == 1) {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        static void RunFactorial() {
            bool isNumber;

            do {
                Console.Write("Enter a number between 0 and 255: ");
                isNumber = int.TryParse(Console.ReadLine(), out int number);

                if (isNumber) {
                    Console.WriteLine(Factorial(number));
                } else {
                    Console.WriteLine("The number isn't correct!");
                }

            } while (isNumber);
        }

        static void Main(string[] args) {
            RunFactorial();
        }
    }
}