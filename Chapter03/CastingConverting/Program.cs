using System;

namespace CastingConverting {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double e = 9.8;
            int d = (int)e;
            Console.WriteLine(d);

            long longV = long.MaxValue; // int64
            int intV = (int)longV;
            Console.WriteLine($"Long {longV:N0} casted to int {intV:N0}");

            double g = 9.3;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"Double {g} casted to int {h}");

            double[] doubles = new [] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double dd in doubles) {
                Console.WriteLine($"ToInt({dd}) is {Convert.ToInt32(dd)}");
            }

            // convering bytes 
            byte[] binaryObject = new byte[128];
            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);
            Console.WriteLine("Binary Object in bytes:");
            for (int index = 0; index < binaryObject.Length; index++) {
                Console.Write($"{binaryObject[index]:X}");
            }
            Console.WriteLine();

            // convert to base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            Console.WriteLine($"Binary Object as Base64: {encoded}");
            
            // parsing
            Console.WriteLine($"{int.Parse("24")}");
            Console.WriteLine($"{DateTime.Parse("10 January 1996")}");
            Console.WriteLine($"{DateTime.Parse("10 January 1996"):D}");
        }
    }
}