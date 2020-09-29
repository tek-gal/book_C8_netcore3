using System;
using System.Collections.Generic;

namespace Exercise4._2 {
    public class PrimeFactors {

        public static string Get(int number) {
            string result;

            if (number >= 1000) {
                result = "The number is too big!";
            } else if (number <= 1) {
                result = "The number is too small!";
            } else {
                result = string.Join(" x ", Factorize(number));
            }

            return result;
        }

        public static List<int> Factorize(int number) {
            List<int> primeFactors = new List<int>();
            int sqrt = Convert.ToInt32((Math.Ceiling(Math.Sqrt(number))));

            for (int i = 2; i <= sqrt; i++) {
                while (number % i == 0) {
                    primeFactors.Add(i);
                    number /= i;
                }

            }

            if (number != 1) {
                primeFactors.Add(number);
            }

            return primeFactors;
        }
    }

}