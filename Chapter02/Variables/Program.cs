using System;

namespace Variables {
    class Program {
        static void Main(string[] args) {
            object height = 1.88;
            object name = "Amir";
            Console.WriteLine($"{name} is {height} meter tall.");

            // int length1 = name.Length; // compiler error
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");

            // dynamic variable
            dynamic anotherName = "Ahmed";
            int length = anotherName.Length;

            // can use var to make the compiler retrieve type
            int population = 66_000_000;
            double weight = 1.88;
            decimal proce = 4.99M;
            string fruit = "Apples";
            char letter = 'Z';
            bool happy = true;

            // default values for type
            // string is reference type - it contains memory adderss but not hte value itself
            // default value fot string is null - declared variable can contain nothing - null
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}