using System;
using static System.Console;

#nullable enable

namespace NullHandling {
    class Address {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program {
        static void Main(string[] args) {
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            string? author = null;
            int? y = author?.Length ?? 4;

            int thisCannotBeNull = 4;
            // thisCannotBeNull = null;

            int? thisCouldBeNull = 5;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = null;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            WriteLine(
                format: "{0, -8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            WriteLine(
                format: "{0, -8} {1,6:N0}",
                arg0 : applesText,
                arg1 : applesCount
            );

            WriteLine(
                format: "{0, -8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            ConsoleKeyInfo key = ReadKey();

            WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");
        }
    }
}