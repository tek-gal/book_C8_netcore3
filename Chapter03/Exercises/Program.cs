using System;

namespace Exercises {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(8d / 0);

            // for (; true;) {;
            // }

            // int a = 2;
            // int b = 3;

            // var result = operation switch {
            //     "+" => a + b,
            //     "-" => a - b,
            //     "/" => a / b,
            //     _ => throw new NotSupportedException()
            // };  

            // Ex 02
            // int max = 500;
            // for (byte i = 0; i < max; i++) {
            //     checked {
            //         Console.WriteLine(i);
            //     }
            // }

            // Ex 03
            // for (int i = 1; i <= 100; i++) {
            //     if (i % 15 == 0)Console.Write("FizzBuzz");
            //     else if (i % 5 == 0)Console.Write("Buzz");
            //     else if (i % 3 == 0)Console.Write("Fizz");
            //     else Console.Write(i);

            //     if (i < 100)Console.Write(", ");
            //     if (i % 10 == 0)Console.WriteLine("");
            // }

            // Ex 04
            // try {
            //     Console.Write("Enter a number berween 0 and 255: ");
            //     string input1 = Console.ReadLine();
            //     Console.Write("Enter another number berween 0 and 255: ");
            //     string input2 = Console.ReadLine();

            //     int number1 = int.Parse(input1);
            //     int number2 = int.Parse(input2);

            //     int result = number1 / number2;
            //     Console.WriteLine($"{number1} divided by {number2} is {result}");
            // } catch (FormatException ex) {
            //     Console.WriteLine($"{nameof(FormatException)}: Input string was not a correct format.");
            // }

            // Ex 05
            int x1 = 3;
            int y1 = 2 + ++x1;
            Console.WriteLine(y1); // 6

            int x2 = 3 << 2;
            int y2 = 10 >> 1;
            Console.WriteLine(x2); // 12
            Console.WriteLine(y2); // 5

            int x3 = 10 & 8; // 1010 & 1000 = 1010
            int y3 = 10 | 7; // 1010 | 0111 = 1111 (15)
            Console.WriteLine(x3);
            Console.WriteLine(y3);

            byte b = 10;
            Console.WriteLine(b << 15);
        }
    }
}