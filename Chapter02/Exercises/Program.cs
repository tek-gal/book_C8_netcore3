using System;
using System.Linq;

namespace Exercise02 {
    public class Writer {
        public void WriteHeader() {
            string text = this.CreateLine("Type", "Byte(s) of memory", "Min", "Max");
            string bar = new String('-', text.Length);
            Console.WriteLine(text);
        }

        public void WriteDividor() {
            string text = this.CreateLine("", "", "", "");
            string bar = new String('-', text.Length);
            Console.WriteLine(bar);
        }

        public void WriteLine<T>(string name, int size, T minValue, T maxValue) {
            string text = this.CreateLine(name, size, minValue, maxValue);
            Console.WriteLine(text);
        }

        private string CreateLine(dynamic arg0, dynamic arg1, dynamic arg2, dynamic arg3) {
            return String.Format(
                "{0,-8} {1,-20} {2,-35} {3,-35}", arg0, arg1, arg2, arg3
            );
        }

    }

    class Program {
        static void Main(string[] args) {
            var writer = new Writer();
            writer.WriteDividor();
            writer.WriteHeader();
            writer.WriteDividor();
            writer.WriteLine<sbyte>("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            writer.WriteLine<byte>("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            writer.WriteLine<short>("short", sizeof(short), short.MinValue, short.MaxValue);
            writer.WriteLine<ushort>("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            writer.WriteLine<int>("int", sizeof(int), int.MinValue, int.MaxValue);
            writer.WriteLine<uint>("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            writer.WriteLine<long>("long", sizeof(long), long.MinValue, long.MaxValue);
            writer.WriteLine<ulong>("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            writer.WriteLine<float>("float", sizeof(float), float.MinValue, float.MaxValue);
            writer.WriteLine<double>("double", sizeof(double), double.MinValue, double.MaxValue);
            writer.WriteLine<decimal>("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            writer.WriteDividor();
        }
    }
}