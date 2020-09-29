using System;
using static System.Console; // импортирует только доступные статические челны и типы

namespace Operators {
    class Program {
        static void Main(string[] args) {
            int a = 8;
            Console.WriteLine(Convert.ToString(a, 2)); // 0000 1000
            Console.WriteLine(Convert.ToString(a << 1, 2)); // 0001 0000
        }
    }
}