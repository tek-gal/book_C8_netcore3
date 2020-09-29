using System;
using static System.Console;

namespace Arguments {
    class Program {
        static void Main(string[] args) {
            WriteLine($"There are {args.Length}");

            foreach (string arg in args) {
                WriteLine(arg);
            }

            if (args.Length < 4) {
                WriteLine("You must specify two colors and dimentions.");
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true
            );

            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
        }
    }
}