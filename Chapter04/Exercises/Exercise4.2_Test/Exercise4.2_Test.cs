using System;
using System.Collections.Generic;
using Exercise4._2;
using Xunit;

namespace Exercise4._2_Test {
    public class UnitTest1 {
        [Fact]
        public void Get_Factorize_for_2() {
            // arrange
            int number = 2;
            string expected = "2";

            // act
            string result = PrimeFactors.Get(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Get_Factorize_for_4() {
            // arrange
            int number = 4;
            string expected = "2 x 2";

            // act
            string result = PrimeFactors.Get(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Get_Factorize_for_5() {
            // arrange
            int number = 5;
            string expected = "5";

            // act
            string result = PrimeFactors.Get(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Get_Factorize_for_100() {
            // arrange
            int number = 100;
            string expected = "2 x 2 x 5 x 5";

            // act
            string result = PrimeFactors.Get(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Get_Factorize_for_1000() {
            // arrange
            int number = 1000;
            string expected = "The number is too big!";

            // act
            string result = PrimeFactors.Get(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Get_Factorize_for_1() {
            // arrange
            int number = 1;
            string expected = "The number is too small!";

            // act
            string result = PrimeFactors.Get(number);

            Assert.Equal(expected, result);
        }
    }
}